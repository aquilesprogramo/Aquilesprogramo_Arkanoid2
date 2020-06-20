using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : Form
    {
        private static Random rand = new Random();
        private int x = rand.Next(5,12);// Randomization to make the ball move differently.
        private int t = rand.Next(5,12);// Randomization to make the ball move differently.
        private int life = 5;// Total Lives.
        private int score=0;// Initialization of Score.
        private int ScoreMax = 18;// Maximum Score allowed.

        public Game()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Top += x; // Movement of the ball.
            ball.Left += t; //Movement of the ball in a curve
            lbl2.Text = "Score: " + score;// Showing the Score.
            lbl14.Text = "Life: " + life;// Showing the lives left.

            if (ball.Bottom > ClientSize.Height)
            {
                x = -x; // If the ball touches the bottom of the screen it bounces.
            }

            else if (ball.Top < 0)
            {
                x = -x; // If the ball touches the top of the screen it bounces.
            }
            
             else if (ball.Right > ClientSize.Width)
            {
                t = -t; // If the ball touches the right side of the screen it bounces.
            }
            
             else if (ball.Left < 0)
            {
                t = -t; // If the ball touches the left side of the screen it bouncess.
            }

            else if (ball.Bounds.IntersectsWith(mouse.Bounds))
            {
                x = -x; // If the ball touches the paddle it bounces.
            }
            
            foreach (Control s in Controls) // Goes through all of the blocks.
            { 
                
                if (s is Label && (string)s.Tag == "block3")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds)) // If the ball touches the label.
                    {
                        x = -x; // It bounces.
                        Controls.Remove(s); // It's removed.
                    }
                }
                
                else if (s is Label && (string)s.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds)) // If the ball touches the label.
                    {
                        
                        score += 2; //It adds 2 points to the score when it bounces.
                        x = -x; // It bounces back.
                        Controls.Remove(s); // It's removed.
                        
                    }
                }
                else if (s is Label && (string)s.Tag == "block2")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds)) // If the ball touches the label.
                    {
                        score += 1; //It adds 1 points to the score when it bounces.
                        x = -x; // It bounces back.
                        Controls.Remove(s); // It's removed.
                    }
                }
                
                
            }
            
            if (ball.Bottom > ClientSize.Height || score == ScoreMax)
            {
                life--; // If the ball touches the bottom of the screen then the lives are reduced by 1.
                if (life == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Your record was: "+score);
                    
                    Conexion.ExecuteNonQuery($"insert into record(nombre_usuario, puntaje) " +
                                             $"values('{User.nombre}',{score})"); // It updates the score
                                                // in the database.
                    Close(); //It closes 
                }
            }
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            mouse.Left = e.X - mouse.Width / 2; // Movement of the mouse in a horizontal way.
        }
    }
}
