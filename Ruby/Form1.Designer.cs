
namespace Ruby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_delete_imagen = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.histogramGreen = new AForge.Controls.Histogram();
            this.histogramBlue = new AForge.Controls.Histogram();
            this.histogramaRed = new AForge.Controls.Histogram();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_filtros_editar = new System.Windows.Forms.ComboBox();
            this.btn_save_imagen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_imagen_resultado = new System.Windows.Forms.PictureBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_imagen_original = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_delete_video = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_video_resultado = new System.Windows.Forms.PictureBox();
            this.tb_ruta_Video = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_video_original = new System.Windows.Forms.PictureBox();
            this.cb_filtro_videos = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pb_camara = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_delete_web = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_desact_rostro = new System.Windows.Forms.Button();
            this.btn_rostro = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_save_web = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.histogramGreen1 = new AForge.Controls.Histogram();
            this.histogramBlue1 = new AForge.Controls.Histogram();
            this.histogramaRed1 = new AForge.Controls.Histogram();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCountMov = new System.Windows.Forms.Label();
            this.btn_desactivar_mov = new System.Windows.Forms.Button();
            this.btn_detector_mov = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_filtro_camara = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_activar = new System.Windows.Forms.Button();
            this.cb_webcam = new System.Windows.Forms.ComboBox();
            this.pb_camara_resultado = new System.Windows.Forms.PictureBox();
            this.pb_camara_actual = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_original)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video_original)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara_actual)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-8, -4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3435, 1800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Ruby.Properties.Resources.fondodegradado;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.btn_delete_imagen);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.histogramGreen);
            this.tabPage1.Controls.Add(this.histogramBlue);
            this.tabPage1.Controls.Add(this.histogramaRed);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cb_filtros_editar);
            this.tabPage1.Controls.Add(this.btn_save_imagen);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pb_imagen_resultado);
            this.tabPage1.Controls.Add(this.txtruta);
            this.tabPage1.Controls.Add(this.btn_archivo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pb_imagen_original);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(10, 69);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(3415, 1721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       Editar imagen        ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.Blue;
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(2903, 773);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 53);
            this.label28.TabIndex = 195;
            this.label28.Text = "b";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.Green;
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(2903, 462);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(55, 53);
            this.label29.TabIndex = 194;
            this.label29.Text = "g";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(2903, 148);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 53);
            this.label30.TabIndex = 193;
            this.label30.Text = "r";
            // 
            // btn_delete_imagen
            // 
            this.btn_delete_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_delete_imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_imagen.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_imagen.ForeColor = System.Drawing.Color.White;
            this.btn_delete_imagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_delete_imagen.Location = new System.Drawing.Point(2781, 1058);
            this.btn_delete_imagen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_delete_imagen.Name = "btn_delete_imagen";
            this.btn_delete_imagen.Size = new System.Drawing.Size(84, 82);
            this.btn_delete_imagen.TabIndex = 192;
            this.btn_delete_imagen.Text = "🗑";
            this.btn_delete_imagen.UseVisualStyleBackColor = false;
            this.btn_delete_imagen.Click += new System.EventHandler(this.btn_delete_imagen_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(2957, 1209);
            this.label27.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(155, 37);
            this.label27.TabIndex = 191;
            this.label27.Text = "imagen:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(2047, 1116);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(224, 53);
            this.label26.TabIndex = 189;
            this.label26.Text = "Filtros";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(2023, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(308, 53);
            this.label25.TabIndex = 185;
            this.label25.Text = "Resultado";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(666, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(237, 53);
            this.label24.TabIndex = 184;
            this.label24.Text = "Original";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(2957, 1209);
            this.label22.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 37);
            this.label22.TabIndex = 183;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(2903, 773);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 53);
            this.label18.TabIndex = 182;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(2903, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 53);
            this.label17.TabIndex = 181;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(2903, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 53);
            this.label13.TabIndex = 180;
            // 
            // histogramGreen
            // 
            this.histogramGreen.BackColor = System.Drawing.Color.White;
            this.histogramGreen.Cursor = System.Windows.Forms.Cursors.No;
            this.histogramGreen.Location = new System.Drawing.Point(2912, 462);
            this.histogramGreen.Name = "histogramGreen";
            this.histogramGreen.Size = new System.Drawing.Size(446, 275);
            this.histogramGreen.TabIndex = 179;
            this.histogramGreen.Values = null;
            // 
            // histogramBlue
            // 
            this.histogramBlue.BackColor = System.Drawing.Color.White;
            this.histogramBlue.Cursor = System.Windows.Forms.Cursors.No;
            this.histogramBlue.Location = new System.Drawing.Point(2912, 773);
            this.histogramBlue.Name = "histogramBlue";
            this.histogramBlue.Size = new System.Drawing.Size(446, 275);
            this.histogramBlue.TabIndex = 178;
            this.histogramBlue.Values = null;
            // 
            // histogramaRed
            // 
            this.histogramaRed.BackColor = System.Drawing.Color.White;
            this.histogramaRed.Color = System.Drawing.Color.White;
            this.histogramaRed.Cursor = System.Windows.Forms.Cursors.No;
            this.histogramaRed.Location = new System.Drawing.Point(2912, 148);
            this.histogramaRed.Name = "histogramaRed";
            this.histogramaRed.Size = new System.Drawing.Size(446, 275);
            this.histogramaRed.TabIndex = 177;
            this.histogramaRed.Values = null;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(2076, 1111);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 53);
            this.label14.TabIndex = 176;
            // 
            // cb_filtros_editar
            // 
            this.cb_filtros_editar.BackColor = System.Drawing.Color.White;
            this.cb_filtros_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_filtros_editar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtros_editar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_filtros_editar.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold);
            this.cb_filtros_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.cb_filtros_editar.FormattingEnabled = true;
            this.cb_filtros_editar.Items.AddRange(new object[] {
            "Blanco y Negro",
            "Sepia",
            "Negativo",
            "RosaAzulado",
            "Umbral",
            "Pixelado",
            "Ruido sal y pimienta",
            "Limpiar filtro (s)"});
            this.cb_filtros_editar.Location = new System.Drawing.Point(1916, 1190);
            this.cb_filtros_editar.Margin = new System.Windows.Forms.Padding(5);
            this.cb_filtros_editar.Name = "cb_filtros_editar";
            this.cb_filtros_editar.Size = new System.Drawing.Size(526, 38);
            this.cb_filtros_editar.TabIndex = 175;
            this.cb_filtros_editar.SelectedIndexChanged += new System.EventHandler(this.cb_filtros_editar_SelectedIndexChanged);
            // 
            // btn_save_imagen
            // 
            this.btn_save_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_save_imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_imagen.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_imagen.ForeColor = System.Drawing.Color.White;
            this.btn_save_imagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save_imagen.Location = new System.Drawing.Point(2912, 1263);
            this.btn_save_imagen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_save_imagen.Name = "btn_save_imagen";
            this.btn_save_imagen.Size = new System.Drawing.Size(247, 82);
            this.btn_save_imagen.TabIndex = 174;
            this.btn_save_imagen.Text = "Guardar";
            this.btn_save_imagen.UseVisualStyleBackColor = false;
            this.btn_save_imagen.Click += new System.EventHandler(this.btn_save_imagen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(2023, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 53);
            this.label6.TabIndex = 173;
            // 
            // pb_imagen_resultado
            // 
            this.pb_imagen_resultado.BackColor = System.Drawing.Color.Transparent;
            this.pb_imagen_resultado.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_imagen_resultado.InitialImage = null;
            this.pb_imagen_resultado.Location = new System.Drawing.Point(1465, 148);
            this.pb_imagen_resultado.Name = "pb_imagen_resultado";
            this.pb_imagen_resultado.Size = new System.Drawing.Size(1400, 900);
            this.pb_imagen_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen_resultado.TabIndex = 172;
            this.pb_imagen_resultado.TabStop = false;
            // 
            // txtruta
            // 
            this.txtruta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtruta.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtruta.Enabled = false;
            this.txtruta.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(432, 1266);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(1133, 37);
            this.txtruta.TabIndex = 171;
            // 
            // btn_archivo
            // 
            this.btn_archivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_archivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_archivo.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archivo.ForeColor = System.Drawing.Color.White;
            this.btn_archivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_archivo.Location = new System.Drawing.Point(21, 1242);
            this.btn_archivo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(372, 82);
            this.btn_archivo.TabIndex = 170;
            this.btn_archivo.Text = "Seleccionar imagen";
            this.btn_archivo.UseVisualStyleBackColor = false;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(666, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 53);
            this.label1.TabIndex = 169;
            // 
            // pb_imagen_original
            // 
            this.pb_imagen_original.BackColor = System.Drawing.Color.Transparent;
            this.pb_imagen_original.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_imagen_original.InitialImage = null;
            this.pb_imagen_original.Location = new System.Drawing.Point(20, 148);
            this.pb_imagen_original.Name = "pb_imagen_original";
            this.pb_imagen_original.Size = new System.Drawing.Size(1400, 900);
            this.pb_imagen_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagen_original.TabIndex = 168;
            this.pb_imagen_original.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Ruby.Properties.Resources.fondodegradado;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btn_pause);
            this.tabPage2.Controls.Add(this.btn_delete_video);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.btn_video);
            this.tabPage2.Controls.Add(this.btn_play);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pb_video_resultado);
            this.tabPage2.Controls.Add(this.tb_ruta_Video);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pb_video_original);
            this.tabPage2.Controls.Add(this.cb_filtro_videos);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(10, 69);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(3415, 1721);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    Editar video    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.White;
            this.btn_pause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_pause.Location = new System.Drawing.Point(1073, 1397);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(60, 60);
            this.btn_pause.TabIndex = 194;
            this.btn_pause.Text = "⏸";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_delete_video
            // 
            this.btn_delete_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_delete_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_video.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_video.ForeColor = System.Drawing.Color.White;
            this.btn_delete_video.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_delete_video.Location = new System.Drawing.Point(2407, 148);
            this.btn_delete_video.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_delete_video.Name = "btn_delete_video";
            this.btn_delete_video.Size = new System.Drawing.Size(84, 82);
            this.btn_delete_video.TabIndex = 193;
            this.btn_delete_video.Text = "🗑";
            this.btn_delete_video.UseVisualStyleBackColor = false;
            this.btn_delete_video.Click += new System.EventHandler(this.btn_delete_video_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(2739, 898);
            this.label21.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(186, 53);
            this.label21.TabIndex = 191;
            this.label21.Text = "Video:";
            // 
            // btn_video
            // 
            this.btn_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_video.ForeColor = System.Drawing.Color.White;
            this.btn_video.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_video.Location = new System.Drawing.Point(2361, 1287);
            this.btn_video.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(355, 82);
            this.btn_video.TabIndex = 190;
            this.btn_video.Text = "Seleccionar video";
            this.btn_video.UseVisualStyleBackColor = false;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click_1);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_play.Location = new System.Drawing.Point(1149, 1397);
            this.btn_play.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(60, 60);
            this.btn_play.TabIndex = 189;
            this.btn_play.Text = "▶";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(2752, 589);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 53);
            this.label2.TabIndex = 188;
            this.label2.Text = "Filtros";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(2729, 969);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 82);
            this.button2.TabIndex = 187;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1006, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 53);
            this.label3.TabIndex = 186;
            this.label3.Text = "Resultado";
            // 
            // pb_video_resultado
            // 
            this.pb_video_resultado.BackColor = System.Drawing.Color.Transparent;
            this.pb_video_resultado.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_video_resultado.Location = new System.Drawing.Point(20, 148);
            this.pb_video_resultado.Name = "pb_video_resultado";
            this.pb_video_resultado.Size = new System.Drawing.Size(2317, 1219);
            this.pb_video_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_video_resultado.TabIndex = 185;
            this.pb_video_resultado.TabStop = false;
            // 
            // tb_ruta_Video
            // 
            this.tb_ruta_Video.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ruta_Video.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_ruta_Video.Enabled = false;
            this.tb_ruta_Video.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ruta_Video.Location = new System.Drawing.Point(2361, 1397);
            this.tb_ruta_Video.Name = "tb_ruta_Video";
            this.tb_ruta_Video.ReadOnly = true;
            this.tb_ruta_Video.Size = new System.Drawing.Size(1009, 37);
            this.tb_ruta_Video.TabIndex = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(2720, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 53);
            this.label4.TabIndex = 183;
            this.label4.Text = "Original";
            // 
            // pb_video_original
            // 
            this.pb_video_original.BackColor = System.Drawing.Color.Transparent;
            this.pb_video_original.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_video_original.InitialImage = null;
            this.pb_video_original.Location = new System.Drawing.Point(2619, 132);
            this.pb_video_original.Name = "pb_video_original";
            this.pb_video_original.Size = new System.Drawing.Size(428, 233);
            this.pb_video_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_video_original.TabIndex = 182;
            this.pb_video_original.TabStop = false;
            // 
            // cb_filtro_videos
            // 
            this.cb_filtro_videos.BackColor = System.Drawing.Color.White;
            this.cb_filtro_videos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_filtro_videos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro_videos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_filtro_videos.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold);
            this.cb_filtro_videos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.cb_filtro_videos.FormattingEnabled = true;
            this.cb_filtro_videos.Items.AddRange(new object[] {
            "Gris",
            "Sepia",
            "Negativo",
            "RosaAzulado",
            "Rojizo",
            "Limpiar filtro (s)"});
            this.cb_filtro_videos.Location = new System.Drawing.Point(2592, 653);
            this.cb_filtro_videos.Margin = new System.Windows.Forms.Padding(5);
            this.cb_filtro_videos.Name = "cb_filtro_videos";
            this.cb_filtro_videos.Size = new System.Drawing.Size(526, 38);
            this.cb_filtro_videos.TabIndex = 181;
            this.cb_filtro_videos.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_videos_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Ruby.Properties.Resources.fondodegradado;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.pb_camara);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.btn_delete_web);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.btn_desact_rostro);
            this.tabPage3.Controls.Add(this.btn_rostro);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.btn_save_web);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.histogramGreen1);
            this.tabPage3.Controls.Add(this.histogramBlue1);
            this.tabPage3.Controls.Add(this.histogramaRed1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.labelCountMov);
            this.tabPage3.Controls.Add(this.btn_desactivar_mov);
            this.tabPage3.Controls.Add(this.btn_detector_mov);
            this.tabPage3.Controls.Add(this.videoSourcePlayer1);
            this.tabPage3.Controls.Add(this.btn_apagar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cb_filtro_camara);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.photo);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btn_activar);
            this.tabPage3.Controls.Add(this.cb_webcam);
            this.tabPage3.Controls.Add(this.pb_camara_resultado);
            this.tabPage3.Controls.Add(this.pb_camara_actual);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(10, 69);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(3415, 1721);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "    Cámara web    ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pb_camara
            // 
            this.pb_camara.BackColor = System.Drawing.Color.Transparent;
            this.pb_camara.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_camara.Location = new System.Drawing.Point(1465, 137);
            this.pb_camara.Name = "pb_camara";
            this.pb_camara.Size = new System.Drawing.Size(484, 302);
            this.pb_camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_camara.TabIndex = 196;
            this.pb_camara.TabStop = false;
            this.pb_camara.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1181, 1163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 38);
            this.comboBox1.TabIndex = 195;
            this.comboBox1.Visible = false;
            // 
            // btn_delete_web
            // 
            this.btn_delete_web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_delete_web.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_web.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_web.ForeColor = System.Drawing.Color.White;
            this.btn_delete_web.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_delete_web.Location = new System.Drawing.Point(2781, 1058);
            this.btn_delete_web.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_delete_web.Name = "btn_delete_web";
            this.btn_delete_web.Size = new System.Drawing.Size(84, 82);
            this.btn_delete_web.TabIndex = 194;
            this.btn_delete_web.Text = "🗑";
            this.btn_delete_web.UseVisualStyleBackColor = false;
            this.btn_delete_web.Click += new System.EventHandler(this.btn_delete_web_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(2162, 1292);
            this.label23.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(438, 37);
            this.label23.TabIndex = 193;
            this.label23.Text = "Detector de rostros:";
            // 
            // btn_desact_rostro
            // 
            this.btn_desact_rostro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_desact_rostro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desact_rostro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desact_rostro.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desact_rostro.ForeColor = System.Drawing.Color.White;
            this.btn_desact_rostro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_desact_rostro.Location = new System.Drawing.Point(2456, 1351);
            this.btn_desact_rostro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_desact_rostro.Name = "btn_desact_rostro";
            this.btn_desact_rostro.Size = new System.Drawing.Size(247, 82);
            this.btn_desact_rostro.TabIndex = 192;
            this.btn_desact_rostro.Text = "Desactivar";
            this.btn_desact_rostro.UseVisualStyleBackColor = false;
            this.btn_desact_rostro.Click += new System.EventHandler(this.btn_desact_rostro_Click);
            // 
            // btn_rostro
            // 
            this.btn_rostro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_rostro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rostro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rostro.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rostro.ForeColor = System.Drawing.Color.White;
            this.btn_rostro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_rostro.Location = new System.Drawing.Point(2174, 1351);
            this.btn_rostro.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_rostro.Name = "btn_rostro";
            this.btn_rostro.Size = new System.Drawing.Size(247, 82);
            this.btn_rostro.TabIndex = 191;
            this.btn_rostro.Text = "Activar";
            this.btn_rostro.UseVisualStyleBackColor = false;
            this.btn_rostro.Click += new System.EventHandler(this.btn_rostro_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(3148, 1300);
            this.label20.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 37);
            this.label20.TabIndex = 190;
            this.label20.Text = "imagen:";
            // 
            // btn_save_web
            // 
            this.btn_save_web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_save_web.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_web.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_web.ForeColor = System.Drawing.Color.White;
            this.btn_save_web.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_save_web.Location = new System.Drawing.Point(3113, 1356);
            this.btn_save_web.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_save_web.Name = "btn_save_web";
            this.btn_save_web.Size = new System.Drawing.Size(247, 82);
            this.btn_save_web.TabIndex = 189;
            this.btn_save_web.Text = "Guardar";
            this.btn_save_web.UseVisualStyleBackColor = false;
            this.btn_save_web.Click += new System.EventHandler(this.btn_save_web_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(2903, 773);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 53);
            this.label15.TabIndex = 188;
            this.label15.Text = "b";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(2903, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 53);
            this.label16.TabIndex = 187;
            this.label16.Text = "g";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(2903, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 53);
            this.label19.TabIndex = 186;
            this.label19.Text = "r";
            // 
            // histogramGreen1
            // 
            this.histogramGreen1.BackColor = System.Drawing.Color.White;
            this.histogramGreen1.Cursor = System.Windows.Forms.Cursors.No;
            this.histogramGreen1.Location = new System.Drawing.Point(2912, 462);
            this.histogramGreen1.Name = "histogramGreen1";
            this.histogramGreen1.Size = new System.Drawing.Size(446, 275);
            this.histogramGreen1.TabIndex = 185;
            this.histogramGreen1.Text = "histogram3";
            this.histogramGreen1.Values = null;
            // 
            // histogramBlue1
            // 
            this.histogramBlue1.BackColor = System.Drawing.Color.White;
            this.histogramBlue1.Cursor = System.Windows.Forms.Cursors.No;
            this.histogramBlue1.Location = new System.Drawing.Point(2912, 773);
            this.histogramBlue1.Name = "histogramBlue1";
            this.histogramBlue1.Size = new System.Drawing.Size(446, 275);
            this.histogramBlue1.TabIndex = 184;
            this.histogramBlue1.Text = "histogram2";
            this.histogramBlue1.Values = null;
            // 
            // histogramaRed1
            // 
            this.histogramaRed1.BackColor = System.Drawing.Color.White;
            this.histogramaRed1.Cursor = System.Windows.Forms.Cursors.No;
            this.histogramaRed1.Location = new System.Drawing.Point(2912, 148);
            this.histogramaRed1.Name = "histogramaRed1";
            this.histogramaRed1.Size = new System.Drawing.Size(446, 275);
            this.histogramaRed1.TabIndex = 183;
            this.histogramaRed1.Text = "histogram1";
            this.histogramaRed1.Values = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(1340, 1293);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(496, 37);
            this.label8.TabIndex = 159;
            this.label8.Text = "Detector de movimiento:";
            // 
            // labelCountMov
            // 
            this.labelCountMov.AutoSize = true;
            this.labelCountMov.BackColor = System.Drawing.Color.Transparent;
            this.labelCountMov.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.labelCountMov.ForeColor = System.Drawing.Color.Black;
            this.labelCountMov.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCountMov.Location = new System.Drawing.Point(1924, 1293);
            this.labelCountMov.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCountMov.Name = "labelCountMov";
            this.labelCountMov.Size = new System.Drawing.Size(40, 37);
            this.labelCountMov.TabIndex = 158;
            this.labelCountMov.Text = "0";
            // 
            // btn_desactivar_mov
            // 
            this.btn_desactivar_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_desactivar_mov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desactivar_mov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desactivar_mov.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desactivar_mov.ForeColor = System.Drawing.Color.White;
            this.btn_desactivar_mov.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_desactivar_mov.Location = new System.Drawing.Point(1678, 1351);
            this.btn_desactivar_mov.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_desactivar_mov.Name = "btn_desactivar_mov";
            this.btn_desactivar_mov.Size = new System.Drawing.Size(247, 82);
            this.btn_desactivar_mov.TabIndex = 157;
            this.btn_desactivar_mov.Text = "Desactivar";
            this.btn_desactivar_mov.UseVisualStyleBackColor = false;
            this.btn_desactivar_mov.Click += new System.EventHandler(this.btn_desactivar_mov_Click);
            // 
            // btn_detector_mov
            // 
            this.btn_detector_mov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_detector_mov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detector_mov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detector_mov.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detector_mov.ForeColor = System.Drawing.Color.White;
            this.btn_detector_mov.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_detector_mov.Location = new System.Drawing.Point(1366, 1350);
            this.btn_detector_mov.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_detector_mov.Name = "btn_detector_mov";
            this.btn_detector_mov.Size = new System.Drawing.Size(247, 82);
            this.btn_detector_mov.TabIndex = 156;
            this.btn_detector_mov.Text = "Activar";
            this.btn_detector_mov.UseVisualStyleBackColor = false;
            this.btn_detector_mov.Click += new System.EventHandler(this.btn_detector_mov_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.BorderColor = System.Drawing.Color.Transparent;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(20, 249);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(1400, 702);
            this.videoSourcePlayer1.TabIndex = 154;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.Location = new System.Drawing.Point(336, 1350);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(247, 82);
            this.btn_apagar.TabIndex = 153;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(2122, 1098);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 53);
            this.label5.TabIndex = 152;
            this.label5.Text = "Filtros";
            // 
            // cb_filtro_camara
            // 
            this.cb_filtro_camara.BackColor = System.Drawing.Color.White;
            this.cb_filtro_camara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_filtro_camara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro_camara.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_filtro_camara.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold);
            this.cb_filtro_camara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.cb_filtro_camara.FormattingEnabled = true;
            this.cb_filtro_camara.Items.AddRange(new object[] {
            "Blanco y Negro",
            "Sepia",
            "Negativo",
            "RosaAzulado",
            "Umbral",
            "Pixelado",
            "Ruido sal y pimienta",
            "Limpiar filtro (s)"});
            this.cb_filtro_camara.Location = new System.Drawing.Point(1969, 1163);
            this.cb_filtro_camara.Margin = new System.Windows.Forms.Padding(5);
            this.cb_filtro_camara.Name = "cb_filtro_camara";
            this.cb_filtro_camara.Size = new System.Drawing.Size(526, 38);
            this.cb_filtro_camara.TabIndex = 151;
            this.cb_filtro_camara.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_camara_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(890, 1293);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 37);
            this.label10.TabIndex = 150;
            this.label10.Text = "Acciones:";
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.photo.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo.ForeColor = System.Drawing.Color.White;
            this.photo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.photo.Location = new System.Drawing.Point(867, 1351);
            this.photo.Margin = new System.Windows.Forms.Padding(5);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(247, 82);
            this.photo.TabIndex = 149;
            this.photo.Text = "Foto";
            this.photo.UseVisualStyleBackColor = false;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Waltograph UI", 9.9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(239, 1292);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 37);
            this.label9.TabIndex = 148;
            this.label9.Text = "Cámara:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(474, 1092);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(374, 53);
            this.label11.TabIndex = 147;
            this.label11.Text = "Dispositivos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(2023, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 53);
            this.label7.TabIndex = 145;
            this.label7.Text = "resultado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Waltograph UI", 14.1F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(666, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(425, 53);
            this.label12.TabIndex = 144;
            this.label12.Text = "Camara actual";
            // 
            // btn_activar
            // 
            this.btn_activar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.btn_activar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_activar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activar.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activar.ForeColor = System.Drawing.Color.White;
            this.btn_activar.Location = new System.Drawing.Point(42, 1350);
            this.btn_activar.Name = "btn_activar";
            this.btn_activar.Size = new System.Drawing.Size(247, 82);
            this.btn_activar.TabIndex = 143;
            this.btn_activar.Text = "Activar";
            this.btn_activar.UseVisualStyleBackColor = false;
            this.btn_activar.Click += new System.EventHandler(this.btn_activar_Click);
            // 
            // cb_webcam
            // 
            this.cb_webcam.BackColor = System.Drawing.Color.White;
            this.cb_webcam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_webcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_webcam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_webcam.Font = new System.Drawing.Font("Waltograph UI", 8.099999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_webcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(112)))), ((int)(((byte)(152)))));
            this.cb_webcam.FormattingEnabled = true;
            this.cb_webcam.Location = new System.Drawing.Point(387, 1163);
            this.cb_webcam.Name = "cb_webcam";
            this.cb_webcam.Size = new System.Drawing.Size(526, 38);
            this.cb_webcam.TabIndex = 142;
            // 
            // pb_camara_resultado
            // 
            this.pb_camara_resultado.BackColor = System.Drawing.Color.Transparent;
            this.pb_camara_resultado.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_camara_resultado.Location = new System.Drawing.Point(1465, 148);
            this.pb_camara_resultado.Name = "pb_camara_resultado";
            this.pb_camara_resultado.Size = new System.Drawing.Size(1400, 900);
            this.pb_camara_resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_camara_resultado.TabIndex = 146;
            this.pb_camara_resultado.TabStop = false;
            // 
            // pb_camara_actual
            // 
            this.pb_camara_actual.BackColor = System.Drawing.Color.Transparent;
            this.pb_camara_actual.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_camara_actual.Location = new System.Drawing.Point(20, 148);
            this.pb_camara_actual.Name = "pb_camara_actual";
            this.pb_camara_actual.Size = new System.Drawing.Size(1400, 900);
            this.pb_camara_actual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_camara_actual.TabIndex = 141;
            this.pb_camara_actual.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(3204, 1633);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Editor Ruby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen_original)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_video_original)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_camara_actual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_desact_rostro;
        private System.Windows.Forms.Button btn_rostro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_save_web;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private AForge.Controls.Histogram histogramGreen1;
        private AForge.Controls.Histogram histogramBlue1;
        private AForge.Controls.Histogram histogramaRed1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCountMov;
        private System.Windows.Forms.Button btn_desactivar_mov;
        private System.Windows.Forms.Button btn_detector_mov;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_filtro_camara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button photo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_activar;
        private System.Windows.Forms.ComboBox cb_webcam;
        private System.Windows.Forms.PictureBox pb_camara_resultado;
        private System.Windows.Forms.PictureBox pb_camara_actual;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_video_resultado;
        private System.Windows.Forms.TextBox tb_ruta_Video;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_video_original;
        private System.Windows.Forms.ComboBox cb_filtro_videos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private AForge.Controls.Histogram histogramGreen;
        private AForge.Controls.Histogram histogramBlue;
        private AForge.Controls.Histogram histogramaRed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_filtros_editar;
        private System.Windows.Forms.Button btn_save_imagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pb_imagen_resultado;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btn_archivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_imagen_original;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_delete_imagen;
        private System.Windows.Forms.Button btn_delete_video;
        private System.Windows.Forms.Button btn_delete_web;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pb_camara;
    }
}

