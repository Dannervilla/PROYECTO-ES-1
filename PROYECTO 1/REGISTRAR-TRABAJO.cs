using Microsoft.Win32;
using PROYECTO_1.BASE;
using PROYECTO_1.CLASES;
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
    public partial class REGISTRAR_TRABAJO : Form
    {
        Cliente cliente = new Cliente();


        private void GuardarClientes()
        {
            using (FOTOEntities2 db = new FOTOEntities2())
            {
                int ci = int.Parse(textBox2.Text);

                var existe = db.CLIENTES.FirstOrDefault(x => x.CI == ci);

                if (existe == null)
                {
                    CLIENTES registro = new CLIENTES();

                    registro.NOMBRE = textBox1.Text;
                    registro.CI = ci;
                    registro.TELEFONO = textBox3.Text;

                    db.CLIENTES.Add(registro);
                    db.SaveChanges();
                }
            }
        }

        private void GuardarServicios()
        {
            SERVICIOS registro = new SERVICIOS();
            registro.TIPO = comboBox1.Text;
            registro.CANTIDAD = int.Parse(numericUpDown1.Text);
            registro.PRECIO = double.Parse(numericUpDown2.Text);

            double total = Convert.ToDouble(numericUpDown1.Text) * Convert.ToDouble(numericUpDown2.Text);
            registro.TOTAL = total;

            cliente.Guardar(registro);
        }


        PILA mipila = new PILA();

        public REGISTRAR_TRABAJO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string ci = textBox2.Text;
            string servicio = comboBox1.Text;
            string numero = textBox3.Text;

            int hojas = Convert.ToInt32(numericUpDown1.Text);
            double precio = Convert.ToDouble(numericUpDown2.Text);
            double total = hojas * precio;

            label21.Text = nombre;
            label12.Text = servicio;
            label14.Text = hojas.ToString();
            label16.Text = precio.ToString("0.00") + " bs";
            label18.Text = total.ToString("0.00") + " bs";

            TRABAJO nuevo = new TRABAJO(nombre, ci, servicio, numero, hojas, precio, total);

            mipila.Push(nuevo);

            GuardarClientes();
            GuardarServicios();

            MessageBox.Show("Trabajo registrado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.SelectedIndex = -1;

            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;

            label21.Text = "";
            label12.Text = "";
            label14.Text = "";
            label16.Text = "";
            label18.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}