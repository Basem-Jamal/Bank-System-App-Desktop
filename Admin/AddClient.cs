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

namespace Bank_System_App
{
    public partial class AddClient : Form
    {
        public class User
        {
            public string _name = "";
            public string _password = "";
            public string _accountNumber = "";
            public string _balance = "";

        }


        public AddClient()
        {
            InitializeComponent();

        }

        private void Save()
        {
            var u = new User();
            u._name = InputNewName.Text;
            u._password = InputNewPassword.Text;
            u._accountNumber = InputNewAccountNumber.Text;
            u._balance = InputNewBalance.Text;

            HomeMain.users.Add(u);
       

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            // إنشاء الفورم الثاني وعرض كل العملاء
            ShowClient showForm = new ShowClient();
            showForm.DisplayClients(HomeMain.users);

            auth saveInAuth = new auth();

            this.Close(); // يغلق الفورم بعد حفظ العميل

        }
    }
}
