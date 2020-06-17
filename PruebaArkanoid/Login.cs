using System;
using System.Data;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario();
        }

        private void usuario()
        {
            var c = Conexion.ExecuteQuery($"select nombre_usuario from usuario");

            foreach (DataRow d in c.Rows)
            {
                Lista.lista.Add(d[0].ToString());
            }

            if (Lista.lista.Contains(textBox1.Text))
            {
                User.nombre = textBox1.Text;
                
                MessageBox.Show("Bienvenido: "+User.nombre);
                
                    
                Loading loading = new Loading();
                Hide();
                
                loading.Show();
                Close();
            }

            else
            {
                MessageBox.Show("No se ha registrado");
                
                Register register = new Register();
                register.Show(); 
            }
        }
    }
}