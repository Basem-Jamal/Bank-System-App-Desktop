namespace Bank_System_App
{
    partial class HomeMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMain));
            labelName = new Label();
            panelMenu = new Panel();
            showWithdraw = new Button();
            showDeposit = new Button();
            showBalance = new Button();
            panelShowBalance = new Panel();
            panelBalanceSmall = new Panel();
            titleBalanceInDashboard = new Label();
            pictureBox3 = new PictureBox();
            labelBalance = new Label();
            labelWithdraw = new Label();
            panelDeposit = new Panel();
            labelCountForDeposit = new Label();
            InputDeposit = new TextBox();
            confirm_deposit = new Button();
            titleDeposit = new Label();
            panelWithdraw = new Panel();
            labelCountForWithdraw = new Label();
            InputWithdraw = new TextBox();
            confirm_withdraw = new Button();
            titleWithdraw = new Label();
            panelInfoContact = new Panel();
            welcomeName = new Label();
            panelWithdrawSmall = new Panel();
            pictureBox1 = new PictureBox();
            titleWithdrawInDashboard = new Label();
            panelDashboard = new Panel();
            panelTransferSmall = new Panel();
            pictureBox2 = new PictureBox();
            titleTransferInDashboard = new Label();
            labelTransfer = new Label();
            menuStrip1 = new MenuStrip();
            addUsersToolStripMenuItem = new ToolStripMenuItem();
            newClientToolStripMenuItem = new ToolStripMenuItem();
            editClientToolStripMenuItem = new ToolStripMenuItem();
            showClientToolStripMenuItem = new ToolStripMenuItem();
            backgPanel = new Panel();
            panel1 = new Panel();
            labelTotalBalances = new Label();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label = new Label();
            panelShowMeNumberOfCurrentClients = new Panel();
            pictureBox4 = new PictureBox();
            labelShowMeNumberOfCurrentClients = new Label();
            btnSignOut = new Button();
            panelMenu.SuspendLayout();
            panelShowBalance.SuspendLayout();
            panelBalanceSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelDeposit.SuspendLayout();
            panelWithdraw.SuspendLayout();
            panelInfoContact.SuspendLayout();
            panelWithdrawSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            panelTransferSmall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            backgPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelShowMeNumberOfCurrentClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(280, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(176, 37);
            labelName.TabIndex = 0;
            labelName.Text = "CurrentName";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(showWithdraw);
            panelMenu.Controls.Add(showDeposit);
            panelMenu.Controls.Add(showBalance);
            panelMenu.Location = new Point(12, 53);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(843, 137);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // showWithdraw
            // 
            showWithdraw.Cursor = Cursors.Hand;
            showWithdraw.Font = new Font("Segoe UI", 18F);
            showWithdraw.Location = new Point(496, 31);
            showWithdraw.Name = "showWithdraw";
            showWithdraw.Size = new Size(188, 53);
            showWithdraw.TabIndex = 2;
            showWithdraw.Text = "Withdraw";
            showWithdraw.UseVisualStyleBackColor = true;
            showWithdraw.Click += showWithdraw_Click;
            // 
            // showDeposit
            // 
            showDeposit.Cursor = Cursors.Hand;
            showDeposit.Font = new Font("Segoe UI", 18F);
            showDeposit.Location = new Point(260, 29);
            showDeposit.Name = "showDeposit";
            showDeposit.Size = new Size(188, 53);
            showDeposit.TabIndex = 1;
            showDeposit.Text = "Deposit";
            showDeposit.UseVisualStyleBackColor = true;
            showDeposit.Click += showDeposit_Click;
            // 
            // showBalance
            // 
            showBalance.Cursor = Cursors.Hand;
            showBalance.Font = new Font("Segoe UI", 18F);
            showBalance.Location = new Point(21, 28);
            showBalance.Name = "showBalance";
            showBalance.Size = new Size(218, 58);
            showBalance.TabIndex = 0;
            showBalance.Text = "Show Me Balance";
            showBalance.UseVisualStyleBackColor = true;
            showBalance.Click += showBalance_Click;
            // 
            // panelShowBalance
            // 
            panelShowBalance.BackColor = Color.Transparent;
            panelShowBalance.Controls.Add(panelBalanceSmall);
            panelShowBalance.Location = new Point(926, 229);
            panelShowBalance.Name = "panelShowBalance";
            panelShowBalance.Size = new Size(628, 304);
            panelShowBalance.TabIndex = 2;
            panelShowBalance.Visible = false;
            panelShowBalance.Paint += panelShowBalance_Paint;
            // 
            // panelBalanceSmall
            // 
            panelBalanceSmall.BackColor = Color.White;
            panelBalanceSmall.Controls.Add(titleBalanceInDashboard);
            panelBalanceSmall.Controls.Add(pictureBox3);
            panelBalanceSmall.Controls.Add(labelBalance);
            panelBalanceSmall.Location = new Point(261, 59);
            panelBalanceSmall.Name = "panelBalanceSmall";
            panelBalanceSmall.Size = new Size(320, 203);
            panelBalanceSmall.TabIndex = 1;
            // 
            // titleBalanceInDashboard
            // 
            titleBalanceInDashboard.AutoSize = true;
            titleBalanceInDashboard.BackColor = Color.Transparent;
            titleBalanceInDashboard.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            titleBalanceInDashboard.ForeColor = Color.Black;
            titleBalanceInDashboard.Location = new Point(47, 21);
            titleBalanceInDashboard.Name = "titleBalanceInDashboard";
            titleBalanceInDashboard.Size = new Size(111, 37);
            titleBalanceInDashboard.TabIndex = 5;
            titleBalanceInDashboard.Text = "Balance";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(192, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 72);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.BackColor = Color.Transparent;
            labelBalance.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalance.Location = new Point(30, 111);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(108, 37);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Balance";
            // 
            // labelWithdraw
            // 
            labelWithdraw.AutoSize = true;
            labelWithdraw.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWithdraw.Location = new Point(19, 111);
            labelWithdraw.Name = "labelWithdraw";
            labelWithdraw.Size = new Size(189, 37);
            labelWithdraw.TabIndex = 1;
            labelWithdraw.Text = "erorrWithdraw";
            // 
            // panelDeposit
            // 
            panelDeposit.BackColor = Color.Transparent;
            panelDeposit.Controls.Add(labelCountForDeposit);
            panelDeposit.Controls.Add(InputDeposit);
            panelDeposit.Controls.Add(confirm_deposit);
            panelDeposit.Controls.Add(titleDeposit);
            panelDeposit.Location = new Point(1044, 229);
            panelDeposit.Name = "panelDeposit";
            panelDeposit.Size = new Size(416, 465);
            panelDeposit.TabIndex = 3;
            panelDeposit.Visible = false;
            panelDeposit.Paint += panelDeposit_Paint;
            // 
            // labelCountForDeposit
            // 
            labelCountForDeposit.AutoSize = true;
            labelCountForDeposit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountForDeposit.Location = new Point(190, 405);
            labelCountForDeposit.Name = "labelCountForDeposit";
            labelCountForDeposit.Size = new Size(32, 37);
            labelCountForDeposit.TabIndex = 3;
            labelCountForDeposit.Text = "3";
            // 
            // InputDeposit
            // 
            InputDeposit.BorderStyle = BorderStyle.FixedSingle;
            InputDeposit.Font = new Font("Segoe UI", 20.25F);
            InputDeposit.Location = new Point(82, 170);
            InputDeposit.Multiline = true;
            InputDeposit.Name = "InputDeposit";
            InputDeposit.Size = new Size(249, 58);
            InputDeposit.TabIndex = 2;
            // 
            // confirm_deposit
            // 
            confirm_deposit.BackColor = Color.Black;
            confirm_deposit.Cursor = Cursors.Hand;
            confirm_deposit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_deposit.ForeColor = Color.White;
            confirm_deposit.Location = new Point(116, 315);
            confirm_deposit.Name = "confirm_deposit";
            confirm_deposit.Size = new Size(181, 61);
            confirm_deposit.TabIndex = 1;
            confirm_deposit.Text = "Deposit Now";
            confirm_deposit.UseVisualStyleBackColor = false;
            confirm_deposit.Click += confirm_deposit_Click;
            // 
            // titleDeposit
            // 
            titleDeposit.AutoSize = true;
            titleDeposit.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleDeposit.Location = new Point(132, 41);
            titleDeposit.Name = "titleDeposit";
            titleDeposit.Size = new Size(149, 50);
            titleDeposit.TabIndex = 0;
            titleDeposit.Text = "Deposit";
            // 
            // panelWithdraw
            // 
            panelWithdraw.BackColor = Color.Transparent;
            panelWithdraw.Controls.Add(labelCountForWithdraw);
            panelWithdraw.Controls.Add(InputWithdraw);
            panelWithdraw.Controls.Add(confirm_withdraw);
            panelWithdraw.Controls.Add(titleWithdraw);
            panelWithdraw.Location = new Point(1044, 229);
            panelWithdraw.Name = "panelWithdraw";
            panelWithdraw.Size = new Size(416, 465);
            panelWithdraw.TabIndex = 4;
            panelWithdraw.Visible = false;
            panelWithdraw.Paint += panelWithdraw_Paint;
            // 
            // labelCountForWithdraw
            // 
            labelCountForWithdraw.AutoSize = true;
            labelCountForWithdraw.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountForWithdraw.Location = new Point(190, 405);
            labelCountForWithdraw.Name = "labelCountForWithdraw";
            labelCountForWithdraw.Size = new Size(32, 37);
            labelCountForWithdraw.TabIndex = 3;
            labelCountForWithdraw.Text = "3";
            // 
            // InputWithdraw
            // 
            InputWithdraw.BorderStyle = BorderStyle.FixedSingle;
            InputWithdraw.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputWithdraw.Location = new Point(82, 170);
            InputWithdraw.Multiline = true;
            InputWithdraw.Name = "InputWithdraw";
            InputWithdraw.Size = new Size(249, 58);
            InputWithdraw.TabIndex = 2;
            // 
            // confirm_withdraw
            // 
            confirm_withdraw.BackColor = Color.Black;
            confirm_withdraw.Cursor = Cursors.Hand;
            confirm_withdraw.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_withdraw.ForeColor = Color.White;
            confirm_withdraw.Location = new Point(116, 315);
            confirm_withdraw.Name = "confirm_withdraw";
            confirm_withdraw.Size = new Size(181, 61);
            confirm_withdraw.TabIndex = 1;
            confirm_withdraw.Text = "Withdraw Now";
            confirm_withdraw.UseVisualStyleBackColor = false;
            confirm_withdraw.Click += confirm_withdraw_Click;
            // 
            // titleWithdraw
            // 
            titleWithdraw.AutoSize = true;
            titleWithdraw.BackColor = Color.Transparent;
            titleWithdraw.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleWithdraw.Location = new Point(116, 41);
            titleWithdraw.Name = "titleWithdraw";
            titleWithdraw.Size = new Size(181, 50);
            titleWithdraw.TabIndex = 0;
            titleWithdraw.Text = "Withdraw";
            // 
            // panelInfoContact
            // 
            panelInfoContact.BackColor = Color.Transparent;
            panelInfoContact.Controls.Add(welcomeName);
            panelInfoContact.Controls.Add(labelName);
            panelInfoContact.Location = new Point(1031, 53);
            panelInfoContact.Name = "panelInfoContact";
            panelInfoContact.Size = new Size(478, 137);
            panelInfoContact.TabIndex = 4;
            panelInfoContact.Paint += panelInfoContact_Paint;
            // 
            // welcomeName
            // 
            welcomeName.AutoSize = true;
            welcomeName.BackColor = Color.Transparent;
            welcomeName.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeName.Location = new Point(50, 35);
            welcomeName.Name = "welcomeName";
            welcomeName.Size = new Size(235, 45);
            welcomeName.TabIndex = 0;
            welcomeName.Text = "welcomeName";
            // 
            // panelWithdrawSmall
            // 
            panelWithdrawSmall.BackColor = Color.Transparent;
            panelWithdrawSmall.Controls.Add(pictureBox1);
            panelWithdrawSmall.Controls.Add(titleWithdrawInDashboard);
            panelWithdrawSmall.Controls.Add(labelWithdraw);
            panelWithdrawSmall.Location = new Point(31, 59);
            panelWithdrawSmall.Name = "panelWithdrawSmall";
            panelWithdrawSmall.Size = new Size(330, 203);
            panelWithdrawSmall.TabIndex = 5;
            panelWithdrawSmall.Paint += panelWithdrawSmall_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(214, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 72);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // titleWithdrawInDashboard
            // 
            titleWithdrawInDashboard.AutoSize = true;
            titleWithdrawInDashboard.BackColor = Color.Transparent;
            titleWithdrawInDashboard.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            titleWithdrawInDashboard.ForeColor = Color.Black;
            titleWithdrawInDashboard.Location = new Point(39, 31);
            titleWithdrawInDashboard.Name = "titleWithdrawInDashboard";
            titleWithdrawInDashboard.Size = new Size(169, 37);
            titleWithdrawInDashboard.TabIndex = 2;
            titleWithdrawInDashboard.Text = "Withdrawals";
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.Transparent;
            panelDashboard.Controls.Add(panelTransferSmall);
            panelDashboard.Controls.Add(panelWithdrawSmall);
            panelDashboard.Location = new Point(10, 229);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(843, 465);
            panelDashboard.TabIndex = 3;
            panelDashboard.Paint += panelDashboard_Paint;
            // 
            // panelTransferSmall
            // 
            panelTransferSmall.BackColor = Color.Transparent;
            panelTransferSmall.Controls.Add(pictureBox2);
            panelTransferSmall.Controls.Add(titleTransferInDashboard);
            panelTransferSmall.Controls.Add(labelTransfer);
            panelTransferSmall.Location = new Point(457, 59);
            panelTransferSmall.Name = "panelTransferSmall";
            panelTransferSmall.Size = new Size(330, 203);
            panelTransferSmall.TabIndex = 6;
            panelTransferSmall.Paint += panelTransferSmall_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(214, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 72);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // titleTransferInDashboard
            // 
            titleTransferInDashboard.AutoSize = true;
            titleTransferInDashboard.BackColor = Color.Transparent;
            titleTransferInDashboard.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            titleTransferInDashboard.ForeColor = Color.Black;
            titleTransferInDashboard.Location = new Point(75, 31);
            titleTransferInDashboard.Name = "titleTransferInDashboard";
            titleTransferInDashboard.Size = new Size(115, 37);
            titleTransferInDashboard.TabIndex = 2;
            titleTransferInDashboard.Text = "Transfer";
            // 
            // labelTransfer
            // 
            labelTransfer.AutoSize = true;
            labelTransfer.BackColor = Color.Transparent;
            labelTransfer.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransfer.ForeColor = Color.Black;
            labelTransfer.Location = new Point(24, 113);
            labelTransfer.Name = "labelTransfer";
            labelTransfer.Size = new Size(166, 37);
            labelTransfer.TabIndex = 1;
            labelTransfer.Text = "erorrTransfer";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUsersToolStripMenuItem, editClientToolStripMenuItem, showClientToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1579, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // addUsersToolStripMenuItem
            // 
            addUsersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newClientToolStripMenuItem });
            addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            addUsersToolStripMenuItem.Size = new Size(75, 20);
            addUsersToolStripMenuItem.Text = "Add Client";
            // 
            // newClientToolStripMenuItem
            // 
            newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            newClientToolStripMenuItem.Size = new Size(132, 22);
            newClientToolStripMenuItem.Text = "New Client";
            newClientToolStripMenuItem.Click += newClientToolStripMenuItem_Click;
            // 
            // editClientToolStripMenuItem
            // 
            editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            editClientToolStripMenuItem.Size = new Size(73, 20);
            editClientToolStripMenuItem.Text = "Edit Client";
            // 
            // showClientToolStripMenuItem
            // 
            showClientToolStripMenuItem.Name = "showClientToolStripMenuItem";
            showClientToolStripMenuItem.Size = new Size(82, 20);
            showClientToolStripMenuItem.Text = "Show Client";
            showClientToolStripMenuItem.Click += showClientToolStripMenuItem_Click;
            // 
            // backgPanel
            // 
            backgPanel.BackColor = Color.Gainsboro;
            backgPanel.Controls.Add(panel1);
            backgPanel.Controls.Add(label1);
            backgPanel.Controls.Add(label);
            backgPanel.Controls.Add(panelShowMeNumberOfCurrentClients);
            backgPanel.Controls.Add(panelDashboard);
            backgPanel.Controls.Add(btnSignOut);
            backgPanel.Controls.Add(panelWithdraw);
            backgPanel.Controls.Add(panelDeposit);
            backgPanel.Controls.Add(panelInfoContact);
            backgPanel.Controls.Add(panelMenu);
            backgPanel.Controls.Add(panelShowBalance);
            backgPanel.Dock = DockStyle.Fill;
            backgPanel.Location = new Point(0, 0);
            backgPanel.Name = "backgPanel";
            backgPanel.Size = new Size(1579, 791);
            backgPanel.TabIndex = 6;
            backgPanel.Paint += backgPanel_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTotalBalances);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(508, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 217);
            panel1.TabIndex = 8;
            // 
            // labelTotalBalances
            // 
            labelTotalBalances.AutoSize = true;
            labelTotalBalances.Font = new Font("Segoe UI", 26.25F);
            labelTotalBalances.Location = new Point(83, 152);
            labelTotalBalances.Name = "labelTotalBalances";
            labelTotalBalances.Size = new Size(85, 47);
            labelTotalBalances.TabIndex = 6;
            labelTotalBalances.Text = "0.00";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(232, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 72);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(604, 193);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 5;
            label1.Text = "Total balances";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Snow;
            label.Location = new Point(170, 193);
            label.Name = "label";
            label.Size = new Size(99, 45);
            label.TabIndex = 0;
            label.Text = "Clints";
            // 
            // panelShowMeNumberOfCurrentClients
            // 
            panelShowMeNumberOfCurrentClients.Controls.Add(pictureBox4);
            panelShowMeNumberOfCurrentClients.Controls.Add(labelShowMeNumberOfCurrentClients);
            panelShowMeNumberOfCurrentClients.Location = new Point(41, 253);
            panelShowMeNumberOfCurrentClients.Name = "panelShowMeNumberOfCurrentClients";
            panelShowMeNumberOfCurrentClients.Size = new Size(382, 217);
            panelShowMeNumberOfCurrentClients.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(231, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 72);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // labelShowMeNumberOfCurrentClients
            // 
            labelShowMeNumberOfCurrentClients.AutoSize = true;
            labelShowMeNumberOfCurrentClients.Font = new Font("Segoe UI", 26.25F);
            labelShowMeNumberOfCurrentClients.Location = new Point(93, 148);
            labelShowMeNumberOfCurrentClients.Name = "labelShowMeNumberOfCurrentClients";
            labelShowMeNumberOfCurrentClients.Size = new Size(39, 47);
            labelShowMeNumberOfCurrentClients.TabIndex = 1;
            labelShowMeNumberOfCurrentClients.Text = "0";
            // 
            // btnSignOut
            // 
            btnSignOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOut.Location = new Point(33, 720);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(140, 46);
            btnSignOut.TabIndex = 5;
            btnSignOut.Text = "SignOut";
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // HomeMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1579, 791);
            Controls.Add(menuStrip1);
            Controls.Add(backgPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeMain";
            Load += Home_Load;
            Paint += Home_Main;
            panelMenu.ResumeLayout(false);
            panelShowBalance.ResumeLayout(false);
            panelBalanceSmall.ResumeLayout(false);
            panelBalanceSmall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelDeposit.ResumeLayout(false);
            panelDeposit.PerformLayout();
            panelWithdraw.ResumeLayout(false);
            panelWithdraw.PerformLayout();
            panelInfoContact.ResumeLayout(false);
            panelInfoContact.PerformLayout();
            panelWithdrawSmall.ResumeLayout(false);
            panelWithdrawSmall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboard.ResumeLayout(false);
            panelTransferSmall.ResumeLayout(false);
            panelTransferSmall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            backgPanel.ResumeLayout(false);
            backgPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelShowMeNumberOfCurrentClients.ResumeLayout(false);
            panelShowMeNumberOfCurrentClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Panel panelMenu;
        private Button showBalance;
        private Button showWithdraw;
        private Button showDeposit;
        private Panel panelShowBalance;
        private Label labelBalance;
        private Label labelWithdraw;
        private Panel panelDeposit;
        private Label titleDeposit;
        private Panel panelInfoContact;
        private Label welcomeName;
        private Label labelCountForDeposit;
        private TextBox InputDeposit;
        private Button confirm_deposit;
        private Panel panelWithdraw;
        private Label labelCountForWithdraw;
        private TextBox InputWithdraw;
        private Button confirm_withdraw;
        private Label titleWithdraw;
        private Panel panelBalanceSmall;
        private Panel panelWithdrawSmall;
        private Panel panelDashboard;
        private PictureBox pictureBox1;
        private Label titleWithdrawInDashboard;
        private PictureBox pictureBox3;
        private Panel panelTransferSmall;
        private PictureBox pictureBox2;
        private Label titleTransferInDashboard;
        private Label labelTransfer;
        private Label titleBalanceInDashboard;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addUsersToolStripMenuItem;
        private ToolStripMenuItem newClientToolStripMenuItem;
        private ToolStripMenuItem editClientToolStripMenuItem;
        private ToolStripMenuItem showClientToolStripMenuItem;
        private Panel backgPanel;
        private Button btnSignOut;
        private Panel panelShowMeNumberOfCurrentClients;
        private Label labelShowMeNumberOfCurrentClients;
        private Label label;
        private PictureBox pictureBox4;
        private Label label1;
        private Label labelTotalBalances;
        private PictureBox pictureBox5;
        private Panel panel1;
    }
}
