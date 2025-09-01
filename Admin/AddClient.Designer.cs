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
            InputNewName = new TextBox();
            InputNewPassword = new TextBox();
            InputNewAccountNumber = new TextBox();
            InputNewBalance = new TextBox();
            button1 = new Button();
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
            LabelNewNameUser.Location = new Point(328, 242);
            LabelNewNameUser.Name = "LabelNewNameUser";
            LabelNewNameUser.Size = new Size(88, 37);
            LabelNewNameUser.TabIndex = 1;
            LabelNewNameUser.Text = "Name";
            // 
            // LabelNewPasswordUser
            // 
            LabelNewPasswordUser.AutoSize = true;
            LabelNewPasswordUser.Font = new Font("Segoe UI", 20.25F);
            LabelNewPasswordUser.Location = new Point(328, 302);
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
            LabelNewAccountNumber.Location = new Point(328, 362);
            LabelNewAccountNumber.Name = "LabelNewAccountNumber";
            LabelNewAccountNumber.Size = new Size(210, 37);
            LabelNewAccountNumber.TabIndex = 3;
            LabelNewAccountNumber.Text = "AccountNumber";
            // 
            // LabelNewBalance
            // 
            LabelNewBalance.AutoSize = true;
            LabelNewBalance.Font = new Font("Segoe UI", 20.25F);
            LabelNewBalance.Location = new Point(328, 422);
            LabelNewBalance.Name = "LabelNewBalance";
            LabelNewBalance.Size = new Size(108, 37);
            LabelNewBalance.TabIndex = 4;
            LabelNewBalance.Text = "Balance";
            // 
            // InputNewName
            // 
            InputNewName.Font = new Font("Segoe UI", 18F);
            InputNewName.Location = new Point(557, 242);
            InputNewName.Multiline = true;
            InputNewName.Name = "InputNewName";
            InputNewName.Size = new Size(240, 37);
            InputNewName.TabIndex = 5;
            // 
            // InputNewPassword
            // 
            InputNewPassword.Font = new Font("Segoe UI", 18F);
            InputNewPassword.Location = new Point(557, 302);
            InputNewPassword.Multiline = true;
            InputNewPassword.Name = "InputNewPassword";
            InputNewPassword.Size = new Size(240, 37);
            InputNewPassword.TabIndex = 6;
            InputNewPassword.UseSystemPasswordChar = true;
            // 
            // InputNewAccountNumber
            // 
            InputNewAccountNumber.Font = new Font("Segoe UI", 18F);
            InputNewAccountNumber.Location = new Point(557, 362);
            InputNewAccountNumber.Multiline = true;
            InputNewAccountNumber.Name = "InputNewAccountNumber";
            InputNewAccountNumber.Size = new Size(240, 37);
            InputNewAccountNumber.TabIndex = 7;
            // 
            // InputNewBalance
            // 
            InputNewBalance.Font = new Font("Segoe UI", 18F);
            InputNewBalance.Location = new Point(557, 422);
            InputNewBalance.Multiline = true;
            InputNewBalance.Name = "InputNewBalance";
            InputNewBalance.Size = new Size(240, 37);
            InputNewBalance.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(557, 512);
            button1.Name = "button1";
            button1.Size = new Size(215, 69);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 677);
            Controls.Add(button1);
            Controls.Add(InputNewBalance);
            Controls.Add(InputNewAccountNumber);
            Controls.Add(InputNewPassword);
            Controls.Add(InputNewName);
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
        private TextBox InputNewName;
        private TextBox InputNewPassword;
        private TextBox InputNewAccountNumber;
        private TextBox InputNewBalance;
        private Button button1;
    }
}