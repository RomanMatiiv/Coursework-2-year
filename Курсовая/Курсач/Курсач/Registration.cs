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
    public partial class Registration : Form
    {
        bool flag = true;
        Random rnd = new Random();

        public Registration()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            //_______________________________________Проверки
            if (password.Text != passwordAgain.Text)
                Error("Пароли не совпадают");
            
            CheckString(login);
            CheckString(password);

            for (int i = 0; i < CheckUsers.users.Count; i++)
            {
                if (login.Text == CheckUsers.users[i].login)
                    Error("Пользователь с таким логином уже есть");
            }
            //______________________________________________

            if(flag)//Если ошибок нет то регистрирует
            {
                CheckUsers.users.Add(new Users(login.Text, password.Text, GenerateSalt()));//Добавление
                MessageBox.Show("Пользователь  " + login.Text + "  успешно зарегистрирован");
                Close();
            }

            login.Text = "";
            password.Text = "";
            passwordAgain.Text = "";
        }
        public void CheckString(TextBox tb)//Проверка на полей
        {
            if (tb.Text.Trim().Length == 0)
            {
                Error("Все поля должны быть заполенны");
                return;
            }
               
            int tmp1 = 0;
            float tmp2;

            if ((int.TryParse(tb.Text, out tmp1)) | (float.TryParse(tb.Text, out tmp2)))
            {
                Error("В логине и пароле должны присутстоввать буквы");
            }
        }

        public string GenerateSalt()
        {
            string salt="";
            string chars = "123456789!@#$%^&*()_?";
            for (int i = 0; i < 3; i++)
            {
                salt+= chars.Substring(rnd.Next(0, chars.Length), 1);
            }
            return salt;
        } // Возвращает соль

        public void Error(string str)
        {
            if(flag)
            {
                flag = false;
                MessageBox.Show(str);
            }
            
        } // Если есть ошибка выводит сообщение и ставит флаг
    }
}
