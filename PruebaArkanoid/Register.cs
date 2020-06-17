using System;
using System.Data;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No dejar el campo vacio");
            }

            else
            {
                try
                {
                    user(); // Funcion para agregar a un usuario nuevo.
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void user()
        {
            
            var c = Conexion.ExecuteQuery($"select nombre_usuario from usuario");

            foreach (DataRow d in c.Rows) // Recorrer todos los nombres en la base de datos.
            {
                Lista.lista.Add(d[0].ToString()); //Agregarlo a lista de clase estatica llamada Lista con su metodo.
            }

            if (Lista.lista.Contains(textBox1.Text)) // Verificar en lista si existe un usuario.
            {
                MessageBox.Show("Este nombre ya esta registrado. Pruebe con otro nombre",
                    "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                User.nombre = textBox1.Text;

                Conexion.ExecuteNonQuery($"insert into usuario values ('{User.nombre}')"); 
                MessageBox.Show("Se ha registrado"); 
                Hide();
                
                Loading loading = new Loading(); 
                loading.Show();
                Close();
            }
        }
    }
}
