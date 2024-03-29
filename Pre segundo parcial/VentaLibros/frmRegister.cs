﻿using System;
using System.Windows.Forms;

namespace VentaLibros
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") || textBox5.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                try
                {
                    Usuario nuevo = new Usuario();
                    nuevo.nombre = textBox1.Text + " " + textBox2.Text;
                    nuevo.usuario = textBox3.Text;
                    nuevo.contrasena = textBox4.Text;
                   
                    if (textBox4.Text.Equals(textBox5.Text))
                    {
                        ConsultaUsuario.registrarUsuario(nuevo);
                        MessageBox.Show("Registro completo");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                    else MessageBox.Show("Las contraseñas no coinciden");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }
        
        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar?", 
                "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }
    }
}