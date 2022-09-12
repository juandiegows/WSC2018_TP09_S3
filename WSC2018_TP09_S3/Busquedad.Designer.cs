namespace WSC2018_TP09_S3
{
    partial class Busquedad
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
            this.btnAplicar = new System.Windows.Forms.Button();
            this.dtRegreso = new System.Windows.Forms.DateTimePicker();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.rbIda = new System.Windows.Forms.RadioButton();
            this.rbRetorno = new System.Windows.Forms.RadioButton();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbCabina = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblRegreso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.cb3diasSalida = new System.Windows.Forms.CheckBox();
            this.PRegreso = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRegreso = new System.Windows.Forms.DataGridView();
            this.cbRegreso = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.nudPasaje = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.PRegreso.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegreso)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasaje)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.dtRegreso);
            this.groupBox1.Controls.Add(this.dtSalida);
            this.groupBox1.Controls.Add(this.rbIda);
            this.groupBox1.Controls.Add(this.rbRetorno);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.cmbCabina);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.lblRegreso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramentros de busquedad";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.ForeColor = System.Drawing.Color.Green;
            this.btnAplicar.Location = new System.Drawing.Point(654, 182);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(103, 40);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // dtRegreso
            // 
            this.dtRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRegreso.Location = new System.Drawing.Point(497, 136);
            this.dtRegreso.Name = "dtRegreso";
            this.dtRegreso.Size = new System.Drawing.Size(227, 27);
            this.dtRegreso.TabIndex = 3;
            // 
            // dtSalida
            // 
            this.dtSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalida.Location = new System.Drawing.Point(123, 140);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(227, 27);
            this.dtSalida.TabIndex = 3;
            // 
            // rbIda
            // 
            this.rbIda.AutoSize = true;
            this.rbIda.Location = new System.Drawing.Point(464, 96);
            this.rbIda.Name = "rbIda";
            this.rbIda.Size = new System.Drawing.Size(88, 25);
            this.rbIda.TabIndex = 2;
            this.rbIda.Text = "Solo ida\r\n";
            this.rbIda.UseVisualStyleBackColor = true;
            // 
            // rbRetorno
            // 
            this.rbRetorno.AutoSize = true;
            this.rbRetorno.Checked = true;
            this.rbRetorno.Location = new System.Drawing.Point(370, 96);
            this.rbRetorno.Name = "rbRetorno";
            this.rbRetorno.Size = new System.Drawing.Size(90, 25);
            this.rbRetorno.TabIndex = 2;
            this.rbRetorno.TabStop = true;
            this.rbRetorno.Text = "Retorno";
            this.rbRetorno.UseVisualStyleBackColor = true;
            this.rbRetorno.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(440, 42);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(227, 29);
            this.cmbDestino.TabIndex = 1;
            // 
            // cmbCabina
            // 
            this.cmbCabina.FormattingEnabled = true;
            this.cmbCabina.Location = new System.Drawing.Point(123, 92);
            this.cmbCabina.Name = "cmbCabina";
            this.cmbCabina.Size = new System.Drawing.Size(227, 29);
            this.cmbCabina.TabIndex = 1;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(123, 42);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(227, 29);
            this.cmbOrigen.TabIndex = 1;
            // 
            // lblRegreso
            // 
            this.lblRegreso.AutoSize = true;
            this.lblRegreso.Location = new System.Drawing.Point(366, 140);
            this.lblRegreso.Name = "lblRegreso";
            this.lblRegreso.Size = new System.Drawing.Size(125, 21);
            this.lblRegreso.TabIndex = 0;
            this.lblRegreso.Text = "Fecha Regreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha Salida\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo cabina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cb3diasSalida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 221);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSalida);
            this.groupBox2.Location = new System.Drawing.Point(11, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.groupBox2.Size = new System.Drawing.Size(746, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de vuelo de salida";
            // 
            // dgvSalida
            // 
            this.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalida.Location = new System.Drawing.Point(10, 30);
            this.dgvSalida.MultiSelect = false;
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalida.Size = new System.Drawing.Size(716, 150);
            this.dgvSalida.TabIndex = 0;
            // 
            // cb3diasSalida
            // 
            this.cb3diasSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb3diasSalida.AutoSize = true;
            this.cb3diasSalida.Location = new System.Drawing.Point(482, 6);
            this.cb3diasSalida.Name = "cb3diasSalida";
            this.cb3diasSalida.Size = new System.Drawing.Size(275, 25);
            this.cb3diasSalida.TabIndex = 0;
            this.cb3diasSalida.Text = "Visualizar 3 dias antes y después";
            this.cb3diasSalida.UseVisualStyleBackColor = true;
            this.cb3diasSalida.CheckedChanged += new System.EventHandler(this.cb3diasSalida_CheckedChanged);
            // 
            // PRegreso
            // 
            this.PRegreso.Controls.Add(this.groupBox3);
            this.PRegreso.Controls.Add(this.cbRegreso);
            this.PRegreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.PRegreso.Location = new System.Drawing.Point(10, 459);
            this.PRegreso.Name = "PRegreso";
            this.PRegreso.Size = new System.Drawing.Size(763, 221);
            this.PRegreso.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvRegreso);
            this.groupBox3.Location = new System.Drawing.Point(11, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.groupBox3.Size = new System.Drawing.Size(746, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de vuelo de regreso";
            // 
            // dgvRegreso
            // 
            this.dgvRegreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegreso.Location = new System.Drawing.Point(10, 30);
            this.dgvRegreso.MultiSelect = false;
            this.dgvRegreso.Name = "dgvRegreso";
            this.dgvRegreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegreso.Size = new System.Drawing.Size(716, 150);
            this.dgvRegreso.TabIndex = 1;
            // 
            // cbRegreso
            // 
            this.cbRegreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRegreso.AutoSize = true;
            this.cbRegreso.Location = new System.Drawing.Point(482, 3);
            this.cbRegreso.Name = "cbRegreso";
            this.cbRegreso.Size = new System.Drawing.Size(275, 25);
            this.cbRegreso.TabIndex = 0;
            this.cbRegreso.Text = "Visualizar 3 dias antes y después";
            this.cbRegreso.UseVisualStyleBackColor = true;
            this.cbRegreso.CheckedChanged += new System.EventHandler(this.cbRegreso_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 680);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 162);
            this.panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnReservar);
            this.groupBox4.Controls.Add(this.nudPasaje);
            this.groupBox4.Location = new System.Drawing.Point(99, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 103);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Confirmacion de reserva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pasajero";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.Green;
            this.btnReservar.Location = new System.Drawing.Point(271, 41);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(173, 40);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reserva Vuelo";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // nudPasaje
            // 
            this.nudPasaje.Location = new System.Drawing.Point(24, 49);
            this.nudPasaje.Name = "nudPasaje";
            this.nudPasaje.Size = new System.Drawing.Size(63, 27);
            this.nudPasaje.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(654, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Busquedad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PRegreso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Busquedad";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de vuelo";
            this.Load += new System.EventHandler(this.Busquedad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.PRegreso.ResumeLayout(false);
            this.PRegreso.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegreso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.DateTimePicker dtRegreso;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.RadioButton rbIda;
        private System.Windows.Forms.RadioButton rbRetorno;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbCabina;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblRegreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb3diasSalida;
        private System.Windows.Forms.Panel PRegreso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbRegreso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPasaje;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.DataGridView dgvRegreso;
    }
}

