using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Курсач
{
    public partial class CheckUsers : Form
    {
        public static List<Users> users = new List<Users>();//Информация о пользователях
        string path = Directory.GetCurrentDirectory() + "\\Users\\Users.xml";
        XmlSerializer xs = new XmlSerializer(typeof(List<Users>));
        FileStream fs;

        public CheckUsers()
        {
            InitializeComponent();
           
            //_____________________________________________________________//Создаю файл пользователями если его нет
            if(!File.Exists(path))
            {
                users.Add(new Users("admin", "admin", "123"));//Пользователь по умолчанию
                fs = new FileStream(path, FileMode.Create);
                xs.Serialize(fs, users);
                fs.Close();
            }
            //__________________________________________________________
            else
            {
                fs = new FileStream(path, FileMode.Open);
                if (fs.Length != 0)
                    users = (List<Users>)xs.Deserialize(fs);
                fs.Close();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)//Вход если пара логин-пароль существует
        {
            MainForm form = new MainForm();
            //___________________________________Проверяю есть ли такой пользователь
            for (int i = 0; i <users.Count; i++)
            {
                if (login.Text == users[i].login)
                    if (password.Text.GetHashCode() + users[i].salt.GetHashCode() == users[i].password)
                    {
                        this.Enabled = false;
                        this.Visible = false;
                        form.ShowDialog();
                       
                        return;
                    }
            }
            //_________________________________________________________
            MessageBox.Show("Такого пользователя не существует");
            login.Text = "";
            password.Text = "";
        }

       private void CheckUsers_FormClosing(object sender, FormClosingEventArgs e)//Осуществляет выход
        {
            Application.Exit();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
            //Сериализует список пользователей
            fs = new FileStream(path, FileMode.Create);
            xs.Serialize(fs, users);
            fs.Close();

        } //Переходит на форму для регистрации
    }
}
