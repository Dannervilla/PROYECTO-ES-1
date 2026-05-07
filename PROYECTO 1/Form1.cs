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
    public partial class Form1 : Form

    {
        int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "admin";
            string contraseñaCorrecta = "1234";

            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                MessageBox.Show("ACCESO PERMITIDO.");

                MENU menu = new MENU();
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
                Hide();

            }
            else
            {
                intentos--;

                if (intentos > 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.\nIntentos restantes: " + intentos);
                }
                else
                {
                    MessageBox.Show("Acceso bloqueado. Se agotaron los 3 intentos.");
                    button3.Enabled = false;
                    this.Close();
                }
            }
        }
    }
}
