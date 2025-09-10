using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_App
{
    public partial class TransferForm : Form
    {
        private HomeMain showDataFrom;

        public TransferForm(HomeMain homeForm)
        {
            InitializeComponent();
            showDataFrom = homeForm;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

            InputCurrentAccount.ReadOnly = true;
            InputCurrentAccount.Text = showDataFrom.currentAccountNumber;
        }

        //AddClient.User IsExistAccountNumber ()
        //{

        //    if (!File.Exists(showDataFrom.filePath))
        //    {
        //        MessageBox.Show("تعذر تحميل الملف !");
        //        return null;
        //    }

        //    string json = File.ReadAllText(showDataFrom.filePath);
        //    List<AddClient.User> users = JsonSerializer.Deserialize<List<AddClient.User>>(json);

        //    var existingUserByAccNum = users.FirstOrDefault(user => InputToAccount.Text == user._accountNumber.ToString());

        //    if (existingUserByAccNum == null)
        //    {
        //        MessageBox.Show($"لايوجد عميل يملك رقم الحساب هذا  !:{InputToAccount.Text}");
        //        return null;
        //    }

        //    return existingUserByAccNum;

        //}

        private void Transfer()
        {

            if (!float.TryParse(Amount.Text, out float amount))
            {
                MessageBox.Show("الرجاء إدخال مبلغ صحيح");
                return;
            }

            if (!File.Exists(showDataFrom.filePath))
            {
                MessageBox.Show("تعذر تحميل الملف !");
                return;
            }

            string json = File.ReadAllText(showDataFrom.filePath);
            List<AddClient.User> users = JsonSerializer.Deserialize<List<AddClient.User>>(json);

            var receiver = users.FirstOrDefault(user => InputToAccount.Text == user._accountNumber.ToString());

            if (receiver == null)
            {
                MessageBox.Show($"لا يوجد عميل يملك رقم الحساب هذا: {InputToAccount.Text}");
                return;

            }

            if (amount > showDataFrom.currentBalance)
            {
                MessageBox.Show($"المبلغ أكبر من رصيدك حبي!{amount}");
                return;
            }

            receiver._balance += amount;

            var sender = users.FirstOrDefault(user => user._accountNumber.ToString() == showDataFrom.currentAccountNumber);

            if (sender != null)
            {
                sender._balance -= amount;
                showDataFrom.currentBalance = sender._balance;
            }


            string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(showDataFrom.filePath, updatedJson);

            MessageBox.Show($"تم تحويل المبلغ بنجاح, رصيدك الحالي{showDataFrom.currentBalance}" , "البنــــك");
        }
        private void MangeTransfers()
        {
            Transfer();
            this.Hide();
            showDataFrom.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            MangeTransfers();
        }
    }
}
