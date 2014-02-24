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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Tourist_firm' table. You can move, or remove it, as needed.
            this.tourist_firmTableAdapter.Fill(this.tourist_firmDataSet.Tourist_firm);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.tourist_firmDataSet.Employee);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Wishes' table. You can move, or remove it, as needed.
            this.wishesTableAdapter.Fill(this.tourist_firmDataSet.Wishes);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.tourist_firmDataSet.Orders);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Tours' table. You can move, or remove it, as needed.
            this.toursTableAdapter.Fill(this.tourist_firmDataSet.Tours);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.tourist_firmDataSet.Clients);
            dataGridView1.AutoGenerateColumns = true;

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = clientsBindingSource;
            dataGridView1.DataSource = clientsBindingSource;
            label1.Text = "База данных \"Клиенты\"";

        }

        private void путёвкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = toursBindingSource;
            dataGridView1.DataSource = toursBindingSource;
            label1.Text = "База данных \"Путёвки\"";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientsTableAdapter.Update(tourist_firmDataSet);
            toursTableAdapter.Update(tourist_firmDataSet);
            ordersTableAdapter.Update(tourist_firmDataSet);
            wishesTableAdapter.Update(tourist_firmDataSet);
            employeeTableAdapter.Update(tourist_firmDataSet);
            tourist_firmTableAdapter.Update(tourist_firmDataSet);
            

        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = ordersBindingSource;
            dataGridView1.DataSource = ordersBindingSource;
            label1.Text = "База данных \"Заказы\"";
        }

        private void wishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = wishesBindingSource;
            dataGridView1.DataSource = wishesBindingSource;
            label1.Text = "База данных \"Пожелания\"";

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = employeeBindingSource;
            dataGridView1.DataSource = employeeBindingSource;
            label1.Text = "База данных \"Сотрудники\"";
        }

        private void touristfirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = touristfirmBindingSource;
            dataGridView1.DataSource = touristfirmBindingSource;
            label1.Text = "База данных \"Туристическая фирма\"";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

      
    }
}
