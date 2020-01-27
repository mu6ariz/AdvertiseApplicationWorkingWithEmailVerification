using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterApp_11_11_2019
{
    public partial class AccountForm : Form
    {
        public string Username;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text += " " + Username;
            if(Username == "Admin")
            {
                Database database = new Database();
               User[] users = database.GetAllUsers();
                foreach (User item in users)
                {
                    listView1.Items.Add(item.Email+" "+item.Name+" "+item.Password);
                }
               // dataGridView1.m = "Name";
            }
        }
    }
}
