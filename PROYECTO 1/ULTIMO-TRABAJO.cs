using PROYECTO_1.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_1
{
    public partial class ULTIMO_TRABAJO : Form
    {
        public ULTIMO_TRABAJO()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            dataGridView1.DataSource = new PROYECTO_1.CLASES.Cliente().listado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow.Cells["CI"].Value != null)
                {
                    label21.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    label5.Text = dataGridView1.CurrentRow.Cells["CI"].Value.ToString();
                    label7.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
                    label12.Text = dataGridView1.CurrentRow.Cells["TIPO"].Value.ToString();
                    label14.Text = dataGridView1.CurrentRow.Cells["CANTIDAD"].Value.ToString();
                    label16.Text = dataGridView1.CurrentRow.Cells["PRECIO"].Value.ToString();
                    label18.Text = dataGridView1.CurrentRow.Cells["TOTAL"].Value.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
