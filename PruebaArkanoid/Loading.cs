using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }

            else
            {
                timer1.Enabled = false;
                Game game = new Game();
                Hide();
                game.Show();
            }
        }
    }
}
    
