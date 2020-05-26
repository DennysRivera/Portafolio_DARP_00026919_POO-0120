using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace VentaLibros
{
    public partial class Form1 : Form
    {
        private Usuario usuario;
        private CartesianChart estadisticas;

        public Form1(Usuario user)
        {
            InitializeComponent();
            usuario = user;

            estadisticas = new CartesianChart();
            this.Controls.Add(estadisticas);
            estadisticas.Parent = tabControl1.TabPages[5];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configurarGrafico();
            actualizarControles();
        }
        
        private void actualizarControles()
        {
            List<Inventario> lista = ConsultaInventario.articulosStock();
            
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "id_libro";
            comboBox1.DisplayMember = "libro_nombre";
            comboBox1.DataSource = lista;
            // Grafico con estadisticas
            //poblarGrafico();
        }

        private void configurarGrafico()
        {
            estadisticas.Top = 10;
            estadisticas.Left = 10;
            estadisticas.Left = 10;
            estadisticas.Width = estadisticas.Parent.Width - 20;
            estadisticas.Height = estadisticas.Parent.Height - 20;

            estadisticas.Series = new SeriesCollection
            {
                new ColumnSeries{Title = "Cantidad de inicios de sesion", Values = new ChartValues<int>(), DataLabels = true}
            };
            estadisticas.AxisX.Add(new Axis{Labels = new List<string>()});
            estadisticas.AxisX[0].Separator = new Separator() {Step = 1, IsEnabled = false};
            estadisticas.LegendLocation = LegendLocation.Top;
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                try
                {
                    Usuario nuevo = new Usuario();
                    nuevo.nombre = txtNombre.Text + " " + txtApellido.Text;
                    nuevo.usuario = txtUsuario.Text;
                    nuevo.contrasena = txtUsuario.Text;
                    ConsultaUsuario.registrarUsuario(nuevo);
                    
                    MessageBox.Show("Usuario creado con los datos: \nNombre de usuario: " + txtUsuario.Text +
                                        ", contraseña: " + txtUsuario.Text + "\nRegistrado como Cliente Activo");

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtUsuario.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Conexion.ExecuteQuery($"SELECT * FROM USUARIO");

                dataGridView1.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        private void btnCambios_Click(object sender, EventArgs e)
        {
            bool flag = true;
            var verificacion = ConsultaUsuario.usuariosRegistrados();

            try
            {
                foreach (Usuario u in verificacion)
                {
                    if (textBox1.Text.Equals(u.usuario))
                    {
                        if (u.admin) radAdmin.Checked = true;
                        else radCliente.Checked = true;
                        if (u.activo) radActivo.Checked = true;
                        else radInactivo.Checked = true;
                        ConsultaUsuario.actualizarUsuario(textBox1.Text, radAdmin.Checked, radActivo.Checked);
                        flag = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
            if (flag)
                MessageBox.Show("El usuario no existe");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool flag = true;
            var verificacion = ConsultaUsuario.usuariosRegistrados();

            try
            {
                foreach (Usuario u in verificacion)
                {
                    if (textBox1.Text.Equals(u.usuario))
                    {
                        if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + textBox1.Text + "?",
                                "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                                DialogResult.Yes)
                        {
                            ConsultaUsuario.eliminarUsuario(textBox1.Text);
                            flag = false;
                            break; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
            if (flag)
                MessageBox.Show("El usuario no existe");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNuevoL.Text.Equals("") || richTextBox3.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                try
                {
                    Inventario nuevo = new Inventario();
                    nuevo.nombre_libro = txtNuevoL.Text;
                    nuevo.descripcion = richTextBox3.Text;
                    nuevo.precio = numericUpDown1.Value;
                    nuevo.stock = Convert.ToInt32(numericUpDown2.Text);
                    
                    ConsultaInventario.agregarArticulo(nuevo);
                    MessageBox.Show("Artículo registrado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }

        private void tpInventario_Click(object sender, EventArgs e)
        {
            Inventario i = (Inventario) comboBox1.SelectedItem;

            richTextBox2.Text = i.descripcion;
            numericUpDown3.Value = Convert.ToDecimal(i.precio);
            numericUpDown4.Value = Convert.ToInt32(i.stock);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            int extras = Convert.ToInt32(numericUpDown4.Text);
            ConsultaInventario.actualizarArticulo((Inventario) comboBox1.SelectedItem, extras);
            
            MessageBox.Show("Datos actualizados", 
                "Actualización libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            actualizarControles();
        }
    }
}