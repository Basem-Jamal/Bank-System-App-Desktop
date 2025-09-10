namespace Bank_System_App
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            pictureBox1 = new PictureBox();
            InputCurrentAccount = new TextBox();
            InputToAccount = new TextBox();
            Amount = new TextBox();
            btnTransfer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(180, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // InputCurrentAccount
            // 
            InputCurrentAccount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputCurrentAccount.Location = new Point(129, 277);
            InputCurrentAccount.Multiline = true;
            InputCurrentAccount.Name = "InputCurrentAccount";
            InputCurrentAccount.Size = new Size(291, 54);
            InputCurrentAccount.TabIndex = 1;
            // 
            // InputToAccount
            // 
            InputToAccount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputToAccount.Location = new Point(129, 352);
            InputToAccount.Multiline = true;
            InputToAccount.Name = "InputToAccount";
            InputToAccount.Size = new Size(291, 54);
            InputToAccount.TabIndex = 2;
            // 
            // Amount
            // 
            Amount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.Location = new Point(194, 431);
            Amount.Multiline = true;
            Amount.Name = "Amount";
            Amount.Size = new Size(162, 47);
            Amount.TabIndex = 3;
            // 
            // btnTransfer
            // 
            btnTransfer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransfer.Location = new Point(156, 538);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(215, 58);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F);
            label1.Location = new Point(22, 291);
            label1.Name = "label1";
            label1.Size = new Size(83, 40);
            label1.TabIndex = 5;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F);
            label2.Location = new Point(31, 366);
            label2.Name = "label2";
            label2.Size = new Size(46, 40);
            label2.TabIndex = 6;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F);
            label3.Location = new Point(31, 438);
            label3.Name = "label3";
            label3.Size = new Size(120, 40);
            label3.TabIndex = 7;
            label3.Text = "Amount";
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 681);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTransfer);
            Controls.Add(Amount);
            Controls.Add(InputToAccount);
            Controls.Add(InputCurrentAccount);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TransferForm";
            Text = "Transfer";
            Load += Transfer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox InputCurrentAccount;
        private TextBox InputToAccount;
        private TextBox Amount;
        private Button btnTransfer;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}