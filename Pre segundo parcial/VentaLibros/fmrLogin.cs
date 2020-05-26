using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VentaLibros
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUsuarios = ConsultaUsuario.usuariosRegistrados();

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Usuario/Contraseña no ingresado");
            }
            else
            {
                try
                {
                    foreach (var u in listaUsuarios)
                    {
                        if (textBox1.Text.Equals(u.usuario))
                        {
                            if (textBox2.Text.Equals(u.contrasena))
                            {
                                if (u.activo)
                                {
                                    MessageBox.Show("Bienvenido");
                                    Form1 window = new Form1(u);
                                    window.Show();
                                    this.Hide();   
                                }
                                else
                                    MessageBox.Show("Cuenta deshabilitada, favor contactarse con el administrador");
                                
                            }
                            else MessageBox.Show("Contraseña incorrecta");

                            break;
                        }
                        else MessageBox.Show("No se encontró el usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister ventana = new frmRegister();
            ventana.ShowDialog();
        }
    }
}