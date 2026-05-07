using PROYECTO_1.BASE;
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
            trabajo.FormClosed += (s, args) => this.Close();
            trabajo.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ULTIMO_TRABAJO ultimo = new ULTIMO_TRABAJO();
            ultimo.FormClosed += (s, args) => this.Close();
            ultimo.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TRABAJOS_PENDIENTES trabajopen = new TRABAJOS_PENDIENTES();
            trabajopen.FormClosed += (s, args) => this.Close();
            trabajopen.Show();
            Hide();

         }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            BUSCAR_CLIENTES buscar = new BUSCAR_CLIENTES();
            buscar.FormClosed += (s, args) => this.Close();
            buscar.Show();
            Hide();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            INGRESOS ingresos = new INGRESOS();
            ingresos.FormClosed += (s, args) => this.Close();
            ingresos.Show();
            Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HISTORIAL his = new  HISTORIAL();
            his.FormClosed += (s, args) => this.Close();
            his.Show();
            Hide();

        }
    }
}
