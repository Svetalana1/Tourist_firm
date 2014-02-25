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
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Wishes' table. You can move, or remove it, as needed.
            this.wishesTableAdapter.Fill(this.tourist_firmDataSet.Wishes);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Tours' table. You can move, or remove it, as needed.
            this.toursTableAdapter.Fill(this.tourist_firmDataSet.Tours);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Tourist_firm' table. You can move, or remove it, as needed.
            this.tourist_firmTableAdapter.Fill(this.tourist_firmDataSet.Tourist_firm);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.tourist_firmDataSet.Orders);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.tourist_firmDataSet.Employee);
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.tourist_firmDataSet.Clients);

            dataGridView1.AutoGenerateColumns = true;
          

        }

        private void EmployeeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientsTableAdapter.Update(tourist_firmDataSet);
            toursTableAdapter.Update(tourist_firmDataSet);
            employeeTableAdapter.Update(tourist_firmDataSet);
            tourist_firmTableAdapter.Update(tourist_firmDataSet);
            ordersTableAdapter.Update(tourist_firmDataSet);
            wishesTableAdapter.Update(tourist_firmDataSet);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = clientsBindingSource;
            dataGridView1.DataSource = clientsBindingSource;
            labelNameDatabase.Text="База данных \"Клиенты\"";
        }

        private void путёвкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = toursBindingSource;
            dataGridView1.DataSource = toursBindingSource;
            labelNameDatabase.Text = "База данных \"Путёвки\"";
        }

        private void заказыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = ordersBindingSource;
            dataGridView1.DataSource = ordersBindingSource;
            labelNameDatabase.Text = "База данных \"Заказы\"";
        }

        private void пожеланияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = wishesBindingSource;
            dataGridView1.DataSource = wishesBindingSource;
            labelNameDatabase.Text = "База данных \"Пожелания\"";
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = employeeBindingSource;
            dataGridView1.DataSource = employeeBindingSource;
            labelNameDatabase.Text = "База данных \"Сотрудники\"";
        }

        private void турФирмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = touristfirmBindingSource;
            dataGridView1.DataSource = touristfirmBindingSource;
            labelNameDatabase.Text = "База данных \"Туристическая фирма\"";
        }

        private void сотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationEmploee regEmp = new RegistrationEmploee();
            regEmp.ShowDialog();
            employeeTableAdapter.Fill(tourist_firmDataSet.Employee);
            tourist_firmDataSet.AcceptChanges();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Tourist_firmDataSet.EmployeeDataTable empTab = new Tourist_firmDataSet.EmployeeDataTable();
            employeeTableAdapter.FillBy(empTab,Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row=empTab.Rows[0].ItemArray;
            RegistrationEmploee regEmp = new RegistrationEmploee(row[1].ToString(), 
                row[2].ToString(), row[3].ToString(),
                Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), 
                Convert.ToInt32(row[6]),row[7].ToString(), Convert.ToInt32(row[0]));
            regEmp.ShowDialog();
            employeeTableAdapter.Fill(tourist_firmDataSet.Employee);
            tourist_firmDataSet.AcceptChanges();
                
             
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].
                Cells[0].Value));
            employeeTableAdapter.Fill(tourist_firmDataSet.Employee);
            tourist_firmDataSet.AcceptChanges();
        }

        private void путёвкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrationTours regTour = new RegistrationTours();
            regTour.ShowDialog();
        }

    }
}
