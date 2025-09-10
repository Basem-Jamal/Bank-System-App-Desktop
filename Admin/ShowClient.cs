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

        //Shared 
        //string filePath = @"\\26.78.158.132\WarehouseShared\UserData.json";

        //Path Labtop
        //string filePath = @"C:\Users\HUAWEI\source\repos\Basem-Jamal\Bank-System-App-Desktop\data\UserData.json";\


        //Path Home PC
        //string filePath = @"C:\Users\user\source\repos\14 - C# - Level 1\Desktop app\Bank System App\data\UserData.json";

        //Dynamic 
        public string filePath = auth.filePath;

        public static List<AddClient.User> users = new List<AddClient.User>();

        public ShowClient()
        {
            InitializeComponent();

        }

        private void ShowClient_Load(object sender, EventArgs e)
        {
            LoadDataFromFileJson();

        }

        public void RefreshData()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<AddClient.User>>(jsonData);

                DisplayClients(users);
            }
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

        public void DisplayClients(List<AddClient.User> users)
        {

            flowLayoutPanel1.Controls.Clear();

            foreach (var user in users)
            {
                Panel panel = new Panel();
                panel.Width = 250;
                panel.Height = 120;
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label nameLabel = new Label() { Text = "Name: " + user._name, Top = 10, Left = 10 };
                Label accLabel = new Label() { Text = "Account: " + user._accountNumber, Top = 30, Left = 10 };
                Label balanceLabel = new Label() { Text = "Balance: " + user._balance, Top = 50, Left = 10 };

                panel.Controls.Add(nameLabel);
                panel.Controls.Add(accLabel);
                panel.Controls.Add(balanceLabel);

                flowLayoutPanel1.Controls.Add(panel);
            }

        }

    }


}
