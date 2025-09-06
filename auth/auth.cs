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

            if (string.IsNullOrWhiteSpace(InputPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال كلمة المرور.");
                return false;
            }

            if (!RadioAdmin.Checked && !RadioUser.Checked)
            {
                MessageBox.Show("الرجاء اختيار نوع المستخدم.");
                return false;

            }

            return true;
        }
        private AddClient.User IsExistUserOrAdmin()
        {
            string username = InputUsername.Text;
            string password = InputPassword.Text;
            string role = RadioAdmin.Checked ? "Admin" : "Client"; // أو حسب RadioButton

            return HomeMain.users.Find(u =>
                u._name == username && u._password == password
            );

        }
        private void Login()
        {
            AddClient.User User = IsExistUserOrAdmin();

            AddClient.User Admin = new AddClient.User();
            //AddClient.User User = new AddClient.User();


            //Admin._name     = "Basem";
            //Admin._password = "123";
            //Admin._balance  = "1000";

            //User._name = "Basem";
            //User._password = "123";
            //User._balance = "1000";

            if (User != null) 
            {

                if (RadioAdmin.Checked)
                {
                    User._validity = "Admin";
                }
                else if (RadioUser.Checked)
                {
                    User._validity = "User";
                }
                MessageBox.Show("Hello " + (User._name));
                this.Hide();
                HomeMain HomeFormAdmin = new HomeMain(User._name , 1000, User._validity);
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
