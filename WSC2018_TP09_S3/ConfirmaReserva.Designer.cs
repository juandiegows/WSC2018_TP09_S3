namespace WSC2018_TP09_S3
{
    partial class ConfirmaReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrigenD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDestinoD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCabinaD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaD = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVueloD = new System.Windows.Forms.Label();
            this.GBRegreso = new System.Windows.Forms.GroupBox();
            this.lblVueloS = new System.Windows.Forms.Label();
            this.lblFechaS = new System.Windows.Forms.Label();
            this.lblCabinaS = new System.Windows.Forms.Label();
            this.lblDestinoS = new System.Windows.Forms.Label();
            this.lblOrigenS = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DTUser = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.OpenFileJD = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GBRegreso.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVueloD);
            this.groupBox1.Controls.Add(this.lblFechaD);
            this.groupBox1.Controls.Add(this.lblCabinaD);
            this.groupBox1.Controls.Add(this.lblDestinoD);
            this.groupBox1.Controls.Add(this.lblOrigenD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de vuelo de salida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblOrigenD
            // 
            this.lblOrigenD.AutoSize = true;
            this.lblOrigenD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenD.Location = new System.Drawing.Point(85, 44);
            this.lblOrigenD.Name = "lblOrigenD";
            this.lblOrigenD.Size = new System.Drawing.Size(102, 19);
            this.lblOrigenD.TabIndex = 0;
            this.lblOrigenD.Text = "Tipo cabina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destino";
            // 
            // lblDestinoD
            // 
            this.lblDestinoD.AutoSize = true;
            this.lblDestinoD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoD.Location = new System.Drawing.Point(285, 44);
            this.lblDestinoD.Name = "lblDestinoD";
            this.lblDestinoD.Size = new System.Drawing.Size(102, 19);
            this.lblDestinoD.TabIndex = 0;
            this.lblDestinoD.Text = "Tipo cabina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo Cabina";
            // 
            // lblCabinaD
            // 
            this.lblCabinaD.AutoSize = true;
            this.lblCabinaD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinaD.Location = new System.Drawing.Point(522, 44);
            this.lblCabinaD.Name = "lblCabinaD";
            this.lblCabinaD.Size = new System.Drawing.Size(102, 19);
            this.lblCabinaD.TabIndex = 0;
            this.lblCabinaD.Text = "Tipo cabina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha";
            // 
            // lblFechaD
            // 
            this.lblFechaD.AutoSize = true;
            this.lblFechaD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaD.Location = new System.Drawing.Point(109, 98);
            this.lblFechaD.Name = "lblFechaD";
            this.lblFechaD.Size = new System.Drawing.Size(102, 19);
            this.lblFechaD.TabIndex = 0;
            this.lblFechaD.Text = "Tipo cabina";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "N° Vuelo";
            // 
            // lblVueloD
            // 
            this.lblVueloD.AutoSize = true;
            this.lblVueloD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVueloD.Location = new System.Drawing.Point(363, 98);
            this.lblVueloD.Name = "lblVueloD";
            this.lblVueloD.Size = new System.Drawing.Size(102, 19);
            this.lblVueloD.TabIndex = 0;
            this.lblVueloD.Text = "Tipo cabina";
            // 
            // GBRegreso
            // 
            this.GBRegreso.Controls.Add(this.lblVueloS);
            this.GBRegreso.Controls.Add(this.lblFechaS);
            this.GBRegreso.Controls.Add(this.lblCabinaS);
            this.GBRegreso.Controls.Add(this.lblDestinoS);
            this.GBRegreso.Controls.Add(this.lblOrigenS);
            this.GBRegreso.Controls.Add(this.label16);
            this.GBRegreso.Controls.Add(this.label17);
            this.GBRegreso.Controls.Add(this.label18);
            this.GBRegreso.Controls.Add(this.label19);
            this.GBRegreso.Controls.Add(this.label20);
            this.GBRegreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBRegreso.Location = new System.Drawing.Point(0, 144);
            this.GBRegreso.Name = "GBRegreso";
            this.GBRegreso.Size = new System.Drawing.Size(783, 144);
            this.GBRegreso.TabIndex = 2;
            this.GBRegreso.TabStop = false;
            this.GBRegreso.Text = "Detalle de vuelo de regreso";
            // 
            // lblVueloS
            // 
            this.lblVueloS.AutoSize = true;
            this.lblVueloS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVueloS.Location = new System.Drawing.Point(363, 98);
            this.lblVueloS.Name = "lblVueloS";
            this.lblVueloS.Size = new System.Drawing.Size(102, 19);
            this.lblVueloS.TabIndex = 0;
            this.lblVueloS.Text = "Tipo cabina";
            // 
            // lblFechaS
            // 
            this.lblFechaS.AutoSize = true;
            this.lblFechaS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaS.Location = new System.Drawing.Point(109, 98);
            this.lblFechaS.Name = "lblFechaS";
            this.lblFechaS.Size = new System.Drawing.Size(102, 19);
            this.lblFechaS.TabIndex = 0;
            this.lblFechaS.Text = "Tipo cabina";
            // 
            // lblCabinaS
            // 
            this.lblCabinaS.AutoSize = true;
            this.lblCabinaS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinaS.Location = new System.Drawing.Point(522, 44);
            this.lblCabinaS.Name = "lblCabinaS";
            this.lblCabinaS.Size = new System.Drawing.Size(102, 19);
            this.lblCabinaS.TabIndex = 0;
            this.lblCabinaS.Text = "Tipo cabina";
            // 
            // lblDestinoS
            // 
            this.lblDestinoS.AutoSize = true;
            this.lblDestinoS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoS.Location = new System.Drawing.Point(285, 44);
            this.lblDestinoS.Name = "lblDestinoS";
            this.lblDestinoS.Size = new System.Drawing.Size(102, 19);
            this.lblDestinoS.TabIndex = 0;
            this.lblDestinoS.Text = "Tipo cabina";
            // 
            // lblOrigenS
            // 
            this.lblOrigenS.AutoSize = true;
            this.lblOrigenS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenS.Location = new System.Drawing.Point(85, 44);
            this.lblOrigenS.Name = "lblOrigenS";
            this.lblOrigenS.Size = new System.Drawing.Size(102, 19);
            this.lblOrigenS.TabIndex = 0;
            this.lblOrigenS.Text = "Tipo cabina";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "N° Vuelo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Fecha";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(402, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tipo Cabina";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(202, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Destino";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 21);
            this.label20.TabIndex = 0;
            this.label20.Text = "Origen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.btnBuscarFoto);
            this.groupBox3.Controls.Add(this.PBImagen);
            this.groupBox3.Controls.Add(this.dtFecha);
            this.groupBox3.Controls.Add(this.cmbPais);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtPassport);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de pasajero";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.DTUser);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(783, 173);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de pasajero";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 722);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 74);
            this.panel1.TabIndex = 5;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Green;
            this.btnRegresar.Location = new System.Drawing.Point(162, 17);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(225, 40);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar a buscar Vuelo";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(393, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DTUser
            // 
            this.DTUser.AllowUserToAddRows = false;
            this.DTUser.AllowUserToDeleteRows = false;
            this.DTUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTUser.Location = new System.Drawing.Point(18, 33);
            this.DTUser.Name = "DTUser";
            this.DTUser.ReadOnly = true;
            this.DTUser.Size = new System.Drawing.Size(762, 97);
            this.DTUser.TabIndex = 0;
            this.DTUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTUser_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellidos";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(428, 33);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(235, 27);
            this.txtApellido.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero Pasaporte";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(176, 73);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(235, 27);
            this.txtPassport.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pais";
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(424, 104);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(194, 29);
            this.cmbPais.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(104, 120);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(235, 27);
            this.txtTelefono.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fecha Nacimiento";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(20, 208);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(260, 27);
            this.dtFecha.TabIndex = 3;
            // 
            // PBImagen
            // 
            this.PBImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PBImagen.Location = new System.Drawing.Point(624, 63);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(129, 140);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 4;
            this.PBImagen.TabStop = false;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFoto.ForeColor = System.Drawing.Color.Green;
            this.btnBuscarFoto.Location = new System.Drawing.Point(621, 220);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(132, 33);
            this.btnBuscarFoto.TabIndex = 7;
            this.btnBuscarFoto.Text = "Buscar Foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // OpenFileJD
            // 
            this.OpenFileJD.FileName = "openFileDialog1";
            this.OpenFileJD.Filter = "Image|*.jpg";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Green;
            this.btnAgregar.Location = new System.Drawing.Point(353, 208);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(239, 33);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Pasajero";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(558, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar Pasajero";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ConfirmaReserva
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GBRegreso);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConfirmaReserva";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirma Reserva";
            this.Load += new System.EventHandler(this.ConfirmaReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBRegreso.ResumeLayout(false);
            this.GBRegreso.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrigenD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVueloD;
        private System.Windows.Forms.Label lblFechaD;
        private System.Windows.Forms.Label lblCabinaD;
        private System.Windows.Forms.Label lblDestinoD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBRegreso;
        private System.Windows.Forms.Label lblVueloS;
        private System.Windows.Forms.Label lblFechaS;
        private System.Windows.Forms.Label lblCabinaS;
        private System.Windows.Forms.Label lblDestinoS;
        private System.Windows.Forms.Label lblOrigenS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DTUser;
        private System.Windows.Forms.OpenFileDialog OpenFileJD;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button3;
    }
}