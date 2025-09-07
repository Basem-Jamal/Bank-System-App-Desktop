using Bank_System_App;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//JSON
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;


namespace Bank_System_App
{

    public partial class HomeMain : Form
    {
        public static List<AddClient.User> users = new List<AddClient.User>();

        //Shared 
        string filePath = @"\\26.78.158.132\WarehouseShared\UserData.json";

        //Path Labtop
        //string filePath = @"C:\Users\HUAWEI\source\repos\Basem-Jamal\Bank-System-App-Desktop\data\UserData.json";\


        //Path Home PC
        //string filePath = @"C:\Users\user\source\repos\14 - C# - Level 1\Desktop app\Bank System App\data\UserData.json";

        enum enTransaction
        {
            enShowBalance = 0,
            enDeposit = 1,
            enWithdraw = 2
        }

        public string currentName = "";
        public string currentUsername = "";
        public string currentValidity = "";
        public float currentBalance;
        float calculatorWithdraw = 0.00f;
        decimal counterDeposit = 3;
        decimal counterWithdraw = 3;

        static void errorMessage()
        {
            MessageBox.Show("الرجاء إدخال رقم صحيح للإداع");
        }

        static void MoneyIsNotEnoughMessage()
        {
            MessageBox.Show("المبلغ الذي ادخلته اكبر من رصيدك الحالي!");
        }

        
        public HomeMain(string nameFromForm1, string username, float balance, string Validity)
        {

            InitializeComponent();

            if (Validity == "Admin")
            {
                LoadUsers();
                UpdateAdminDashboardStats();
                panelBalanceSmall.Hide();
                panelDashboard.Hide();
                panelDeposit.Hide();
                panelMenu.Hide();
                panelTransferSmall.Hide();
                panelWithdraw.Hide();
            }
            else if (Validity == "User")
            {
                menuStrip1.Hide();
                panelShowMeNumberOfCurrentClients.Hide();
                panelShowMeTotalBalances.Hide();
                labelTitleTotalBalances.Hide();
                labelTitleNumberOfClients.Hide();
            }
            currentName     = nameFromForm1;
            currentUsername = username;
            currentBalance  = balance;
            currentValidity = Validity;




            labelName.Text = nameFromForm1;
            currentBalance = balance;
            labelBalance.Text = currentBalance.ToString("F2") + "SR";

            labelCountForDeposit.Text = counterDeposit.ToString();
            labelCountForDeposit.ForeColor = Color.Green;
            labelCountForWithdraw.ForeColor = Color.Green;

            labelWithdraw.Text = "0.00";
            labelTransfer.Text = "---";



            // تمكين DoubleBuffering لمنع الوميض
            this.DoubleBuffered = true;
        }

        private void LoadUsers ()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);

                users = JsonConvert.DeserializeObject<List<AddClient.User>>(jsonData);

            }
        }
        private void UpdateAdminDashboardStats()
        {
           int count = users.Count;
           labelShowMeNumberOfCurrentClients.Text = count.ToString();

           //Calculator Balances
           float total = 0.00f;
           foreach(var user in users)
           {
               total += user._balance;
           }

           labelTotalBalances.Text = total.ToString("#,##0.00") + "ر.س";
            
        }

        public void RefreshDashboard()
        {
            LoadUsers();               // قراءة الملف مرة أخرى
            UpdateAdminDashboardStats(); // تحديث عدد العملاء والرصيد الإجمالي
        }

        private void UpdateBalanceAfterDeposit (string currentUsername, float newBalance)
        {
            string jsonData = File.ReadAllText(filePath);
            var users = JsonConvert.DeserializeObject<List<AddClient.User>>(jsonData);


            var user = users.FirstOrDefault(u => u._username == currentUsername);

            if (user != null)
            {
                user._balance = newBalance;

                string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);

            }
        }

        // دالة لتقوس بانل واحد
        public void RoundPanel(Panel panel, int radius = 20)
        {
            if (panel.Width == 0 || panel.Height == 0 || this.WindowState == FormWindowState.Minimized)
                return;

            GraphicsPath path = new GraphicsPath();
            Rectangle rect = panel.ClientRectangle;
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        // دالة لتطبيق الانحناء على كل Panels
        public void RoundAllPanels(Control parent, int radius = 20)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // فقط البانلات باستثناء backgPanel
                if (ctrl is Panel panel)
                {

                    RoundPanel(panel, radius); // تطبيق نصف القطر الموحد

                    // كرر العملية على البانلات الداخلية
                    if (panel.Controls.Count > 0)
                    {
                        RoundAllPanels(panel, radius);
                    }
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            backgPanel.SendToBack();
            SetControlsParentToBackgPanel(this);

            welcomeName.Text = "Welcome";
            RoundAllPanels(this, 15);
            UpdateAdminDashboardStats();

        }

        private void SetControlsParentToBackgPanel(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // تجاهل البانل الخلفية نفسها
                if (ctrl != backgPanel)
                {
                    // تحقق من الاسم
                    if (ctrl.Name == "panelMenu" || ctrl.Name == "panelDashboard" || ctrl.Name == "panelInfoContact" || ctrl.Name == "panelShowBalance")
                    {
                        ctrl.BackColor = Color.Transparent;  // اجعل الخلفية شفافة
                        ctrl.Parent = backgPanel;            // اجعل backgPanel هو الأب
                    }
                    // إذا أردت استثناء بعض الكنترولز مثل DataGridView
                    if (ctrl is DataGridView)
                    {
                        continue; // تجاهل تطبيق التأثير
                    }
                }

                // كرر العملية للكنترولز الداخلية
                if (ctrl.Controls.Count > 0)
                {
                    SetControlsParentToBackgPanel(ctrl);
                }
            }
        }

        private void Home_Main(object sender, PaintEventArgs e)
        {
            //// تجنب الرسم عند التصغير
            backgPanel.Dock = DockStyle.Fill;
            backgPanel.SendToBack(); // اجعل البانل خلف كل الكنترولز

        }




        private void backgPanel_Paint(object sender, PaintEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            Color color1 = Color.FromArgb(0x1D, 0x26, 0x71);
            Color color2 = Color.FromArgb(0xC3, 0x37, 0x64);

            using (var brush = new LinearGradientBrush(
                backgPanel.ClientRectangle, color1, color2,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, backgPanel.ClientRectangle);
            }

        }


        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(120, 0, 0, 0);
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {
            panelDashboard.BackColor = Color.FromArgb(120, 0, 0, 0);
        }

        private void MangeTransaction(enTransaction transactionType)
        {
            if (transactionType == enTransaction.enDeposit)
            {
                if (float.TryParse(InputDeposit.Text, out float dep))
                {
                    counterDeposit--;
                    currentBalance += (float)dep;
                    labelBalance.Text = currentBalance.ToString("F2") + "SR";
                    InputDeposit.Clear();

                    labelCountForDeposit.Text = counterDeposit.ToString();

                    UpdateBalanceAfterDeposit(currentUsername, currentBalance);


                    if (counterDeposit == 2)
                    {
                        labelCountForDeposit.ForeColor = Color.Orange;
                    }
                    else if (counterDeposit == 1)
                    {
                        labelCountForDeposit.ForeColor = Color.Red;
                    }
                    else if (counterDeposit == 0)
                    {
                        labelCountForDeposit.ForeColor = Color.Red;
                        labelCountForDeposit.Enabled = false;
                        InputDeposit.Enabled = false;
                        confirm_deposit.Enabled = false;
                        confirm_deposit.BackColor = Color.Silver;
                        MessageBox.Show("لقد انتهت عدد المحاولات المتاحة!");
                        panelShowBalance.Hide();
                        panelDeposit.Hide();
                    }
                }
                else
                {
                    errorMessage();
                }
            }
            else if (transactionType == enTransaction.enWithdraw)
            {
                if (float.TryParse(InputWithdraw.Text, out float withd))
                {
                    if (withd > currentBalance)
                    {
                        MoneyIsNotEnoughMessage();
                        counterWithdraw--;
                        return;
                    }
                    counterWithdraw--;

                    currentBalance -= withd;
                    calculatorWithdraw -= withd;

                    labelBalance.Text = currentBalance.ToString("F2") + "SR";
                    labelWithdraw.Text = calculatorWithdraw.ToString("F2") + "SR";
                    InputWithdraw.Clear();

                    labelCountForWithdraw.Text = counterWithdraw.ToString();

                    if (counterWithdraw == 2)
                    {
                        labelCountForWithdraw.ForeColor = Color.Orange;
                    }
                    else if (counterWithdraw == 1)
                    {
                        labelCountForWithdraw.ForeColor = Color.Red;
                    }
                    else if (counterWithdraw == 0)
                    {
                        labelCountForWithdraw.ForeColor = Color.Red;
                        labelCountForWithdraw.Enabled = false;
                        InputWithdraw.Enabled = false;
                        confirm_withdraw.Enabled = false;
                        confirm_withdraw.BackColor = Color.Silver;
                        MessageBox.Show("لقد انتهت عدد المحاولات المتاحة!");
                        panelDeposit.Hide();
                    }
                }
                else
                {
                    errorMessage();
                }
            }
        }

        private void showBalance_Click(object sender, EventArgs e)
        {
            panelShowBalance.Show();
            panelDeposit.Hide();
            panelWithdraw.Hide();
        }

        private void showDeposit_Click(object sender, EventArgs e)
        {
            panelShowBalance.Hide();
            panelWithdraw.Hide();
            panelDeposit.Show();
        }

        private void showWithdraw_Click(object sender, EventArgs e)
        {
            panelShowBalance.Hide();
            panelDeposit.Hide();
            panelWithdraw.Show();
        }

        private void confirm_deposit_Click(object sender, EventArgs e)
        {
            MangeTransaction(enTransaction.enDeposit);
        }

        private void confirm_withdraw_Click(object sender, EventArgs e)
        {
            MangeTransaction(enTransaction.enWithdraw);
        }

        private void panelTransferSmall_Paint(object sender, PaintEventArgs e)
        {
            panelTransferSmall.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelTransfer.ForeColor = Color.White;
            titleTransferInDashboard.ForeColor = Color.White;
        }

        private void panelBalance_Paint(object sender, PaintEventArgs e)
        {
            labelBalance.BackColor = Color.Transparent;
            labelBalance.ForeColor = Color.White;
        }

        private void panelWithdrawSmall_Paint(object sender, PaintEventArgs e)
        {
            panelWithdrawSmall.BackColor = Color.FromArgb(100, 0, 0, 0);
            labelWithdraw.BackColor = Color.Transparent;
            labelWithdraw.ForeColor = Color.White;
            titleWithdraw.ForeColor = Color.White;
            titleWithdrawInDashboard.ForeColor = Color.White;
        }

        private void panelInfoContact_Paint(object sender, PaintEventArgs e)
        {
            panelInfoContact.BackColor = Color.FromArgb(100, 0, 0, 0);
            welcomeName.ForeColor = Color.White;
            labelName.ForeColor = Color.White;
        }

        private void panelShowBalance_Paint(object sender, PaintEventArgs e)
        {
            panelShowBalance.BackColor = Color.FromArgb(120, 0, 0, 0);
            panelBalanceSmall.BackColor = Color.FromArgb(100, 0, 0, 0);

            labelBalance.ForeColor = Color.White;
            titleBalanceInDashboard.ForeColor = Color.White;
        }

        private void panelWithdraw_Paint(object sender, PaintEventArgs e)
        {
            // تجنب الرسم عند التصغير
            if (this.WindowState == FormWindowState.Minimized)
                return;

            Color color1 = Color.FromArgb(0x1D, 0x26, 0x71);
            Color color2 = Color.FromArgb(0xC3, 0x37, 0x64);

            using (var brush = new LinearGradientBrush(
                panelWithdraw.ClientRectangle, color1, color2,
                LinearGradientMode.Horizontal))
            {
                panelWithdraw.ForeColor = Color.White;
                e.Graphics.FillRectangle(brush, panelWithdraw.ClientRectangle);
            }
        }

        private void panelDeposit_Paint(object sender, PaintEventArgs e)
        {
            //تجنب الرسم عند التصغير
            if (this.WindowState == FormWindowState.Minimized)
                return;

            Color color1 = Color.FromArgb(0x1D, 0x26, 0x71);
            Color color2 = Color.FromArgb(0xC3, 0x37, 0x64);

            using (var brush = new LinearGradientBrush(
                panelDeposit.ClientRectangle, color1, color2,
                LinearGradientMode.Horizontal))
            {
                panelDeposit.ForeColor = Color.White;
                e.Graphics.FillRectangle(brush, panelDeposit.ClientRectangle);
            }
        }

        //Mange Users ( Add - Edit )
        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient C = new AddClient(this);
            C.ShowDialog();
        }

        private void showClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClient S = new ShowClient();
            S.DisplayClients(users);
            S.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            auth LoginForm = new auth();
            this.Hide();
            LoginForm.Show();
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void titleTransferInDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}