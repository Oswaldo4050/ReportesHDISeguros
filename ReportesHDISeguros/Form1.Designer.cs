namespace ReportesHDISeguros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPoliza = new System.Windows.Forms.DataGridView();
            this.btnBuscarPoliza = new System.Windows.Forms.Button();
            this.txtPoliza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreAjustador = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreQuienReporta = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.dtpFechaOcurrencia = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvConfirmacion = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpFechaRegistroC = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroSIniestroC = new System.Windows.Forms.TextBox();
            this.txtNombreAjustadorC = new System.Windows.Forms.TextBox();
            this.cbConfirmo = new System.Windows.Forms.CheckBox();
            this.btnGuardarConfirmo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda de Poliza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPoliza);
            this.panel1.Controls.Add(this.btnBuscarPoliza);
            this.panel1.Controls.Add(this.txtPoliza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnBuscarNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1021, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 318);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvPoliza
            // 
            this.dgvPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliza.Location = new System.Drawing.Point(20, 168);
            this.dgvPoliza.Name = "dgvPoliza";
            this.dgvPoliza.RowHeadersWidth = 51;
            this.dgvPoliza.RowTemplate.Height = 24;
            this.dgvPoliza.Size = new System.Drawing.Size(931, 121);
            this.dgvPoliza.TabIndex = 6;
            // 
            // btnBuscarPoliza
            // 
            this.btnBuscarPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPoliza.Location = new System.Drawing.Point(774, 92);
            this.btnBuscarPoliza.Name = "btnBuscarPoliza";
            this.btnBuscarPoliza.Size = new System.Drawing.Size(103, 32);
            this.btnBuscarPoliza.TabIndex = 5;
            this.btnBuscarPoliza.Text = "Buscar";
            this.btnBuscarPoliza.UseVisualStyleBackColor = true;
            this.btnBuscarPoliza.Click += new System.EventHandler(this.btnBuscarPoliza_Click);
            // 
            // txtPoliza
            // 
            this.txtPoliza.Location = new System.Drawing.Point(534, 95);
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.Size = new System.Drawing.Size(213, 22);
            this.txtPoliza.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Poliza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.Location = new System.Drawing.Point(326, 88);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(103, 33);
            this.btnBuscarNombre.TabIndex = 1;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvReportes);
            this.panel2.Controls.Add(this.txtNombreAjustador);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.txtPlacas);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtNombreQuienReporta);
            this.panel2.Controls.Add(this.txtLugar);
            this.panel2.Controls.Add(this.dtpFechaOcurrencia);
            this.panel2.Controls.Add(this.txtNumeroPoliza);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(28, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 851);
            this.panel2.TabIndex = 2;
            // 
            // txtNombreAjustador
            // 
            this.txtNombreAjustador.Location = new System.Drawing.Point(226, 317);
            this.txtNombreAjustador.Name = "txtNombreAjustador";
            this.txtNombreAjustador.Size = new System.Drawing.Size(738, 22);
            this.txtNombreAjustador.TabIndex = 23;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(174, 468);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(790, 168);
            this.txtObservaciones.TabIndex = 22;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(690, 155);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(274, 22);
            this.txtColor.TabIndex = 21;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(690, 210);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(274, 22);
            this.txtPlacas.TabIndex = 20;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(253, 375);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(711, 62);
            this.txtDescripcion.TabIndex = 19;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(117, 267);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(303, 22);
            this.txtCorreo.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(255, 210);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(282, 22);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtNombreQuienReporta
            // 
            this.txtNombreQuienReporta.Location = new System.Drawing.Point(269, 155);
            this.txtNombreQuienReporta.Name = "txtNombreQuienReporta";
            this.txtNombreQuienReporta.Size = new System.Drawing.Size(268, 22);
            this.txtNombreQuienReporta.TabIndex = 16;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(690, 267);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(274, 22);
            this.txtLugar.TabIndex = 15;
            // 
            // dtpFechaOcurrencia
            // 
            this.dtpFechaOcurrencia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaOcurrencia.Location = new System.Drawing.Point(617, 70);
            this.dtpFechaOcurrencia.Name = "dtpFechaOcurrencia";
            this.dtpFechaOcurrencia.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaOcurrencia.TabIndex = 14;
            this.dtpFechaOcurrencia.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(159, 73);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(138, 22);
            this.txtNumeroPoliza.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(15, 555);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 46);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(2, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 22);
            this.label15.TabIndex = 11;
            this.label15.Text = "Nombre de Ajustador:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 22);
            this.label14.TabIndex = 10;
            this.label14.Text = "Observaciones:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(611, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "Color:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Correo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(595, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Placas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Descripcion del siniestro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Telefono de contacto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre de quien reporta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lugar de Ocurrencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha y Hora de Ocurrencia:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "NumeroPoliza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Captura de Reporte";
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(13, 651);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 24;
            this.dgvReportes.Size = new System.Drawing.Size(951, 186);
            this.dgvReportes.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 32);
            this.label16.TabIndex = 3;
            this.label16.Text = "HDI Seguros";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGuardarConfirmo);
            this.panel3.Controls.Add(this.cbConfirmo);
            this.panel3.Controls.Add(this.txtNombreAjustadorC);
            this.panel3.Controls.Add(this.txtNumeroSIniestroC);
            this.panel3.Controls.Add(this.dtpFechaRegistroC);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.dgvConfirmacion);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(1021, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 513);
            this.panel3.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(344, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = "Confirmación del Asegurado";
            // 
            // dgvConfirmacion
            // 
            this.dgvConfirmacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmacion.Location = new System.Drawing.Point(20, 251);
            this.dgvConfirmacion.Name = "dgvConfirmacion";
            this.dgvConfirmacion.RowHeadersWidth = 51;
            this.dgvConfirmacion.RowTemplate.Height = 24;
            this.dgvConfirmacion.Size = new System.Drawing.Size(926, 248);
            this.dgvConfirmacion.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 22);
            this.label18.TabIndex = 2;
            this.label18.Text = "Fecha de Registro:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(20, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 22);
            this.label19.TabIndex = 3;
            this.label19.Text = "Numero de Siniestro:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(466, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(209, 22);
            this.label20.TabIndex = 4;
            this.label20.Text = "Nombre del Ajustador:";
            // 
            // dtpFechaRegistroC
            // 
            this.dtpFechaRegistroC.Location = new System.Drawing.Point(237, 68);
            this.dtpFechaRegistroC.Name = "dtpFechaRegistroC";
            this.dtpFechaRegistroC.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaRegistroC.TabIndex = 6;
            // 
            // txtNumeroSIniestroC
            // 
            this.txtNumeroSIniestroC.Location = new System.Drawing.Point(246, 159);
            this.txtNumeroSIniestroC.Name = "txtNumeroSIniestroC";
            this.txtNumeroSIniestroC.Size = new System.Drawing.Size(224, 22);
            this.txtNumeroSIniestroC.TabIndex = 7;
            // 
            // txtNombreAjustadorC
            // 
            this.txtNombreAjustadorC.Location = new System.Drawing.Point(698, 70);
            this.txtNombreAjustadorC.Name = "txtNombreAjustadorC";
            this.txtNombreAjustadorC.Size = new System.Drawing.Size(206, 22);
            this.txtNombreAjustadorC.TabIndex = 8;
            // 
            // cbConfirmo
            // 
            this.cbConfirmo.AutoSize = true;
            this.cbConfirmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirmo.Location = new System.Drawing.Point(534, 154);
            this.cbConfirmo.Name = "cbConfirmo";
            this.cbConfirmo.Size = new System.Drawing.Size(121, 29);
            this.cbConfirmo.TabIndex = 9;
            this.cbConfirmo.Text = "Confirmó";
            this.cbConfirmo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarConfirmo
            // 
            this.btnGuardarConfirmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConfirmo.Location = new System.Drawing.Point(753, 142);
            this.btnGuardarConfirmo.Name = "btnGuardarConfirmo";
            this.btnGuardarConfirmo.Size = new System.Drawing.Size(124, 56);
            this.btnGuardarConfirmo.TabIndex = 10;
            this.btnGuardarConfirmo.Text = "Guardar";
            this.btnGuardarConfirmo.UseVisualStyleBackColor = true;
            this.btnGuardarConfirmo.Click += new System.EventHandler(this.btnGuardarConfirmo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1000);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliza)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPoliza;
        private System.Windows.Forms.TextBox txtPoliza;
        private System.Windows.Forms.DataGridView dgvPoliza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroPoliza;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaOcurrencia;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreQuienReporta;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtNombreAjustador;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvConfirmacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreAjustadorC;
        private System.Windows.Forms.TextBox txtNumeroSIniestroC;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistroC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbConfirmo;
        private System.Windows.Forms.Button btnGuardarConfirmo;
    }
}

