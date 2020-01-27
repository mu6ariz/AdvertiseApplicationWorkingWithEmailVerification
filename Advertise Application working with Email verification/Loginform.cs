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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string email = txbx_email.Text;
            string password = txbx_password.Text;

            Database database = new Database();
            User user = database.FindUser(email, password);

            if(user == null)
            {
                MessageBox.Show("This user is not exists");
            }
            else
            {
                AccountForm accountForm = new AccountForm();
                accountForm.Username = user.Name;
                accountForm.ShowDialog();
            }
        }
    }
}
