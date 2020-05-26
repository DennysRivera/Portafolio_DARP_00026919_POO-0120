using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VentaLibros
{
    public partial class frmCliente : Form
    {
        private Usuario usuario;

        public frmCliente(Usuario user)
        {
            InitializeComponent();
            usuario = user;
        }
        
        private void ActualizarControles()
        {
            List<Inventario> lista = ConsultaInventario.articulosStock();

            comboBox1.DataSource = null;
            comboBox1.ValueMember = "id_libro";
            comboBox1.DisplayMember = "nombre_libro";
            comboBox1.DataSource = lista;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ActualizarControles();
            try
            {
                var dt = Conexion.ExecuteQuery($"SELECT (nombre_libro) FROM INVENTARIO");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventario i = (Inventario) comboBox1.SelectedItem;
            
            lblDesc.Text = i.descripcion;
            lblPrecio.Text = '$' + i.precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.ExecuteQuery($"SELECT * FROM PEDIDO" +
                                               $"WHERE nombre_usuario = '{usuario.usuario}'");

                dataGridView1.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario u = (Inventario) comboBox1.SelectedItem;
            DateTime fecha = DateTime.Now;
            ConsultaPedido.agregarPedido(u, usuario, fecha, 
                Convert.ToInt32(lblTotal.Text), Convert.ToInt32(numericUpDown1.Text));
        }

        private void tpPedido_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.ExecuteQuery($"SELECT * FROM INVENTARIO");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Inventario u = (Inventario) comboBox1.SelectedItem;
            lblTotal.Text = ((numericUpDown1.Value) * u.precio).ToString();
        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.usuario + "?", 
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                    MessageBox.Show("Ocurrió un error",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}