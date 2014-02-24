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
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();

        }

        private void ClientView_Load(object sender, EventArgs e)
        {


        }

        private void buttonRedGreenTours_Click(object sender, EventArgs e)
        {
            ClientView clientView = new ClientView();
            clientView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
