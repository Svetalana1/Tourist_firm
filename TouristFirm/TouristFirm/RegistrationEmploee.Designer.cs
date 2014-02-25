namespace TouristFirm
{
    partial class RegistrationEmploee
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRegEmploee = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
            this.touristfirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourist_firmDataSet = new TouristFirm.Tourist_firmDataSet();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.tourist_firmTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.Tourist_firmTableAdapter();
            this.employeeTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.EmployeeTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.touristfirmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourist_firmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(130, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Фамилия с инициалами";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(47, 115);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Пол";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(47, 147);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(65, 13);
            this.labelPost.TabIndex = 2;
            this.labelPost.Text = "Должность";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(47, 178);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(55, 13);
            this.labelSalary.TabIndex = 3;
            this.labelSalary.Text = "Зарплата";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(47, 206);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 13);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "Телефон";
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Location = new System.Drawing.Point(47, 231);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(58, 13);
            this.labelDeparture.TabIndex = 5;
            this.labelDeparture.Text = "№ Отдела";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(47, 264);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // labelRegEmploee
            // 
            this.labelRegEmploee.AutoSize = true;
            this.labelRegEmploee.Location = new System.Drawing.Point(204, 30);
            this.labelRegEmploee.Name = "labelRegEmploee";
            this.labelRegEmploee.Size = new System.Drawing.Size(133, 13);
            this.labelRegEmploee.TabIndex = 7;
            this.labelRegEmploee.Text = "Регистрация сотрудника";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(106, 304);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(135, 34);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(290, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 35);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(237, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(238, 257);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(238, 115);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 14;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "Агент по бронированию",
            "Агент по въездному и внутреннему туризму",
            "Агент по продажам",
            "Администратор",
            "Ассистент по формированию тургрупп",
            "Бухгалтер",
            "Генеральный директор турагентства",
            "Гид",
            "Заместитель генерального директора директор филиала",
            "Руководитель тургруппы",
            "Секретарь – референт",
            "Уборщица",
            "Юрист"});
            this.comboBoxPost.Location = new System.Drawing.Point(237, 147);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPost.TabIndex = 15;
            // 
            // comboBoxDeparture
            // 
            this.comboBoxDeparture.DataSource = this.touristfirmBindingSource;
            this.comboBoxDeparture.DisplayMember = "DTitle";
            this.comboBoxDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeparture.FormattingEnabled = true;
            this.comboBoxDeparture.Location = new System.Drawing.Point(238, 230);
            this.comboBoxDeparture.Name = "comboBoxDeparture";
            this.comboBoxDeparture.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeparture.TabIndex = 16;
            this.comboBoxDeparture.ValueMember = "Numdepartment";
            // 
            // touristfirmBindingSource
            // 
            this.touristfirmBindingSource.DataMember = "Tourist_firm";
            this.touristfirmBindingSource.DataSource = this.tourist_firmDataSet;
            // 
            // tourist_firmDataSet
            // 
            this.tourist_firmDataSet.DataSetName = "Tourist_firmDataSet";
            this.tourist_firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Items.AddRange(new object[] {
            "1000",
            "1500",
            "1700",
            "2000",
            "2600",
            "2700",
            "2900",
            "3000",
            "3400",
            "4000",
            "4200",
            "4800",
            "5000",
            "5500",
            "6000",
            "6600",
            "7000",
            "7500",
            "8000",
            "8500",
            "9000",
            "9600",
            "10000",
            "15000",
            "20000"});
            this.comboBoxSalary.Location = new System.Drawing.Point(237, 174);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalary.TabIndex = 17;
            // 
            // tourist_firmTableAdapter
            // 
            this.tourist_firmTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(237, 201);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // RegistrationEmploee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 396);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBoxSalary);
            this.Controls.Add(this.comboBoxDeparture);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelRegEmploee);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDeparture);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.Name = "RegistrationEmploee";
            this.Text = "Регистрация сотрудника";
            this.Load += new System.EventHandler(this.RegistrationEmploee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.touristfirmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourist_firmDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRegEmploee;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.ComboBox comboBoxDeparture;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private Tourist_firmDataSet tourist_firmDataSet;
        private System.Windows.Forms.BindingSource touristfirmBindingSource;
        private Tourist_firmDataSetTableAdapters.Tourist_firmTableAdapter tourist_firmTableAdapter;
        private Tourist_firmDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}