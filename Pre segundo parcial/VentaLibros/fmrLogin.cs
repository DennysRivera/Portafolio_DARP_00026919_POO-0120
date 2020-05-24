using System;
using System.Windows.Forms;

namespace VentaLibros
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            frmRegister ventana = new frmRegister();
            ventana.ShowDialog();
        }
    }
}