using System.ComponentModel;

namespace VentaLibros
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpPedido = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpHistorial = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHome);
            this.tabControl1.Controls.Add(this.tpPedido);
            this.tabControl1.Controls.Add(this.tpHistorial);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))),
                ((int) (((byte) (255)))));
            this.tpHome.Controls.Add(this.label10);
            this.tpHome.Controls.Add(this.label9);
            this.tpHome.Controls.Add(this.label8);
            this.tpHome.Controls.Add(this.pictureBox1);
            this.tpHome.Location = new System.Drawing.Point(4, 24);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(561, 428);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            // 
            // tpPedido
            // 
            this.tpPedido.BackColor = System.Drawing.Color.CadetBlue;
            this.tpPedido.Controls.Add(this.lblTotal);
            this.tpPedido.Controls.Add(this.label7);
            this.tpPedido.Controls.Add(this.numericUpDown1);
            this.tpPedido.Controls.Add(this.label6);
            this.tpPedido.Controls.Add(this.label4);
            this.tpPedido.Controls.Add(this.button2);
            this.tpPedido.Controls.Add(this.lblDesc);
            this.tpPedido.Controls.Add(this.lblPrecio);
            this.tpPedido.Controls.Add(this.label3);
            this.tpPedido.Controls.Add(this.label2);
            this.tpPedido.Controls.Add(this.comboBox1);
            this.tpPedido.Controls.Add(this.label1);
            this.tpPedido.Controls.Add(this.dataGridView1);
            this.tpPedido.Location = new System.Drawing.Point(4, 24);
            this.tpPedido.Name = "tpPedido";
            this.tpPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedido.Size = new System.Drawing.Size(561, 428);
            this.tpPedido.TabIndex = 1;
            this.tpPedido.Text = "Hacer un pedido";
            this.tpPedido.Click += new System.EventHandler(this.tpPedido_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(365, 321);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "$0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(198, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(365, 276);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(198, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Artículos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hacer pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(365, 107);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(164, 69);
            this.lblDesc.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(365, 217);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 23);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "$0";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(198, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio del artículo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(198, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción  del artículo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(365, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(198, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículo a comprar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(167, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpHistorial
            // 
            this.tpHistorial.BackColor = System.Drawing.Color.CadetBlue;
            this.tpHistorial.Controls.Add(this.button1);
            this.tpHistorial.Controls.Add(this.label5);
            this.tpHistorial.Controls.Add(this.dataGridView2);
            this.tpHistorial.Location = new System.Drawing.Point(4, 24);
            this.tpHistorial.Name = "tpHistorial";
            this.tpHistorial.Size = new System.Drawing.Size(561, 428);
            this.tpHistorial.TabIndex = 2;
            this.tpHistorial.Text = "Historial";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar historial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(22, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 66);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mi historial de compras:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 153);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(545, 267);
            this.dataGridView2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VentaLibros.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(119, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 212);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(70, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(419, 52);
            this.label8.TabIndex = 1;
            this.label8.Text = "Venta de libros y cómics";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(102, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 47);
            this.label9.TabIndex = 2;
            this.label9.Text = "La Siguiente Página";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(110, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 39);
            this.label10.TabIndex = 3;
            this.label10.Text = "\"Una página más no es suficiente\"";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCliente_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCliente_FormClosed);
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpPedido;
        private System.Windows.Forms.TabPage tpHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}