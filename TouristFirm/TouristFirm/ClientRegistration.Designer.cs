namespace TouristFirm
{
    partial class ClientRegistration
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_MiddleName = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_MiddleName = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(31, 96);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Имя";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(27, 134);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(56, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Фамилия";
            // 
            // label_MiddleName
            // 
            this.label_MiddleName.AutoSize = true;
            this.label_MiddleName.Location = new System.Drawing.Point(31, 170);
            this.label_MiddleName.Name = "label_MiddleName";
            this.label_MiddleName.Size = new System.Drawing.Size(54, 13);
            this.label_MiddleName.TabIndex = 2;
            this.label_MiddleName.Text = "Отчество";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(31, 213);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(44, 13);
            this.label_Address.TabIndex = 3;
            this.label_Address.Text = "Адресс";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(31, 254);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 13);
            this.labelTel.TabIndex = 4;
            this.labelTel.Text = "Телефон";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(191, 96);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 5;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(191, 134);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 6;
            // 
            // textBox_MiddleName
            // 
            this.textBox_MiddleName.Location = new System.Drawing.Point(191, 162);
            this.textBox_MiddleName.Name = "textBox_MiddleName";
            this.textBox_MiddleName.Size = new System.Drawing.Size(100, 20);
            this.textBox_MiddleName.TabIndex = 7;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(191, 205);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(100, 20);
            this.textBox_Address.TabIndex = 8;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(191, 246);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTel.TabIndex = 9;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(34, 309);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(177, 40);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(231, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(195, 40);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Регистрация клиента";
            // 
            // ClientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_MiddleName);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_MiddleName);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Name = "ClientRegistration";
            this.Text = "ClientRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_MiddleName;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_MiddleName;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label6;
    }
}