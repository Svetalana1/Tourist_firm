namespace TouristFirm
{
    partial class RegistrationTours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelRegEmploee = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelHotel = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTransport = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxTransport = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.toursTableAdapter1 = new TouristFirm.Tourist_firmDataSetTableAdapters.ToursTableAdapter();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(238, 81);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 36;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(291, 304);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 35);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(107, 305);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(135, 34);
            this.buttonOK.TabIndex = 34;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelRegEmploee
            // 
            this.labelRegEmploee.AutoSize = true;
            this.labelRegEmploee.Location = new System.Drawing.Point(205, 31);
            this.labelRegEmploee.Name = "labelRegEmploee";
            this.labelRegEmploee.Size = new System.Drawing.Size(115, 13);
            this.labelRegEmploee.TabIndex = 33;
            this.labelRegEmploee.Text = "Регистрация путёвки";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(48, 265);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 32;
            this.labelCount.Text = "Количество";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(48, 231);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(38, 13);
            this.labelHotel.TabIndex = 31;
            this.labelHotel.Text = "Отель";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(48, 207);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "Цена";
            // 
            // labelTransport
            // 
            this.labelTransport.AutoSize = true;
            this.labelTransport.Location = new System.Drawing.Point(48, 179);
            this.labelTransport.Name = "labelTransport";
            this.labelTransport.Size = new System.Drawing.Size(61, 13);
            this.labelTransport.TabIndex = 29;
            this.labelTransport.Text = "Транспорт";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(48, 148);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 13);
            this.labelCity.TabIndex = 28;
            this.labelCity.Text = "Город";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(48, 116);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 27;
            this.labelType.Text = "Тип";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(48, 84);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 13);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Название";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "пляжный",
            "свадебный",
            "туры с детьми",
            "экскурсионный"});
            this.comboBoxType.Location = new System.Drawing.Point(238, 116);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 37;
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Items.AddRange(new object[] {
            "самолёт",
            "поезд",
            "автобус",
            "корабль"});
            this.comboBoxTransport.Location = new System.Drawing.Point(238, 179);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransport.TabIndex = 38;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Стамбул",
            "Кипр",
            "Коморские острова",
            "Танзания",
            "Тимор-Лешти",
            "Того",
            "Тонга",
            "Тринидад и Тобаго",
            "Тувалу",
            "Микронезия",
            "Мозамбик",
            "Непал",
            "Нигер",
            "Нигерия",
            "Нидерланды",
            "",
            ""});
            this.comboBoxCity.Location = new System.Drawing.Point(238, 145);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 39;
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Items.AddRange(new object[] {
            "Круиз",
            "Морской Волк",
            "Таверна",
            "Уют"});
            this.comboBoxHotel.Location = new System.Drawing.Point(238, 231);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHotel.TabIndex = 40;
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCount.Location = new System.Drawing.Point(238, 262);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCount.TabIndex = 41;
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Items.AddRange(new object[] {
            "1000",
            "1200",
            "1500",
            "2000",
            "2500",
            "3000",
            "4000",
            "5000",
            "10000"});
            this.comboBoxPrice.Location = new System.Drawing.Point(238, 207);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrice.TabIndex = 42;
            // 
            // toursTableAdapter1
            // 
            this.toursTableAdapter1.ClearBeforeFill = true;
            // 
            // RegistrationTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 395);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxTransport);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelRegEmploee);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTransport);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitle);
            this.Name = "RegistrationTours";
            this.Text = "RegistrationTours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelRegEmploee;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTransport;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxTransport;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private Tourist_firmDataSetTableAdapters.ToursTableAdapter toursTableAdapter1;
    }
}