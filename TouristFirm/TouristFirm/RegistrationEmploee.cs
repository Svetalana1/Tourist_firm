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
    public partial class RegistrationEmploee : Form
    {
        bool edit;
        int id;

        public RegistrationEmploee()
        {
            InitializeComponent();
            tourist_firmTableAdapter.Fill(tourist_firmDataSet.Tourist_firm);
            edit = false;
            
        }

        public RegistrationEmploee(String Name,String Gender, String Post, int Salary,
            int Tel,int Department, String Password, int id):this()
        {
           
            tourist_firmTableAdapter.Fill(tourist_firmDataSet.Tourist_firm);
            edit = true;
            this.id = id;

            this.textBoxName.Text = Name;
            if (Gender.ToUpper() == "М")
            {
                this.comboBoxGender.SelectedIndex = 0;
            }
            else
            {
                if (Gender.ToUpper() == "Ж")
                {
                    this.comboBoxGender.SelectedIndex = 1;
                }
                else
                    this.comboBoxGender.Text = "";
            }
            switch (Post)
            {
                case "Агент по бронированию": this.comboBoxPost.SelectedIndex=0; break;
                case "Агент по въездному и внутреннему туризму": this.comboBoxPost.SelectedIndex=1; break;
                case "Агент по продажам": this.comboBoxPost.SelectedIndex=2; break;
                case "Администратор": this.comboBoxPost.SelectedIndex=3; break;
                case "Ассистент по формированию тургрупп": this.comboBoxPost.SelectedIndex=4; break;
                case "Бухгалтер":this.comboBoxPost.SelectedIndex=5;break;
                case "Генеральный директор турагентства":this.comboBoxPost.SelectedIndex=6;break;
                case "Гид":this.comboBoxPost.SelectedIndex=7;break;
                case "Заместитель генерального директора директор филиала":this.comboBoxPost.SelectedIndex=8;break;
                case "Руководитель тургруппы":this.comboBoxPost.SelectedIndex=9;break;
                case "Секретарь – референт":this.comboBoxPost.SelectedIndex=10;break;
                case "Уборщица":this.comboBoxPost.SelectedIndex=11;break;
                case "Юрист": this.comboBoxPost.SelectedIndex = 12; break;
                default:
                    this.comboBoxPost.Text = "не определенно";
                    break;
            }

            switch(Salary){
                    case 1000:this.comboBoxSalary.SelectedIndex=0; break;
                    case 1500:this.comboBoxSalary.SelectedIndex=1; break;
                    case 1700:this.comboBoxSalary.SelectedIndex=2; break;
                    case 2000:this.comboBoxSalary.SelectedIndex=3; break;
                    case 2600:this.comboBoxSalary.SelectedIndex=4; break;
                    case 2700:this.comboBoxSalary.SelectedIndex=5; break;
                    case 2900:this.comboBoxSalary.SelectedIndex=6; break;
                    case 3000:this.comboBoxSalary.SelectedIndex=7; break;
                    case 3400:this.comboBoxSalary.SelectedIndex=8; break;
                    case 4000:this.comboBoxSalary.SelectedIndex=9; break;
                    case 4200:this.comboBoxSalary.SelectedIndex=10; break;
                    case 4800:this.comboBoxSalary.SelectedIndex=11; break;
                    case 5000:this.comboBoxSalary.SelectedIndex=12; break;
                    case 5500:this.comboBoxSalary.SelectedIndex=13; break;
                    case 6000:this.comboBoxSalary.SelectedIndex=14; break;
                    case 6600:this.comboBoxSalary.SelectedIndex=15; break;
                    case 7000:this.comboBoxSalary.SelectedIndex=16; break;
                    case 7500:this.comboBoxSalary.SelectedIndex=17; break;
                    case 8000:this.comboBoxSalary.SelectedIndex=18; break;
                    case 8500:this.comboBoxSalary.SelectedIndex=19; break;
                    case 9000:this.comboBoxSalary.SelectedIndex=20; break;
                    case 9600:this.comboBoxSalary.SelectedIndex=21; break;
                    case 10000:this.comboBoxSalary.SelectedIndex=22; break;
                    case 15000:this.comboBoxSalary.SelectedIndex=23; break;
                    case 20000: this.comboBoxSalary.SelectedIndex = 24; break;
                    default:
                        this.comboBoxSalary.Text = "не определенно";
                        break;
              
            }
            this.maskedTextBox1.Text = Convert.ToString(Tel);
            this.comboBoxDeparture.SelectedValue = Department;
            this.textBoxPassword.Text = Password;
            

        }

        private void RegistrationEmploee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourist_firmDataSet.Tourist_firm' table. You can move, or remove it, as needed.
         //   maskedTextBox1.Mask = "000 000 0000";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string Gender = "";
            string Post="";
            int Salary = 0;
            
            if (comboBoxGender.SelectedIndex == 0)
            {
                Gender = "М";
            }
            else
            {
                if (comboBoxGender.SelectedIndex == 1)
                {
                    Gender = "Ж";
                }
            }
            switch (comboBoxPost.SelectedIndex)
            {
                case 0: Post = "Агент по бронированию"; break;
                case 1: Post = "Агент по въездному и внутреннему туризму"; break;
                case 2: Post = "Агент по продажам"; break;
                case 3: Post = "Администратор"; break;
                case 4: Post = "Ассистент по формированию тургрупп"; break;
                case 5: Post = "Бухгалтер"; break;
                case 6: Post = "Генеральный директор турагентства"; break;
                case 7: Post = "Гид"; break;
                case 8: Post = "Заместитель генерального директора директор филиала"; break;
                case 9: Post = "Руководитель тургруппы"; break;
                    case 10: Post = "Секретарь – референт"; break;
                    case 11: Post = "Уборщица"; break;
                    case 12: Post = "Юрист"; break;
                default:
                      
                        break;
            }

            switch (comboBoxSalary.SelectedIndex)
            {
                case 0: Salary=1000; break;
                     case 1: Salary=1500; break;
                     case 2: Salary=1700; break;
                     case 3: Salary=2000; break;
                     case 4: Salary=2600; break;
                     case 5: Salary=2700; break;
                      case 6: Salary=2900; break;
                     case 7: Salary=3000; break;
                     case 8: Salary=3400; break;
                     case 9: Salary=4000; break;
                     case 10: Salary=4200; break;
                     case 11: Salary=4800; break;
                    case 12: Salary=5000; break;
                     case 13: Salary=5500; break;
                     case 14: Salary=6000; break;
                     case 15: Salary=6600; break;
                     case 16: Salary=7000; break;
                     case 17: Salary=7500; break;
                      case 18: Salary=8000; break;
                     case 19: Salary=8500; break;
                     case 20: Salary=9000; break;
                     case 21: Salary=9600; break;
                     case 22: Salary=10000; break;
                     case 23: Salary=15000; break;
                    case 24: Salary=20000; break; 
                       
                default:
                    break;
            }
            
            if(edit)
            {
                
                  employeeTableAdapter.UpdateQuery(textBoxName.Text, Gender, Post, Convert.ToDecimal(Salary),
                    Convert.ToInt32(maskedTextBox1.Text), Convert.ToInt32(comboBoxDeparture.SelectedValue),
                    textBoxPassword.Text, id);

            }
            else
            {
                employeeTableAdapter.InsertQuery(textBoxName.Text,Gender,Post,Convert.ToDecimal(Salary),Convert.ToInt32(maskedTextBox1.Text),
                    Convert.ToInt32(comboBoxDeparture.SelectedValue),textBoxPassword.Text);
               
            }
            this.Close();
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Error;
            toolTip1.ToolTipTitle = "Ошибка";
            /*  toolTip1.IsBalloon = true;
              toolTip1.SetToolTip(maskedTextBox1, "Нужно вводить только цифры");
              toolTip1.ToolTipTitle = "Invalid Input";*/
            toolTip1.Show("Извините, но нужно вводить только цифры (0-9)", maskedTextBox1, 0,30, 3000);

        }
    }
}
