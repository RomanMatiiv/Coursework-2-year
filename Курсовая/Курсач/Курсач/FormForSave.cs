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
    public partial class FormForSave : Form
    {
        public FormForSave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pathDirecroryBox.Text.Trim(' ').Length!=0)
            {
                MainForm.pathDirectory= pathDirecroryBox.Text.Trim(' ');
                Close();
            }
            else
            {
                MessageBox.Show("Введите название папки");
            }
            
        }
    }
}
