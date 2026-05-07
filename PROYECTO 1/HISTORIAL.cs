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
    public partial class HISTORIAL : Form
    {
        public HISTORIAL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
