namespace TouristFirm
{
    partial class MainForm
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
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Location = new System.Drawing.Point(314, 119);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(197, 71);
            this.buttonEmployee.TabIndex = 0;
            this.buttonEmployee.Text = "Сотрудник";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(314, 212);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(197, 74);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 497);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonEmployee);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonClient;

    }
}

