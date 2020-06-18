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

        private void btn1_Click(object sender, EventArgs e)
        {
            usuario();
        }

        private void usuario()
        {
            var c = Conexion.ExecuteQuery($"select nombre from usuario");

            foreach (DataRow d in c.Rows)
            {
                Lista.lista.Add(d[0].ToString());
            }
            
            if (txt1.Text == "")
            {
                MessageBox.Show("Don't leave the field empty");
            }

            else if (Lista.lista.Contains(txt1.Text))
            {
                User.nombre = txt1.Text;
                
                MessageBox.Show("Welcome: "+User.nombre);
                
                    
                Loading loading = new Loading();
                Hide();
                
                loading.Show();
                Close();
            }

            else
            {
                MessageBox.Show("You haven't registered");
                
                Register register = new Register();
                register.Show(); 
            }
        }
    }
}