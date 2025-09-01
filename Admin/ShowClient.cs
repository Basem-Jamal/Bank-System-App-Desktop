using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_App
{
    public partial class ShowClient : Form
    {
        public static List<User> users = new List<User>();

        public ShowClient()
        {
            InitializeComponent();
            InitializeDataGrid(); // تهيئة الأعمدة

        }

        private void ShowClient_Load(object sender, EventArgs e)
        {
            //// إنشاء جدول مؤقت لعرض البيانات
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Password");
            //dt.Columns.Add("Account Number");
            //dt.Columns.Add("Balance");

            //foreach (var user in users)
            //{
            //    dt.Rows.Add(user._name, user._password, user._accountNumber, user._balance);
            //}

            //// ربط الجدول بـ DataGridView (افترض أنك ضفت DataGridView في الفورم اسمه dataGridView1)
            //dataGridViewClient.DataSource = dt;

        }

        private void InitializeDataGrid()
        {
            dataGridViewClient.ColumnCount = 4;
            dataGridViewClient.Columns[0].Name = "Name";
            dataGridViewClient.Columns[1].Name = "Password";
            dataGridViewClient.Columns[2].Name = "Account Number";
            dataGridViewClient.Columns[3].Name = "Balance";

            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // دالة لتحديث البيانات في DataGridView
        public void DisplayClients(List<AddClient.User> users)
        {
            dataGridViewClient.Rows.Clear();
            foreach (var user in users)
            {
                dataGridViewClient.Rows.Add(user._name, user._password, user._accountNumber, user._balance);
            }
            this.Show();
        }

    }


}
