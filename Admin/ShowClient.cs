using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Bank_System_App
{
    public partial class ShowClient : Form
    {
        //Path Labtop
        //string filePath = @"C:\Users\HUAWEI\source\repos\Basem-Jamal\Bank-System-App-Desktop\data\UserData.json";\

        //Path Home PC
        string filePath = @"C:\Users\user\source\repos\14 - C# - Level 1\Desktop app\Bank System App\data\UserData.json";

        public static List<AddClient.User> users = new List<AddClient.User>();

        public ShowClient()
        {
            InitializeComponent();

        }

        private void ShowClient_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
            LoadDataFromFileJson();

        }

        private void LoadDataFromFileJson()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<AddClient.User>>(jsonData);

            }
            else
            {
                MessageBox.Show("ملف JSON غير موجود!");
                return;
            }

            DisplayClients(users);

        }

        private void InitializeDataGrid()
        {
            dataGridViewClient.ColumnCount = 5;
            dataGridViewClient.Columns[0].Name = "Name";
            dataGridViewClient.Columns[1].Name = "Password";
            dataGridViewClient.Columns[2].Name = "Account Number";
            dataGridViewClient.Columns[3].Name = "Balance";
            dataGridViewClient.Columns[4].Name = "validity";

            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // دالة لتحديث البيانات في DataGridView
        public void DisplayClients(List<AddClient.User> users)
        {
            if (dataGridViewClient.Columns.Count == 0) // إذا ما فيه أعمدة
            {
                InitializeDataGrid(); // أنشئ الأعمدة
            }

            dataGridViewClient.Rows.Clear();
            foreach (var user in users)
            {
                dataGridViewClient.Rows.Add(user._name, user._password, user._accountNumber, user._balance, user._validity);
            }

            this.Show();

        }

    }


}
