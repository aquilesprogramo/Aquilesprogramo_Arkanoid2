using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class OptionUser : Form
    {
        public OptionUser()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            Hide();
            register.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.Show();
        }
    }
}