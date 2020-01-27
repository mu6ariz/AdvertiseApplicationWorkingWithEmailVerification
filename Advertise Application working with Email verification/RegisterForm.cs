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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            User user = new User();
            user.Email = txbx_email.Text;
            user.Name = txbx_name.Text;
            user.Password = txbx_password.Text;
            user.Surname = txbx_surname.Text;

            database.AddUser(user);


            Loginform loginform = new Loginform();
            loginform.ShowDialog();
        }
    }
}
