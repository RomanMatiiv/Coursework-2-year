using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using Microsoft.Win32;

namespace Курсач
{
    public partial class MainForm : Form
    {
        public static BindingList<Product> prodLst = new BindingList<Product>();//Список ноутбуков магазина
        
        //Для сериализации/десериализации
        XmlSerializer xs = new XmlSerializer(typeof(BindingList<Product>));
        FileStream fs;
        //Путь к файлу и деректории
        string path = "";
        public static string pathDirectory="";
        public string pathBackup = Directory.GetCurrentDirectory() + "\\Backup\\Backup.xml";

        public static int i;//Передает индекс выделенной строки в другую форму
        public static bool flagEditShow = true;//В зависимости от значения форма отображается в режие просмотра или редактирования

        //Проверка на ошибки
        string errorMes = "";
        bool flag = true;


        public MainForm()
        {
            InitializeComponent();
            //__________________________________________________________________________Работа с регистрами
            RegistryKey currentUserKey = Registry.CurrentUser;
            //Если регистра с полным путем нет создаю его и задаю путь по умолчанию
            RegistryKey pathk = currentUserKey.OpenSubKey("path");
            if(pathk==null)
            {
                pathk= currentUserKey.CreateSubKey("path");
                pathk.SetValue("path", "Product.xml");
            }
            pathk.Close();

            //Считываю регистр полного пути
            pathk = currentUserKey.OpenSubKey("path");
            path = pathk.GetValue("path").ToString();
            pathk.Close();
            //__________________________________________________________________________
            this.Width = 740;//Ширина окна по умолчанию

            try
            {
            //____________________________________________________________________________//1-й запуск Создаю пустой xml файл куда потом и буду записывать и считаваю с txt файла
            if(!File.Exists(path))//Если нет xml файла
                {
                    fs = new FileStream(path, FileMode.Create);
                    string[] arr = File.ReadAllLines("tmp.txt");//Название указать вручную при первом запуске

                    for (int i = 0; i < arr.Length; i = i + 9)
                        prodLst.Add(new Product(int.Parse(arr[i]), arr[i + 1], int.Parse(arr[i + 2]), int.Parse(arr[i + 3]), float.Parse(arr[i + 4]), arr[i + 5], int.Parse(arr[i + 6]), float.Parse(arr[i + 7]), bool.Parse(arr[i + 8])));

                    xs = new XmlSerializer(typeof(BindingList<Product>));//Сериализую для 2-го и далее запуска
                    xs.Serialize(fs, prodLst);//Сериализую

                    fs.Close();
                }
            //______________________________________________________________________________


            //_____________________________________________________________________________Считывает сериализованный файл при 2-ом и далее запусках
             fs = new FileStream(path, FileMode.Open);
             if(fs.Length!=0)
                prodLst = (BindingList<Product>)xs.Deserialize(fs);
             fs.Close();
            }
            //_____________________________________________________________________________   
            catch
            {
                MessageBox.Show("Файл не может быть правильно считат или не существует");
            }

            productBindingSource.DataSource = prodLst;//Главный список
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)//Добавить новый ноутбук(product)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void Filter_Click(object sender, EventArgs e) //Фильтрует в зависимости от заданых параметров
        {
            availBox.Visible = true;
            for (int i = 0; i < DGV.RowCount; i++)//Сброс фильтра(показывает все)
            DGV.Rows[i].Visible = true;

            flag = true;
            //___________________Проверка типов данных
            CheckFloat(priceBox);
            CheckInt(ramBox);
            CheckInt(hddBox);
            CheckFloat(displayBox);
            CheckString(processorBox);
            CheckInt(IDBox);
            CheckString(nameBox);
            //________________________

            if (flag)
            {
                DGV.CurrentCell = null;//Убирает выделение ячейки
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    //Цена
                    if (priceBox.Text.Trim(' ').Length != 0)
                        if (float.Parse(DGV["Price", i].Value.ToString()) > float.Parse(priceBox.Text.Trim(' ')))
                            DGV.Rows[i].Visible = false;
                    //RAM
                    if (ramBox.Text.Trim(' ').Length != 0)
                        if (int.Parse(DGV["RAM", i].Value.ToString()) != int.Parse(ramBox.Text.Trim(' ')))
                            DGV.Rows[i].Visible = false;
                    //HDD
                    if (hddBox.Text.Trim(' ').Length != 0)
                        if (int.Parse(DGV["Capacity", i].Value.ToString()) != int.Parse(hddBox.Text.Trim(' ')))
                            DGV.Rows[i].Visible = false;
                    //Диагональ
                    if (displayBox.Text.Trim(' ').Length != 0)
                        if (float.Parse(DGV["MonotorSize", i].Value.ToString()) > float.Parse(displayBox.Text.Trim(' ')))
                            DGV.Rows[i].Visible = false;
                    //Процессор
                    if (processorBox.Text.Trim(' ').Length != 0)
                        if (DGV["Processor", i].Value.ToString().ToLower() != processorBox.Text.ToLower().Trim(' '))
                            DGV.Rows[i].Visible = false;
                    //В наличае
                    if (availBox.Checked)
                        if (DGV["availability", i].Value.ToString() == "False")
                            DGV.Rows[i].Visible = false;
                    //ID
                    if (IDBox.Text.Trim(' ').Length != 0)
                        if (int.Parse(DGV["laptopID", i].Value.ToString()) != int.Parse(IDBox.Text.Trim(' ')))
                            DGV.Rows[i].Visible = false;
                    //Название
                    if (nameBox.Text.Trim(' ').Length != 0)
                        if (DGV["laptopName", i].Value.ToString().ToLower() != nameBox.Text.ToLower().Trim(' '))
                            DGV.Rows[i].Visible = false;
                }
            }
            else
            {
                MessageBox.Show(errorMes);
            }
        }

        public void CheckInt(ComboBox cb)//Проверка на int(ComboBox)
        {
            if (cb.Text.Length == 0) return;
            int tmp = 0;
            if (!int.TryParse(cb.Text, out tmp))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + cb.Name + " \nВведите целое число";
            }
            if (tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + cb.Name + " не может быть отрицательным  ";
            }
        }

        public void CheckInt(TextBox cb)//Проверка на int(TexBox)
        {
            if (cb.Text.Length == 0) return;
            int tmp = 0;
            if (!int.TryParse(cb.Text, out tmp))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + cb.Name + " \nВведите целое число";
            }
            if (tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + cb.Name + " не может быть отрицательным  ";
            }
        }

        public void CheckString(ComboBox cb)//Проверка на string(ComboBox)
        {
            if (cb.Text.Length == 0) return;
            int tmp1 = 0;
            float tmp2;

            if ((int.TryParse(cb.Text, out tmp1)) | (float.TryParse(cb.Text, out tmp2)))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + cb.Name + " \nВведите строковое значение";
            }
        }

        public void CheckString(TextBox cb)//Проверка на string(TexBox)
        {
            if (cb.Text.Length == 0) return;
            int tmp1 = 0;
            float tmp2;

            if ((int.TryParse(cb.Text, out tmp1)) | (float.TryParse(cb.Text, out tmp2)))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + cb.Name + " \nВведите строковое значение";
            }
        }

        public void CheckFloat(ComboBox cb)//Проверка на float
        {
            if (cb.Text.Length == 0) return;
            float tmp = 0;
            if (!float.TryParse(cb.Text, out tmp) & (tmp > 0))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + cb.Name + " введите цисло \nПример: 2,75 (через запятую)";
            }
            if (tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + cb.Name + " не может быть отрицательным  ";
            }
        }

        private void фильтрацияToolStripMenuItem_Click(object sender, EventArgs e)//Отображает/Убирает функционал фильтрации
        {
            for (int i = 0; i < DGV.RowCount; i++)//Сброс фильтра(показывает все)
                DGV.Rows[i].Visible = true;

            if (!Filter.Visible)
                Filter.Visible = true;
            else
                Filter.Visible = false;
            if (Filter.Visible)
                this.Width = 924;
            else
                this.Width = 740;

            priceBox.Text = "";
            ramBox.Text = "";
            hddBox.Text = "";
            displayBox.Text = "";
            processorBox.Text = "";
            availBox.Text = "";
            nameBox.Text = "";
            IDBox.Text = "";
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)//Удаляет запись
        {
            foreach (DataGridViewRow i in DGV.SelectedRows)
                DGV.Rows.Remove(i);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)//Инструкция к программме (Manual)
        {
            if (File.Exists("Manual\\Manual.txt"))
            {
                Process myProcess = null;
                try
                {myProcess = Process.Start("notepad.exe", "Manual\\Manual.txt"); }

                catch
                {MessageBox.Show("Программа notepad не найденна"); }
                myProcess.Close();
            }
            else
            {
                MessageBox.Show("Файл с инструкцией не найден");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)//Сохраняет список в файл (и создает копию)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey pathD = currentUserKey.OpenSubKey("pathD");

            if (pathD == null)//Сохраняет название папки которую ввел пользователь
            {
                pathD = currentUserKey.CreateSubKey("pathD");
                pathD.Close();

                FormForSave f = new FormForSave();
                f.ShowDialog();
                SaveFileDialog saveFD = new SaveFileDialog();

                Directory.CreateDirectory(Directory.GetCurrentDirectory().ToString() + String.Format("\\")+pathDirectory);
                saveFD.InitialDirectory = Directory.GetCurrentDirectory().ToString() + String.Format("\\")+pathDirectory;
                saveFD.DefaultExt = "xml";

                if (saveFD.ShowDialog() == DialogResult.OK & saveFD.FileName.Length > 0)
                {
                    fs = new FileStream(saveFD.FileName, FileMode.Create);
                    xs = new XmlSerializer(typeof(BindingList<Product>));
                    xs.Serialize(fs, prodLst);

                    //Создает директорию для backup-а и копирует туда файл при 1 запуске
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Backup");
                    File.Copy(saveFD.FileName, pathBackup);

                    CreateRegister(currentUserKey, saveFD);//Записываю в реестр полный путь с SaveFileDialog
                }
           
                CreateRegister(currentUserKey, pathDirectory);//Записываю в реестр имя папки для сохранения

                fs.Close();
            }
            else//Если имя папки дял сохранение уже было введено
            {
                SaveFileDialog saveFD = new SaveFileDialog();
                saveFD.InitialDirectory = path;
                saveFD.DefaultExt = "xml";
   
                if (saveFD.ShowDialog() == DialogResult.OK & saveFD.FileName.Length > 0)
                {
                    fs = new FileStream(saveFD.FileName, FileMode.Create);
                    xs = new XmlSerializer(typeof(BindingList<Product>));
                    xs.Serialize(fs, prodLst);
                    fs.Close();  

                    File.Copy(saveFD.FileName, pathBackup,true);//Создаю копию файла

                    CreateRegister(currentUserKey, saveFD); //Записываю в реестр полный путь с SaveFileDialog
                }
            }
        }

        public void CreateRegister(RegistryKey currentUserKey, SaveFileDialog saveFD) //Записываю в реестр полный путь с SaveFileDialog
        {
            currentUserKey = Registry.CurrentUser;
            RegistryKey pathK = currentUserKey.CreateSubKey("path");
            pathK.SetValue("path", saveFD.FileName);
            pathK.Close();
        }

        public void CreateRegister(RegistryKey currentUserKey,string pathDirectory)//Записываю в реестр имя папки для сохранения
        {
            RegistryKey pathDD = currentUserKey.CreateSubKey("pathD");
            pathDD.SetValue("pathD", pathDirectory.ToString());
            pathDD.Close();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)//Позаоляеи изменить информацию о продукте
        {
            flagEditShow = true;
            i= DGV.CurrentRow.Index;
            Edit_Show f = new Edit_Show();
            f.ShowDialog();
        }

        private void всяИнформацтяToolStripMenuItem_Click(object sender, EventArgs e)//Выводит всю информаумю о продукте
        {
            if (DGV.CurrentRow != null)
            {
                flagEditShow = false;
                i = DGV.CurrentRow.Index;
                Edit_Show f = new Edit_Show();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Выберите конкретную ячейку для просмотра");
            
        }

        private void путьКПрограммеToolStripMenuItem_Click(object sender, EventArgs e)//Выводит путь к программе
        {
            MessageBox.Show(Directory.GetCurrentDirectory(), "Путь к программе");
        }

        private void путьКСохраненномуФайлуToolStripMenuItem_Click(object sender, EventArgs e)//Выводит путь к сохраненному файлу
        {
            MessageBox.Show(path, "Путь к сохраненному фалу");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель Матиив Роман\nВсе права защищены\nПлагиат преследуется по закону", "О программе", MessageBoxButtons.OK);
        }//О программе

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//Выход
        {
            Application.Exit();
        }
    }
}