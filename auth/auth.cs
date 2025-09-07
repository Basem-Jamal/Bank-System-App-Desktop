using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//JSON
using System.Text.Json;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;


namespace Bank_System_App
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
            InputPassword.PasswordChar = '*';

        }

        private void auth_Load(object sender, EventArgs e)
        {
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(InputUsername.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم.");
                return false;
            }

            return true;
        }
        private AddClient.User IsExistUserOrAdmin()
        {

            string username = InputUsername.Text;
            string password = InputPassword.Text;


            List<AddClient.User> users = new List<AddClient.User>();

            //Shared 
            string filePath = @"\\26.78.158.132\WarehouseShared\UserData.json";

            //Path Labtop
            //string filePath = @"C:\Users\HUAWEI\source\repos\Basem-Jamal\Bank-System-App-Desktop\data\UserData.json";\


            //Path Home PC
            //string filePath = @"C:\Users\user\source\repos\14 - C# - Level 1\Desktop app\Bank System App\data\UserData.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("للاسف الملف غير موجود لعرض العملاء");
                return null;
            }


            string jsonData = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<AddClient.User>>(jsonData);


            var existingUser = users.FirstOrDefault(u => u._username == InputUsername.Text && u._password == InputPassword.Text);
            if (existingUser == null)
            {
                MessageBox.Show("Username Or Password Is Flide!");
                return null;

            }

            return existingUser;


        }
        private void Login()
        {
            AddClient.User User = IsExistUserOrAdmin();

            AddClient.User Admin = new AddClient.User();

            if (User != null)
            {

                MessageBox.Show("Hello " + (User._name));
                this.Hide();
                HomeMain HomeFormAdmin = new HomeMain(User._name, User._username ,User._balance, User._validity);
                HomeFormAdmin.Show();
            }
            else
            {
                MessageBox.Show("Username Or Password Is Flide!");

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Login();
            }
        }
    }
}
