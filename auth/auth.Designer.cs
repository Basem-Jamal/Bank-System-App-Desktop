namespace Bank_System_App
{
    partial class auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            label1 = new Label();
            btnLogin = new Button();
            InputPassword = new TextBox();
            InputUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 50);
            label1.Name = "label1";
            label1.Size = new Size(259, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(420, 422);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(173, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // InputPassword
            // 
            InputPassword.Font = new Font("Segoe UI", 15.75F);
            InputPassword.Location = new Point(403, 334);
            InputPassword.Multiline = true;
            InputPassword.Name = "InputPassword";
            InputPassword.Size = new Size(234, 50);
            InputPassword.TabIndex = 2;
            // 
            // InputUsername
            // 
            InputUsername.Font = new Font("Segoe UI", 15.75F);
            InputUsername.Location = new Point(403, 260);
            InputUsername.Multiline = true;
            InputUsername.Name = "InputUsername";
            InputUsername.Size = new Size(234, 50);
            InputUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(250, 261);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(250, 338);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 636);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InputUsername);
            Controls.Add(InputPassword);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "auth";
            Text = "auth";
            Load += auth_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogin;
        private TextBox InputPassword;
        private TextBox InputUsername;
        private Label label2;
        private Label label3;
    }
}