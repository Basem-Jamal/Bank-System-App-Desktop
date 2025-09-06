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
            dataGridViewClient.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Location = new Point(40, 101);
            dataGridViewClient.Margin = new Padding(3, 4, 3, 4);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.RowHeadersWidth = 51;
            dataGridViewClient.Size = new Size(1394, 769);
            dataGridViewClient.TabIndex = 0;
            // 
            // ShowClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 961);
            Controls.Add(dataGridViewClient);
            Margin = new Padding(3, 4, 3, 4);
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