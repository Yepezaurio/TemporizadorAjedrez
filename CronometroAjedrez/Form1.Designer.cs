namespace CronometroAjedrez
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.ComboBox();
            this.minutos = new System.Windows.Forms.ComboBox();
            this.segundos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.lbTiempo2 = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btDetener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutos:";
            // 
            // horas
            // 
            this.horas.FormattingEnabled = true;
            this.horas.Items.AddRange(new object[] {
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
            this.horas.Location = new System.Drawing.Point(12, 32);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(121, 21);
            this.horas.TabIndex = 2;
            this.horas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // minutos
            // 
            this.minutos.FormattingEnabled = true;
            this.minutos.Items.AddRange(new object[] {
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
            this.minutos.Location = new System.Drawing.Point(139, 32);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(121, 21);
            this.minutos.TabIndex = 3;
            // 
            // segundos
            // 
            this.segundos.FormattingEnabled = true;
            this.segundos.Items.AddRange(new object[] {
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
            this.segundos.Location = new System.Drawing.Point(266, 32);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(121, 21);
            this.segundos.TabIndex = 4;
            this.segundos.SelectedIndexChanged += new System.EventHandler(this.segundos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Segundos:";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.Location = new System.Drawing.Point(12, 99);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(149, 39);
            this.lbTiempo.TabIndex = 6;
            this.lbTiempo.Text = "00:00:00";
            this.lbTiempo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTiempo2
            // 
            this.lbTiempo2.AutoSize = true;
            this.lbTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo2.Location = new System.Drawing.Point(491, 99);
            this.lbTiempo2.Name = "lbTiempo2";
            this.lbTiempo2.Size = new System.Drawing.Size(149, 39);
            this.lbTiempo2.TabIndex = 7;
            this.lbTiempo2.Text = "00:00:00";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(246, 226);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 8;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btDetener
            // 
            this.btDetener.Location = new System.Drawing.Point(327, 226);
            this.btDetener.Name = "btDetener";
            this.btDetener.Size = new System.Drawing.Size(75, 23);
            this.btDetener.TabIndex = 9;
            this.btDetener.Text = "Detener";
            this.btDetener.UseVisualStyleBackColor = true;
            this.btDetener.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.btDetener);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.lbTiempo2);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox horas;
        private System.Windows.Forms.ComboBox minutos;
        private System.Windows.Forms.ComboBox segundos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label lbTiempo2;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btDetener;
    }
}

