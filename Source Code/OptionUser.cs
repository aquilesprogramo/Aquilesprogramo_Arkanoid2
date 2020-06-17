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

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}