using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Edit_Show : Form
    {
        Product prd = new Product();
        bool flag = true;
        string errorMes = "";
        public Edit_Show()
        {
            InitializeComponent();
            prd = MainForm.prodLst[MainForm.i];//Отображаю выбранный объект

            name.Text = prd.LaptopName;
            ID.Text = prd.LaptopID.ToString();
            RAM.Text = prd.RAM.ToString();
            Capacity.Text = prd.Capacity.ToString();
            monSize.Text = prd.MonotorSize.ToString();
            processor.Text = prd.Processor.ToString();
            battery.Text = prd.BatteryCapacity.ToString();
            price.Text = prd.Price.ToString();
            availability.Checked = prd.Availability;

            ChangeMode(MainForm.flagEditShow);//Режим просмотра/редактирования
        }

        private void save_Click(object sender, EventArgs e)
        {
            flag = true;
            foreach (TextBox i in editBox.Controls)
            {
                if (i.Text.Length == 0)
                    flag = false;
            }

            errorMes = "Заполните все поля";
            //________________Проверяю типы данных
            CheckString(name);
            CheckInt(RAM);
            CheckInt(Capacity);
            CheckFloat(monSize);
            CheckString(processor);
            CheckInt(battery);
            CheckFloat(price);
            //_________________

            //_________________________________________________________Переношу изменения в главный список
            if (flag)
            {
                prd.LaptopName = name.Text;
                prd.RAM = int.Parse(RAM.Text);
                prd.Capacity = int.Parse(Capacity.Text);
                prd.MonotorSize = float.Parse(monSize.Text);
                prd.Processor = processor.Text;
                prd.BatteryCapacity = int.Parse(battery.Text);
                prd.Price = float.Parse(price.Text);
                prd.Availability = availability.Checked;

                MainForm.prodLst[MainForm.i] = prd;

                this.Close();
            }
            else
            {
                MessageBox.Show(errorMes);
            }
            //_________________________________________________________
        }

        public void ChangeMode (bool flag)
        {
            foreach (TextBox i in editBox.Controls)
            {
                i.ReadOnly = !flag;
            }
            availability.Enabled = flag;

            save.Enabled = flag;
            save.Visible = flag;

            if (flag)
                this.Text = "Редактирование данных";
            else
                this.Text = "Просмотр данных";
            if (flag)
            {
                ID.Visible = false;
                lableID.Visible = false;
            }
                
            else
            {
                ID.Visible = true;
                lableID.Visible = true;
            }
                
        }//Переключает ражим просмтора/редакирования

        public void CheckInt(TextBox tb)//Проверка на int
        {
            int tmp=0;
            if(!int.TryParse(tb.Text, out tmp))
            {
                    flag = false;
                    errorMes = "Неправильный тип данных в поле " + tb.Name + " \nВведите целое число";
            }
            if(tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + tb.Name + " не может быть отрицательным  ";
            }
        }

        public void CheckString(TextBox tb)//Проверка на string
        {
            int tmp1 =0;
            float tmp2;

            if((int.TryParse(tb.Text, out tmp1))|(float.TryParse(tb.Text, out tmp2)))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + tb.Name + " \nВведите строковое значение";
            }
        }

        public void CheckFloat(TextBox tb)//Проверка на float
        {
            float tmp = 0;
            if (!float.TryParse(tb.Text, out tmp) & (tmp > 0))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + tb.Name + " введите цисло \nПример: 2,75 (через запятую)";
            }
            if (tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + tb.Name + " не может быть отрицательным  ";
            }
        }
    }
}
