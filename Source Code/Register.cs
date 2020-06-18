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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Don't leave the field empty");
            }

            else
            {
                try
                {
                    user(); // Function to add a new user.
                }
                catch (Exception)
                {
                    MessageBox.Show("There has been an error");
                }
            }
        }

        private void user()
        {
            
            var c = Conexion.ExecuteQuery($"select nombre from usuario");

            foreach (DataRow d in c.Rows) // Runs through all the names in the data base.
            {
                Lista.lista.Add(d[0].ToString()); //Add to the static list.
            }

            if (Lista.lista.Contains(txt1.Text)) // Verify if the name exists in the list.
            {
                MessageBox.Show("This name has been registered. Try another name",
                    "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                User.nombre = txt1.Text;

                Conexion.ExecuteNonQuery($"insert into usuario values ('{User.nombre}')"); 
                MessageBox.Show("You have registered succesfully"); 
                Hide();
                
                Loading loading = new Loading(); 
                loading.Show();
                Close();
            }
        }
    }
}
