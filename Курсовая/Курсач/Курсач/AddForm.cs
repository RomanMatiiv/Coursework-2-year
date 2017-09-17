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
    public partial class AddForm : Form
    {
        bool flag = true;
        Product prod = new Product();
        string errorMes = "";

        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //____________________________________________________Проверка заполнены ли все поля
            flag = true;
            foreach (TextBox i in add.Controls)
            {
                if (i.Text.Length == 0)
                    flag = false;
            }
            //___________________________________________________

            errorMes = "Заполните все поля";
            //_______________Проверка типов
            CheckString(name);
            CheckInt(RAM);
            CheckInt(Capacity);
            CheckFloat(monSize);
            CheckString(processor);
            CheckInt(battery);
            CheckFloat(price);
            //_________________

            if (flag)
            {
                prod.LaptopID = setID();
                prod.LaptopName = add.Controls[0].Text;
                prod.RAM = int.Parse(add.Controls[1].Text);
                prod.Capacity = int.Parse(add.Controls[2].Text);
                prod.MonotorSize = float.Parse(add.Controls[3].Text);
                prod.Processor = add.Controls[4].Text;
                prod.BatteryCapacity = int.Parse(add.Controls[5].Text);
                prod.Price = float.Parse(add.Controls[6].Text);
                prod.Availability = availabilityChB1.Checked;
                MainForm.prodLst.Add(prod);//Добавление 1 обекта в BindingList
                Close();
            }
            else
            {
                MessageBox.Show(errorMes);
            }
        }

        public void CheckInt(TextBox tb)//Проверка на int
        {
            int tmp = 0;
            if (!int.TryParse(tb.Text, out tmp))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + tb.Name + " \nВведите целое число";
            }

            if (tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + tb.Name + " не может быть отрицательным";
            }
        }

        public void CheckString(TextBox tb)//Проверка на string
        {
            int tmp1 = 0;
            float tmp2;

            if ((int.TryParse(tb.Text, out tmp1)) | (float.TryParse(tb.Text, out tmp2)))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + tb.Name + " \nВведите строковое значение";
            }
        }

        public void CheckFloat(TextBox tb)//Проверка на float
        {
            float tmp = 0;
            if (!float.TryParse(tb.Text, out tmp))
            {
                flag = false;
                errorMes = "Неправильный тип данных в поле " + tb.Name + " введите цисло \nПример: 2,75 (через запятую)";
            }

            if (tmp < 0)
            {
                flag = false;
                errorMes = "Поле " + tb.Name + " не может быть отрицательным";
            }
        }

        public int setID()
        {
            //____________________________________________Ищет естьли пробелы в списке ID(удаленные ID)
            List<int> lst = new List<int>();
            for (int i = 0; i < MainForm.prodLst.Count; i++)
                lst.Add(MainForm.prodLst[i].LaptopID);

            lst.Sort();
            for (int i = 0; i < lst.Count-1; i++)
            {
                if (lst[i] + 1 != lst[i + 1])
                    return lst[i] + 1;
            }
            //____________________________________________

            return lst.Max()+1;//Если пробелов нет то вернет max+1
        }//Реализует авто инкремент ID
    }
}