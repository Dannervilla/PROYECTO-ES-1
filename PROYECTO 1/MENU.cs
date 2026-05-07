using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_1
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            REGISTRAR_TRABAJO trabajo = new REGISTRAR_TRABAJO();
            trabajo.Show();
            this.Hide(); // opcional
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ULTIMO_TRABAJO ultimo = new ULTIMO_TRABAJO();
            ultimo.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TRABAJOS_PENDIENTES trabajopen = new TRABAJOS_PENDIENTES();
            trabajopen.Show();
            Hide();

         }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
