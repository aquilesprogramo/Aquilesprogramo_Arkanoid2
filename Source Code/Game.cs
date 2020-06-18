using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : Form
    {
        private static Random rand = new Random();
        private int x = rand.Next(5,12);
        private int t = rand.Next(5,12);
        private int life = 5;
        private int score=0;
        private int ScoreMax = 18;

        public Game()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Top += x; // Movimiento de pelota.
            ball.Left += t; //Movimiento de pelota en curva.
            lbl2.Text = "Score: " + score; 
            lbl14.Text = "Life: " + life;

            if (ball.Bottom > ClientSize.Height)
            {
                x = -x; // Si pelota toca base esta se regresa.
            }

            else if (ball.Top < 0)
            {
                x = -x; // Si pelota toca Superficie se regresa.
            }
            
             else if (ball.Right > ClientSize.Width)
            {
                t = -t; // Si pelota toca lado derecho hay movimiento curvo izquierdo.
            }
            
             else if (ball.Left < 0)
            {
                t = -t; //Si pelota toca lado izquierdo hay movimiento curvo derecho.
            }

            else if (ball.Bounds.IntersectsWith(mouse.Bounds))
            {
                x = -x; //Si toca con el mouse el movimiento de la pelota regresa.
            }
            
            foreach (Control s in Controls) // Recorre todos los blocks.
            { 
                
                if (s is Label && (string)s.Tag == "block3")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds)) // Si pelota toca con alguno de los label.
                    {
                        x = -x; // Si toca hay un rebote.
                        Controls.Remove(s); // Se eliminan.
                    }
                }
                
                else if (s is Label && (string)s.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds))
                    {
                        
                        score += 2; //Valor de puntaje numero 2 para el usuario, segun block.
                        x = -x;
                        Controls.Remove(s);
                        
                    }
                }
                else if (s is Label && (string)s.Tag == "block2")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds))
                    {
                        score += 1; // Valor de puntaje numero 1 para el usuario, segun el block.
                        x = -x;
                        Controls.Remove(s);
                    }
                }
                
                
            }
            
            if (ball.Bottom > ClientSize.Height || score == ScoreMax)
            {
                life--; // Aqui si la pelota toca la base el numero establecido de vida el programa termina.
                if (life == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Your record was: "+score);
                    
                    Conexion.ExecuteNonQuery($"insert into record(nombre_usuario, puntaje) values('{User.nombre}',{score})");
                    Close(); // Linea 97 actualiza datos en base de datos del usuario.
                }
            }
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            mouse.Left = e.X - mouse.Width / 2; // Movimiento del mouse el linea horizontal.
        }
    }
}
