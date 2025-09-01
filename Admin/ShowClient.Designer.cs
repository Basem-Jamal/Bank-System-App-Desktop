namespace Bank_System_App
{
    partial class ShowClient
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
            dataGridViewClient = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(35, 76);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.Size = new Size(1220, 577);
            dataGridViewClient.TabIndex = 0;
            // 
            // ShowClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 721);
            Controls.Add(dataGridViewClient);
            Name = "ShowClient";
            Text = "ShowClient";
            Load += ShowClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClient;
    }
}