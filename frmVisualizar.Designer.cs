namespace visualizador_de_algoritmos
{
    partial class frmVisualizar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVelocidad = new System.Windows.Forms.TrackBar();
            this.btnBarajear = new FontAwesome.Sharp.IconButton();
            this.btnFinal = new FontAwesome.Sharp.IconButton();
            this.btnReproducir = new FontAwesome.Sharp.IconButton();
            this.btnReiniciar = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblElementos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumeroDeElementos = new System.Windows.Forms.TrackBar();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelContenido.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDeElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panel3);
            this.panelContenido.Controls.Add(this.panel1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(15);
            this.panelContenido.Size = new System.Drawing.Size(800, 500);
            this.panelContenido.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 79);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(770, 406);
            this.panel3.TabIndex = 5;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.chart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 10);
            this.chart.Name = "chart";
            this.chart.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))))};
            this.chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(770, 304);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(770, 92);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.lblVelocidad);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbVelocidad);
            this.panel4.Controls.Add(this.btnBarajear);
            this.panel4.Controls.Add(this.btnFinal);
            this.panel4.Controls.Add(this.btnReproducir);
            this.panel4.Controls.Add(this.btnReiniciar);
            this.panel4.Controls.Add(this.btnInicio);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 82);
            this.panel4.TabIndex = 0;
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblVelocidad.Location = new System.Drawing.Point(322, 17);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(45, 38);
            this.lblVelocidad.TabIndex = 10;
            this.lblVelocidad.Text = "1x";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Velocidad:";
            // 
            // tbVelocidad
            // 
            this.tbVelocidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVelocidad.Location = new System.Drawing.Point(168, 24);
            this.tbVelocidad.Maximum = 5;
            this.tbVelocidad.Name = "tbVelocidad";
            this.tbVelocidad.Size = new System.Drawing.Size(148, 69);
            this.tbVelocidad.TabIndex = 5;
            this.tbVelocidad.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVelocidad.Value = 1;
            this.tbVelocidad.Scroll += new System.EventHandler(this.TbVelocidad_Scroll);
            // 
            // btnBarajear
            // 
            this.btnBarajear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBarajear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))));
            this.btnBarajear.Enabled = false;
            this.btnBarajear.FlatAppearance.BorderSize = 0;
            this.btnBarajear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarajear.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnBarajear.IconColor = System.Drawing.Color.Black;
            this.btnBarajear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBarajear.Location = new System.Drawing.Point(392, 12);
            this.btnBarajear.Name = "btnBarajear";
            this.btnBarajear.Size = new System.Drawing.Size(60, 60);
            this.btnBarajear.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnBarajear, "Barajear");
            this.btnBarajear.UseVisualStyleBackColor = false;
            this.btnBarajear.Click += new System.EventHandler(this.BtnBarajear_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))));
            this.btnFinal.Enabled = false;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.btnFinal.IconColor = System.Drawing.Color.Black;
            this.btnFinal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinal.Location = new System.Drawing.Point(620, 12);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(60, 60);
            this.btnFinal.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnFinal, "Ir al Final");
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.BtnFinal_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))));
            this.btnReproducir.Enabled = false;
            this.btnReproducir.FlatAppearance.BorderSize = 0;
            this.btnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReproducir.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnReproducir.IconColor = System.Drawing.Color.Black;
            this.btnReproducir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReproducir.Location = new System.Drawing.Point(545, 11);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(60, 60);
            this.btnReproducir.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnReproducir, "Reproducir");
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Click += new System.EventHandler(this.BtnReproducir_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))));
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnReiniciar.IconColor = System.Drawing.Color.Black;
            this.btnReiniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReiniciar.Location = new System.Drawing.Point(694, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(60, 60);
            this.btnReiniciar.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnReiniciar, "Reiniciar");
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(201)))), ((int)(((byte)(242)))));
            this.btnInicio.Enabled = false;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.btnInicio.IconColor = System.Drawing.Color.Black;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.Location = new System.Drawing.Point(468, 11);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(60, 60);
            this.btnInicio.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnInicio, "Volver al inicio");
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.lblElementos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNumeroDeElementos);
            this.panel1.Controls.Add(this.cmbAlgoritmo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 64);
            this.panel1.TabIndex = 2;
            // 
            // lblElementos
            // 
            this.lblElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblElementos.AutoSize = true;
            this.lblElementos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementos.Location = new System.Drawing.Point(343, 21);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(34, 28);
            this.lblElementos.TabIndex = 13;
            this.lblElementos.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Elementos:";
            // 
            // tbNumeroDeElementos
            // 
            this.tbNumeroDeElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumeroDeElementos.Location = new System.Drawing.Point(168, 20);
            this.tbNumeroDeElementos.Maximum = 100;
            this.tbNumeroDeElementos.Minimum = 10;
            this.tbNumeroDeElementos.Name = "tbNumeroDeElementos";
            this.tbNumeroDeElementos.Size = new System.Drawing.Size(173, 69);
            this.tbNumeroDeElementos.TabIndex = 11;
            this.tbNumeroDeElementos.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.tbNumeroDeElementos, "Numero de Elementos");
            this.tbNumeroDeElementos.Value = 10;
            this.tbNumeroDeElementos.Scroll += new System.EventHandler(this.TbNumeroDeElementos_Scroll);
            // 
            // cmbAlgoritmo
            // 
            this.cmbAlgoritmo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlgoritmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.cmbAlgoritmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbAlgoritmo.FormattingEnabled = true;
            this.cmbAlgoritmo.Location = new System.Drawing.Point(561, 18);
            this.cmbAlgoritmo.Name = "cmbAlgoritmo";
            this.cmbAlgoritmo.Size = new System.Drawing.Size(193, 40);
            this.cmbAlgoritmo.TabIndex = 2;
            this.cmbAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.cmbAlgoritmo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(387, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algoritmo:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVisualizar";
            this.Text = "Visualizar";
            this.panelContenido.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVelocidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumeroDeElementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlgoritmo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar tbVelocidad;
        private FontAwesome.Sharp.IconButton btnBarajear;
        private FontAwesome.Sharp.IconButton btnFinal;
        private FontAwesome.Sharp.IconButton btnReproducir;
        private FontAwesome.Sharp.IconButton btnReiniciar;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbNumeroDeElementos;
        private System.Windows.Forms.Timer timer;
    }
}