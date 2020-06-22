using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OptionUser optionUser = new OptionUser();
            optionUser.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
