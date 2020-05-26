using System;
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
            if (textBox1.Text.Equals("") || textBox1.Text.Equals("") || textBox1.Text.Equals("") ||
                textBox1.Text.Equals("") || textBox1.Text.Equals(""))
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
                        //ConsultaUsuario.registrarUsuario(nuevo.nombre, nuevo.usuario, nuevo.contrasena);
                        ConsultaUsuario.registrarUsuario(nuevo);
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