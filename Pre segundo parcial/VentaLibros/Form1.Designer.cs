namespace VentaLibros
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.tpCrear = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.radInactivo = new System.Windows.Forms.RadioButton();
            this.radActivo = new System.Windows.Forms.RadioButton();
            this.btnCambios = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tpInventario = new System.Windows.Forms.TabPage();
            this.btnInventario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpProducto = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtNuevoL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpPedidos = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tpUsuarios.SuspendLayout();
            this.tpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.tpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            this.tpPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHome);
            this.tabControl1.Controls.Add(this.tpCrear);
            this.tabControl1.Controls.Add(this.tpUsuarios);
            this.tabControl1.Controls.Add(this.tpInventario);
            this.tabControl1.Controls.Add(this.tpProducto);
            this.tabControl1.Controls.Add(this.tpPedidos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.label1);
            this.tpHome.Location = new System.Drawing.Point(4, 24);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(561, 428);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // tpCrear
            // 
            this.tpCrear.Controls.Add(this.btnMostrar);
            this.tpCrear.Controls.Add(this.dataGridView1);
            this.tpCrear.Controls.Add(this.btnCrear);
            this.tpCrear.Controls.Add(this.txtUsuario);
            this.tpCrear.Controls.Add(this.txtApellido);
            this.tpCrear.Controls.Add(this.txtNombre);
            this.tpCrear.Controls.Add(this.lbUsuario);
            this.tpCrear.Controls.Add(this.lbApellido);
            this.tpCrear.Controls.Add(this.lbNombre);
            this.tpCrear.Location = new System.Drawing.Point(4, 22);
            this.tpCrear.Name = "tpCrear";
            this.tpCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrear.Size = new System.Drawing.Size(561, 430);
            this.tpCrear.TabIndex = 1;
            this.tpCrear.Text = "Crear usuario";
            this.tpCrear.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(17, 130);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(128, 27);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 262);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(355, 70);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(162, 27);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(392, 14);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 23);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(161, 23);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Location = new System.Drawing.Point(296, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(90, 30);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario:";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbApellido
            // 
            this.lbApellido.Location = new System.Drawing.Point(6, 65);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(90, 30);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellidos:";
            this.lbApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNombre
            // 
            this.lbNombre.Location = new System.Drawing.Point(6, 9);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(90, 30);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombres:";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.Controls.Add(this.radAdmin);
            this.tpUsuarios.Controls.Add(this.radCliente);
            this.tpUsuarios.Controls.Add(this.textBox1);
            this.tpUsuarios.Controls.Add(this.btnEliminar);
            this.tpUsuarios.Controls.Add(this.radInactivo);
            this.tpUsuarios.Controls.Add(this.radActivo);
            this.tpUsuarios.Controls.Add(this.btnCambios);
            this.tpUsuarios.Controls.Add(this.btnVerificar);
            this.tpUsuarios.Controls.Add(this.label5);
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Size = new System.Drawing.Size(561, 430);
            this.tpUsuarios.TabIndex = 2;
            this.tpUsuarios.Text = "Usuarios";
            this.tpUsuarios.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.Location = new System.Drawing.Point(51, 258);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(104, 24);
            this.radAdmin.TabIndex = 11;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Administrador";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radCliente
            // 
            this.radCliente.Location = new System.Drawing.Point(51, 218);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(104, 24);
            this.radCliente.TabIndex = 10;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(328, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 38);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // radInactivo
            // 
            this.radInactivo.Location = new System.Drawing.Point(310, 258);
            this.radInactivo.Name = "radInactivo";
            this.radInactivo.Size = new System.Drawing.Size(97, 25);
            this.radInactivo.TabIndex = 7;
            this.radInactivo.TabStop = true;
            this.radInactivo.Text = "Inactivo";
            this.radInactivo.UseVisualStyleBackColor = true;
            // 
            // radActivo
            // 
            this.radActivo.Location = new System.Drawing.Point(310, 218);
            this.radActivo.Name = "radActivo";
            this.radActivo.Size = new System.Drawing.Size(97, 25);
            this.radActivo.TabIndex = 6;
            this.radActivo.TabStop = true;
            this.radActivo.Text = "Activo";
            this.radActivo.UseVisualStyleBackColor = true;
            // 
            // btnCambios
            // 
            this.btnCambios.Location = new System.Drawing.Point(180, 152);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(110, 35);
            this.btnCambios.TabIndex = 3;
            this.btnCambios.Text = "Guardar cambios";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(402, 30);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(110, 35);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar usuario";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpInventario
            // 
            this.tpInventario.Controls.Add(this.btnInventario);
            this.tpInventario.Controls.Add(this.label3);
            this.tpInventario.Controls.Add(this.label2);
            this.tpInventario.Controls.Add(this.richTextBox2);
            this.tpInventario.Controls.Add(this.numericUpDown4);
            this.tpInventario.Controls.Add(this.numericUpDown3);
            this.tpInventario.Controls.Add(this.comboBox1);
            this.tpInventario.Controls.Add(this.label7);
            this.tpInventario.Controls.Add(this.label6);
            this.tpInventario.Controls.Add(this.dataGridView2);
            this.tpInventario.Location = new System.Drawing.Point(4, 22);
            this.tpInventario.Name = "tpInventario";
            this.tpInventario.Size = new System.Drawing.Size(561, 430);
            this.tpInventario.TabIndex = 3;
            this.tpInventario.Text = "Inventario";
            this.tpInventario.UseVisualStyleBackColor = true;
            this.tpInventario.Click += new System.EventHandler(this.tpInventario_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(185, 196);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(171, 33);
            this.btnInventario.TabIndex = 10;
            this.btnInventario.Text = "Actualizar inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(415, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Añadir al inventario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(415, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio del artículo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(128, 125);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(187, 56);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(405, 171);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown4.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {0, 0, 0, 0});
            this.numericUpDown3.Location = new System.Drawing.Point(405, 91);
            this.numericUpDown3.Maximum = new decimal(new int[] {200, 0, 0, 0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripción del artículo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 42);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre del libro:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(560, 198);
            this.dataGridView2.TabIndex = 0;
            // 
            // tpProducto
            // 
            this.tpProducto.Controls.Add(this.richTextBox3);
            this.tpProducto.Controls.Add(this.btnAñadir);
            this.tpProducto.Controls.Add(this.numericUpDown2);
            this.tpProducto.Controls.Add(this.numericUpDown1);
            this.tpProducto.Controls.Add(this.txtNuevoL);
            this.tpProducto.Controls.Add(this.label11);
            this.tpProducto.Controls.Add(this.label10);
            this.tpProducto.Controls.Add(this.label9);
            this.tpProducto.Controls.Add(this.label8);
            this.tpProducto.Location = new System.Drawing.Point(4, 24);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Size = new System.Drawing.Size(561, 428);
            this.tpProducto.TabIndex = 5;
            this.tpProducto.Text = "Nuevo producto";
            this.tpProducto.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(208, 111);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(249, 56);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(181, 353);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(189, 47);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "Añadir al inventario";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(208, 269);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(142, 23);
            this.numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(208, 190);
            this.numericUpDown1.Maximum = new decimal(new int[] {200, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(142, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // txtNuevoL
            // 
            this.txtNuevoL.Location = new System.Drawing.Point(208, 51);
            this.txtNuevoL.Name = "txtNuevoL";
            this.txtNuevoL.Size = new System.Drawing.Size(249, 23);
            this.txtNuevoL.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(56, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 39);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ordenar unidades:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(56, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = "Precio del artículo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(56, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 36);
            this.label9.TabIndex = 1;
            this.label9.Text = "Descripción del artículo:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(56, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre del libro:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpPedidos
            // 
            this.tpPedidos.Controls.Add(this.dataGridView3);
            this.tpPedidos.Location = new System.Drawing.Point(4, 22);
            this.tpPedidos.Name = "tpPedidos";
            this.tpPedidos.Size = new System.Drawing.Size(561, 430);
            this.tpPedidos.TabIndex = 4;
            this.tpPedidos.Text = "Registro de pedidos";
            this.tpPedidos.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(560, 423);
            this.dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpCrear.ResumeLayout(false);
            this.tpCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tpUsuarios.ResumeLayout(false);
            this.tpUsuarios.PerformLayout();
            this.tpInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.tpProducto.ResumeLayout(false);
            this.tpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            this.tpPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.TabPage tpInventario;
        private System.Windows.Forms.TabPage tpPedidos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tpProducto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radActivo;
        private System.Windows.Forms.RadioButton radInactivo;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.TextBox txtNuevoL;
    }
}