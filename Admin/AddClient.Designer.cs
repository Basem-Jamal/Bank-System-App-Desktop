namespace Bank_System_App
{
    partial class AddClient
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
            label1 = new Label();
            LabelNewNameUser = new Label();
            LabelNewPasswordUser = new Label();
            LabelNewAccountNumber = new Label();
            LabelNewBalance = new Label();
            InputUserName = new TextBox();
            InputNewPassword = new TextBox();
            InputNewAccountNumber = new TextBox();
            InputNewBalance = new TextBox();
            button1 = new Button();
            labelUserName = new Label();
            InputNameUser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 50);
            label1.Name = "label1";
            label1.Size = new Size(278, 50);
            label1.TabIndex = 0;
            label1.Text = "Add New Client";
            // 
            // LabelNewNameUser
            // 
            LabelNewNameUser.AutoSize = true;
            LabelNewNameUser.Font = new Font("Segoe UI", 20.25F);
            LabelNewNameUser.Location = new Point(314, 217);
            LabelNewNameUser.Name = "LabelNewNameUser";
            LabelNewNameUser.Size = new Size(88, 37);
            LabelNewNameUser.TabIndex = 1;
            LabelNewNameUser.Text = "Name";
            // 
            // LabelNewPasswordUser
            // 
            LabelNewPasswordUser.AutoSize = true;
            LabelNewPasswordUser.Font = new Font("Segoe UI", 20.25F);
            LabelNewPasswordUser.Location = new Point(314, 341);
            LabelNewPasswordUser.Name = "LabelNewPasswordUser";
            LabelNewPasswordUser.Size = new Size(128, 37);
            LabelNewPasswordUser.TabIndex = 2;
            LabelNewPasswordUser.Tag = "";
            LabelNewPasswordUser.Text = "Password";
            // 
            // LabelNewAccountNumber
            // 
            LabelNewAccountNumber.AutoSize = true;
            LabelNewAccountNumber.Font = new Font("Segoe UI", 20.25F);
            LabelNewAccountNumber.Location = new Point(314, 401);
            LabelNewAccountNumber.Name = "LabelNewAccountNumber";
            LabelNewAccountNumber.Size = new Size(210, 37);
            LabelNewAccountNumber.TabIndex = 3;
            LabelNewAccountNumber.Text = "AccountNumber";
            LabelNewAccountNumber.Visible = false;
            // 
            // LabelNewBalance
            // 
            LabelNewBalance.AutoSize = true;
            LabelNewBalance.Font = new Font("Segoe UI", 20.25F);
            LabelNewBalance.Location = new Point(314, 461);
            LabelNewBalance.Name = "LabelNewBalance";
            LabelNewBalance.Size = new Size(108, 37);
            LabelNewBalance.TabIndex = 4;
            LabelNewBalance.Text = "Balance";
            LabelNewBalance.Visible = false;
            // 
            // InputUserName
            // 
            InputUserName.Font = new Font("Segoe UI", 18F);
            InputUserName.Location = new Point(543, 281);
            InputUserName.Multiline = true;
            InputUserName.Name = "InputUserName";
            InputUserName.Size = new Size(240, 37);
            InputUserName.TabIndex = 5;
            // 
            // InputNewPassword
            // 
            InputNewPassword.Font = new Font("Segoe UI", 18F);
            InputNewPassword.Location = new Point(543, 341);
            InputNewPassword.Multiline = true;
            InputNewPassword.Name = "InputNewPassword";
            InputNewPassword.Size = new Size(240, 37);
            InputNewPassword.TabIndex = 6;
            // 
            // InputNewAccountNumber
            // 
            InputNewAccountNumber.Font = new Font("Segoe UI", 18F);
            InputNewAccountNumber.Location = new Point(543, 401);
            InputNewAccountNumber.Multiline = true;
            InputNewAccountNumber.Name = "InputNewAccountNumber";
            InputNewAccountNumber.ReadOnly = true;
            InputNewAccountNumber.Size = new Size(240, 37);
            InputNewAccountNumber.TabIndex = 7;
            InputNewAccountNumber.Visible = false;
            // 
            // InputNewBalance
            // 
            InputNewBalance.Font = new Font("Segoe UI", 18F);
            InputNewBalance.Location = new Point(543, 461);
            InputNewBalance.Multiline = true;
            InputNewBalance.Name = "InputNewBalance";
            InputNewBalance.Size = new Size(240, 37);
            InputNewBalance.TabIndex = 8;
            InputNewBalance.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(543, 518);
            button1.Name = "button1";
            button1.Size = new Size(215, 69);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 20.25F);
            labelUserName.Location = new Point(314, 280);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(141, 37);
            labelUserName.TabIndex = 10;
            labelUserName.Text = "UserName";
            // 
            // InputNameUser
            // 
            InputNameUser.Font = new Font("Segoe UI", 18F);
            InputNameUser.Location = new Point(543, 218);
            InputNameUser.Multiline = true;
            InputNameUser.Name = "InputNameUser";
            InputNameUser.Size = new Size(240, 37);
            InputNameUser.TabIndex = 11;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 677);
            Controls.Add(InputNameUser);
            Controls.Add(labelUserName);
            Controls.Add(button1);
            Controls.Add(InputNewBalance);
            Controls.Add(InputNewAccountNumber);
            Controls.Add(InputNewPassword);
            Controls.Add(InputUserName);
            Controls.Add(LabelNewBalance);
            Controls.Add(LabelNewAccountNumber);
            Controls.Add(LabelNewPasswordUser);
            Controls.Add(LabelNewNameUser);
            Controls.Add(label1);
            Name = "AddClient";
            Text = "AddClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LabelNewNameUser;
        private Label LabelNewPasswordUser;
        private Label LabelNewAccountNumber;
        private Label LabelNewBalance;
        private TextBox InputUserName;
        private TextBox InputNewPassword;
        private TextBox InputNewAccountNumber;
        private TextBox InputNewBalance;
        private Button button1;
        private Label labelUserName;
        private TextBox InputNameUser;
    }
}