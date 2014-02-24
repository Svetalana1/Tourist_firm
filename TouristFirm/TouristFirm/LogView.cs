using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristFirm
{
    public partial class LogView : Form
    {
        public LogView()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            String login=Convert.ToString(textBoxLogin.Text);
            String password = Convert.ToString(textBoxPassword.Text);
            if ( login== "111"&&password=="111")
            {
                EmployeeView emplView = new EmployeeView();
                emplView.ShowDialog();
            }
            else
            {
                labelError.Text = "Вы ввели неправильно логин или пароль";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
