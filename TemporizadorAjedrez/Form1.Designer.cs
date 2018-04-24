namespace TemporizadorAjedrez
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
            this.components = new System.ComponentModel.Container();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.cbSegundos = new System.Windows.Forms.ComboBox();
            this.lbHoras = new System.Windows.Forms.Label();
            this.lbMinutos = new System.Windows.Forms.Label();
            this.lbSegundos = new System.Windows.Forms.Label();
            this.lbTemporizadorjg1 = new System.Windows.Forms.Label();
            this.lbTemporizadorjg2 = new System.Windows.Forms.Label();
            this.btPausar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btJugador1 = new System.Windows.Forms.Button();
            this.btJugador2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbHoras
            // 
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHoras.Location = new System.Drawing.Point(153, 25);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(121, 21);
            this.cbHoras.TabIndex = 0;
            this.cbHoras.Text = "Seleccionar";
            this.cbHoras.SelectedIndexChanged += new System.EventHandler(this.cbHoras_SelectedIndexChanged);
            // 
            // cbMinutos
            // 
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinutos.Location = new System.Drawing.Point(283, 25);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(121, 21);
            this.cbMinutos.TabIndex = 1;
            this.cbMinutos.Text = "Seleccionar";
            this.cbMinutos.SelectedIndexChanged += new System.EventHandler(this.cbMinutos_SelectedIndexChanged);
            // 
            // cbSegundos
            // 
            this.cbSegundos.FormattingEnabled = true;
            this.cbSegundos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbSegundos.Location = new System.Drawing.Point(408, 25);
            this.cbSegundos.Name = "cbSegundos";
            this.cbSegundos.Size = new System.Drawing.Size(121, 21);
            this.cbSegundos.TabIndex = 2;
            this.cbSegundos.Text = "Seleccionar";
            this.cbSegundos.SelectedIndexChanged += new System.EventHandler(this.cbSegundos_SelectedIndexChanged);
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Location = new System.Drawing.Point(150, 9);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(38, 13);
            this.lbHoras.TabIndex = 3;
            this.lbHoras.Text = "Horas:";
            // 
            // lbMinutos
            // 
            this.lbMinutos.AutoSize = true;
            this.lbMinutos.Location = new System.Drawing.Point(280, 9);
            this.lbMinutos.Name = "lbMinutos";
            this.lbMinutos.Size = new System.Drawing.Size(47, 13);
            this.lbMinutos.TabIndex = 4;
            this.lbMinutos.Text = "Minutos:";
            // 
            // lbSegundos
            // 
            this.lbSegundos.AutoSize = true;
            this.lbSegundos.Location = new System.Drawing.Point(405, 9);
            this.lbSegundos.Name = "lbSegundos";
            this.lbSegundos.Size = new System.Drawing.Size(58, 13);
            this.lbSegundos.TabIndex = 5;
            this.lbSegundos.Text = "Segundos:";
            // 
            // lbTemporizadorjg1
            // 
            this.lbTemporizadorjg1.AutoSize = true;
            this.lbTemporizadorjg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemporizadorjg1.Location = new System.Drawing.Point(12, 95);
            this.lbTemporizadorjg1.Name = "lbTemporizadorjg1";
            this.lbTemporizadorjg1.Size = new System.Drawing.Size(149, 39);
            this.lbTemporizadorjg1.TabIndex = 6;
            this.lbTemporizadorjg1.Text = "00:00:00";
            // 
            // lbTemporizadorjg2
            // 
            this.lbTemporizadorjg2.AutoSize = true;
            this.lbTemporizadorjg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemporizadorjg2.Location = new System.Drawing.Point(528, 95);
            this.lbTemporizadorjg2.Name = "lbTemporizadorjg2";
            this.lbTemporizadorjg2.Size = new System.Drawing.Size(149, 39);
            this.lbTemporizadorjg2.TabIndex = 7;
            this.lbTemporizadorjg2.Text = "00:00:00";
            // 
            // btPausar
            // 
            this.btPausar.Location = new System.Drawing.Point(302, 137);
            this.btPausar.Name = "btPausar";
            this.btPausar.Size = new System.Drawing.Size(75, 23);
            this.btPausar.TabIndex = 9;
            this.btPausar.Text = "Pausar";
            this.btPausar.UseVisualStyleBackColor = true;
            this.btPausar.Click += new System.EventHandler(this.btPausar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btJugador1
            // 
            this.btJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJugador1.Location = new System.Drawing.Point(12, 137);
            this.btJugador1.Name = "btJugador1";
            this.btJugador1.Size = new System.Drawing.Size(149, 35);
            this.btJugador1.TabIndex = 10;
            this.btJugador1.Text = "Iniciar";
            this.btJugador1.UseVisualStyleBackColor = true;
            this.btJugador1.Click += new System.EventHandler(this.Z);
            this.btJugador1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btJugador1_KeyPress);
            // 
            // btJugador2
            // 
            this.btJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJugador2.Location = new System.Drawing.Point(535, 137);
            this.btJugador2.Name = "btJugador2";
            this.btJugador2.Size = new System.Drawing.Size(142, 35);
            this.btJugador2.TabIndex = 11;
            this.btJugador2.Text = "Jugador Negras";
            this.btJugador2.UseVisualStyleBackColor = true;
            this.btJugador2.Click += new System.EventHandler(this.btJugador2_Click);
            this.btJugador2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btJugador2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Blancas ---> ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TemporizadorAjedrez.Properties.Resources.piezas_de_ajedres;
            this.pictureBox2.Location = new System.Drawing.Point(535, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TemporizadorAjedrez.Properties.Resources.blanca;
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(302, 166);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 15;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 440);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btJugador2);
            this.Controls.Add(this.btJugador1);
            this.Controls.Add(this.btPausar);
            this.Controls.Add(this.lbTemporizadorjg2);
            this.Controls.Add(this.lbTemporizadorjg1);
            this.Controls.Add(this.lbSegundos);
            this.Controls.Add(this.lbMinutos);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.cbSegundos);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.cbHoras);
            this.Name = "Form1";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btJugador1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.ComboBox cbSegundos;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label lbMinutos;
        private System.Windows.Forms.Label lbSegundos;
        private System.Windows.Forms.Label lbTemporizadorjg1;
        private System.Windows.Forms.Label lbTemporizadorjg2;
        private System.Windows.Forms.Button btPausar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btJugador1;
        private System.Windows.Forms.Button btJugador2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btReset;
    }
}

