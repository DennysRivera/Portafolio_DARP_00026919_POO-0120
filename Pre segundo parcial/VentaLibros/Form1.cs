using System;
using System.Windows.Forms;
using LiveCharts.WinForms;

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

            if (usuario.admin)
            {
                estadisticas = new CartesianChart();
                this.Controls.Add(estadisticas);
                estadisticas.Parent = tabControl1.TabPages[3];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (usuario.admin)
            {
                configurarGraficos();
                actualizarControles();
            }
            else
            {
                tabControl1.TabPages[1] = null;
            }
        }
    }
}