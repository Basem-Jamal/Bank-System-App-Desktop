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
            AddClient.User user = IsExistUserOrAdmin();

            if (user != null) 
            {
                MessageBox.Show("مرحبا بك $:{user.name}");
                this.Hide();
                HomeMain HomeFormAdmin = new HomeMain(user._name , 1000);
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
