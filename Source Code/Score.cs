using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var dt = Conexion.ExecuteQuery("SELECT nombre_usuario, puntaje FROM record ORDER BY puntaje DESC LIMIT 10");
            dataGridView1.DataSource = dt;
        }
    }
}