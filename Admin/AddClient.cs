using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using System.IO;
using System.Security.Cryptography;

namespace Bank_System_App
{
    public partial class AddClient : Form
    {
        //string filePath = @"C:\HUAWEI\source\repos\Basem-Jamal\Bank-System-App-Desktop\data\UserData.json";

        string filePath = @"C:\Users\HUAWEI\source\repos\Basem-Jamal\Bank-System-App-Desktop\data\UserData.json";



         //Path Home PC
        //string filePath = @"C:\Users\user\source\repos\14 - C# - Level 1\Desktop app\Bank System App\data\UserData.json";
        public class User
        {

            public string _name          { set; get; }
            public string _username      { set; get; }
            public string _password      { set; get; }
            public string _accountNumber { set; get; }
            public float _balance       { set; get; }
            public string _validity      { set; get; }

        }


        public AddClient()
        {
            InitializeComponent();
            InputNewPassword.PasswordChar = '*';

        }

        private void SaveForAdding()
        {
            List<User> users = new List<User>();

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                
                if (!string.IsNullOrWhiteSpace(jsonData))
                {
                    users = JsonSerializer.Deserialize<List<User>>(jsonData);

                }
                else
                {
                    users = new List<User>();
                }
            }
            else
            {
                MessageBox.Show("للأسف الشديد يحتاج لك تنسيق للملف", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingUser = users.FirstOrDefault(u => u._username == InputUserName.Text);
            if (existingUser != null)
            {
                MessageBox.Show("اسم المستخدم موجود بالفعل! يرجى اختيار اسم آخر.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // إيقاف عملية الحفظ

            }

            
            var u = new User {
                _name = InputUserName.Text,
                _username = InputUserName.Text,
                _password = InputNewPassword.Text,
                _balance = 0.00f ,
                _validity = "User"
            };

            Random rnd = new Random();
            string Country = "SA10002000";
            string accountNumber = "";

            for (int j = 0; j < 10; j++)
            {
                accountNumber += rnd.Next(0,9).ToString(); // returns random integers >= 10 and < 20
            }
            u._accountNumber = Country + accountNumber;

            users.Add(u);


            string newJsonData = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, newJsonData);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            SaveForAdding();
            this.Close(); // يغلق الفورم بعد حفظ العميل

        }
    }
}
