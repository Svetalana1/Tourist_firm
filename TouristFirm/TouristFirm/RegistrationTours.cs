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
    public partial class RegistrationTours : Form
    {
        bool edit;
        int id;
        public RegistrationTours()
        {
            InitializeComponent();
            edit = false;
        }

        public RegistrationTours(String Title, String Type, String City,
            String Transport, int Price, String Hotel, int Count, int id)
            : this()
        {
            this.id = id;
            edit = true;
            this.textBoxTitle.Text = Title;
            switch (Type)
            {
                case "пляжный": this.comboBoxType.SelectedIndex=0; break;
                case "свадебный": this.comboBoxType.SelectedIndex=1; break;
                case "туры с детьми": this.comboBoxType.SelectedIndex=2; break;
                case "экскурсионный": this.comboBoxType.SelectedIndex = 3; break;
                default: this.comboBoxType.Text = "не определенно"; break;
            }
            switch (City)
            {
                case "Стамбул": this.comboBoxCity.SelectedIndex = 0; break;
                     case "Кипр": this.comboBoxCity.SelectedIndex = 1; break;
                     case "Коморские острова": this.comboBoxCity.SelectedIndex = 2; break;
                     case "Танзания": this.comboBoxCity.SelectedIndex = 3; break;
                     case "Тимор-Лешти": this.comboBoxCity.SelectedIndex = 4; break;
                     case "Того": this.comboBoxCity.SelectedIndex = 5; break;
                     case "Тонга": this.comboBoxCity.SelectedIndex = 6; break;
                     case "Тринидад и Тобаго": this.comboBoxCity.SelectedIndex = 7; break;
                     case "Тувалу": this.comboBoxCity.SelectedIndex = 8; break;
                     case "Микронезия": this.comboBoxCity.SelectedIndex = 9; break;
                     case "Мозамбик": this.comboBoxCity.SelectedIndex = 10; break;
                     case "Непал": this.comboBoxCity.SelectedIndex = 11; break;
                     case "Нигер": this.comboBoxCity.SelectedIndex = 12; break;
                     case "Нигерия": this.comboBoxCity.SelectedIndex = 13; break;
                     case "Нидерланды": this.comboBoxCity.SelectedIndex = 14; break;
                default: this.comboBoxCity.Text="не определенно"; break;
            }      

            switch(Transport)
            {
                case "самолёт": this.comboBoxTransport.SelectedIndex=0; break;
                    case "поезд": this.comboBoxTransport.SelectedIndex=1; break;
                    case "автобус": this.comboBoxTransport.SelectedIndex=2; break;
                    case "корабль": this.comboBoxTransport.SelectedIndex = 3; break;
                default:
                    this.comboBoxTransport.Text="не определенно"; break;
            }

            switch (Price)
            {
                case 1000: this.comboBoxPrice.SelectedIndex=0; break;
                    case 1200: this.comboBoxPrice.SelectedIndex=1; break;
                    case 1500: this.comboBoxPrice.SelectedIndex=2; break;
                    case 2000: this.comboBoxPrice.SelectedIndex=3; break;
                    case 2500: this.comboBoxPrice.SelectedIndex=4; break;
                    case 3000: this.comboBoxPrice.SelectedIndex=5; break;
                    case 4000: this.comboBoxPrice.SelectedIndex=6; break;
                    case 5000: this.comboBoxPrice.SelectedIndex=7; break;
                    case 10000: this.comboBoxPrice.SelectedIndex=8; break;
                    default: this.comboBoxPrice.Text = "не определенно"; break;
            }

            switch (Hotel)
            {
                case "Круиз":this.comboBoxHotel.SelectedIndex=0; break;
                     case "Морской Волк":this.comboBoxHotel.SelectedIndex=1; break;
                     case "Таверна":this.comboBoxHotel.SelectedIndex=2; break;
                     case "Уют": this.comboBoxHotel.SelectedIndex = 3; break;
                default:
                    this.comboBoxPrice.Text= "не определенно"; break;
            }
            switch (Count)
            {
                case 1:this.comboBoxCount.SelectedIndex=0; break;
                    case 2:this.comboBoxCount.SelectedIndex=1; break;
                    case 3:this.comboBoxCount.SelectedIndex=2; break;
                    case 4:this.comboBoxCount.SelectedIndex=3; break;
                    case 5:this.comboBoxCount.SelectedIndex=4; break;
                    case 6:this.comboBoxCount.SelectedIndex=5; break;
                     case 7:this.comboBoxCount.SelectedIndex=6; break;
                    case 8:this.comboBoxCount.SelectedIndex=7; break;
                    case 9:this.comboBoxCount.SelectedIndex=8; break;
                    case 10:this.comboBoxCount.SelectedIndex=9; break;

                default: this.comboBoxCount.Text="не определенно"; break;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string Type="";
            string City="";
            string Transport="";
            string Hotel = "";
            int Price = 0;
            int Count = 0;
            switch (comboBoxType.SelectedIndex)
            {
                case 0: Type="пляжный"; break;
                    case 1: Type="свадебный"; break;
                    case 2: Type="туры с детьми"; break;
                    case 3: Type = "экскурсионный"; break;
                    default: break;
            }
            switch (comboBoxCity.SelectedIndex)
            {
                case 0: City="Стамбул"; break;
                    case 1: City="Кипр"; break;
                    case 2: City="Коморские острова"; break;
                    case 3: City="Танзания"; break;
                    case 4: City="Тимор-Лешти"; break;
                    case 5: City="Того"; break;
                    case 6: City="Тонга"; break;
                     case 7: City="Тринидад и Тобаго"; break;
                    case 8: City="Тувалу"; break;
                    case 9: City="Микронезия"; break;
                    case 10: City="Мозамбик"; break;
                    case 11: City="Непал"; break;
                    case 12: City="Нигер"; break;
                    case 13: City="Нигерия"; break;
                     case 14: City="Нидерланды"; break;                
                default: break;
            }
            switch (comboBoxTransport.SelectedIndex)
            {
                case 0: Transport = "самолёт"; break;
                    case 1: Transport = "поезд"; break;
                    case 2: Transport = "автобус"; break;
                    case 3: Transport = "корабль"; break;
                    default: break;
            }
            switch (comboBoxPrice.SelectedIndex)
            {
                case 0: Price=1000; break;
                    case 1: Price=1200; break;
                    case 2: Price=1500; break;
                    case 3: Price=2000; break;
                    case 4: Price=2500; break;
                     case 5: Price=3000; break;
                    case 6: Price=4000; break;
                    case 7: Price=5000; break;
                    case 8: Price=10000; break;
                    default: break;
            }

            switch (comboBoxHotel.SelectedIndex)
            {
                    case 0: Hotel="Круиз"; break;
                    case 1: Hotel="Морской Волк"; break;
                    case 2: Hotel="Таверна"; break;
                    case 3: Hotel = "Уют"; break;
                    default: break;
            }
            switch (comboBoxCount.SelectedIndex)
            {
                case 0: Count = 1; break;
                     case 1: Count = 2; break;
                     case 2: Count = 3; break;
                     case 3: Count = 4; break;
                     case 4: Count = 5; break;
                    case 5: Count = 6; break;
                     case 6: Count = 7; break;
                     case 7: Count = 8; break;
                     case 8: Count = 9; break;
                     case 9: Count = 10; break;
            }
            if (edit)
            {
                toursTableAdapter1.UpdateQuery(textBoxTitle.Text.ToString(),
                    Type, City, Transport, Convert.ToDecimal(Price), Hotel, Count, id);
            }
            else
            {
                toursTableAdapter1.InsertQuery(textBoxTitle.Text.ToString(), Type, City, Transport,
                    Convert.ToDecimal(Price), Hotel, Count);
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
