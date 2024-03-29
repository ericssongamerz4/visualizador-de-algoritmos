namespace visualizador_de_algoritmos
{
    partial class frmCodigo
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnCopiarCodigo = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbLenguajesDeProgramacion = new System.Windows.Forms.TabControl();
            this.tabPageCSharp = new System.Windows.Forms.TabPage();
            this.txtCodigoCSharp = new System.Windows.Forms.RichTextBox();
            this.tabPageJavascript = new System.Windows.Forms.TabPage();
            this.txtCodigoJavascript = new System.Windows.Forms.RichTextBox();
            this.tabPagePython = new System.Windows.Forms.TabPage();
            this.txtCodigoPython = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenido.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tbLenguajesDeProgramacion.SuspendLayout();
            this.tabPageCSharp.SuspendLayout();
            this.tabPageJavascript.SuspendLayout();
            this.tabPagePython.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnCopiarCodigo);
            this.panelContenido.Controls.Add(this.panel3);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(15);
            this.panelContenido.Size = new System.Drawing.Size(800, 500);
            this.panelContenido.TabIndex = 6;
            // 
            // btnCopiarCodigo
            // 
            this.btnCopiarCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCopiarCodigo.FlatAppearance.BorderSize = 0;
            this.btnCopiarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnCopiarCodigo.IconColor = System.Drawing.Color.Black;
            this.btnCopiarCodigo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopiarCodigo.IconSize = 40;
            this.btnCopiarCodigo.Location = new System.Drawing.Point(744, 95);
            this.btnCopiarCodigo.Name = "btnCopiarCodigo";
            this.btnCopiarCodigo.Size = new System.Drawing.Size(40, 40);
            this.btnCopiarCodigo.TabIndex = 2;
            this.btnCopiarCodigo.UseVisualStyleBackColor = false;
            this.btnCopiarCodigo.Click += new System.EventHandler(this.btnCopiarCodigo_Click);
            this.btnCopiarCodigo.MouseHover += new System.EventHandler(this.btnCopiarCodigo_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(770, 470);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(770, 401);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel4.Controls.Add(this.tbLenguajesDeProgramacion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 391);
            this.panel4.TabIndex = 0;
            // 
            // tbLenguajesDeProgramacion
            // 
            this.tbLenguajesDeProgramacion.Controls.Add(this.tabPageCSharp);
            this.tbLenguajesDeProgramacion.Controls.Add(this.tabPageJavascript);
            this.tbLenguajesDeProgramacion.Controls.Add(this.tabPagePython);
            this.tbLenguajesDeProgramacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLenguajesDeProgramacion.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLenguajesDeProgramacion.Location = new System.Drawing.Point(0, 0);
            this.tbLenguajesDeProgramacion.Name = "tbLenguajesDeProgramacion";
            this.tbLenguajesDeProgramacion.SelectedIndex = 0;
            this.tbLenguajesDeProgramacion.Size = new System.Drawing.Size(770, 391);
            this.tbLenguajesDeProgramacion.TabIndex = 0;
            // 
            // tabPageCSharp
            // 
            this.tabPageCSharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tabPageCSharp.Controls.Add(this.txtCodigoCSharp);
            this.tabPageCSharp.Location = new System.Drawing.Point(4, 57);
            this.tabPageCSharp.Name = "tabPageCSharp";
            this.tabPageCSharp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCSharp.Size = new System.Drawing.Size(762, 330);
            this.tabPageCSharp.TabIndex = 0;
            this.tabPageCSharp.Text = "C#";
            // 
            // txtCodigoCSharp
            // 
            this.txtCodigoCSharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtCodigoCSharp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoCSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoCSharp.Location = new System.Drawing.Point(3, 3);
            this.txtCodigoCSharp.Name = "txtCodigoCSharp";
            this.txtCodigoCSharp.ReadOnly = true;
            this.txtCodigoCSharp.Size = new System.Drawing.Size(756, 324);
            this.txtCodigoCSharp.TabIndex = 1;
            this.txtCodigoCSharp.Text = "";
            // 
            // tabPageJavascript
            // 
            this.tabPageJavascript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tabPageJavascript.Controls.Add(this.txtCodigoJavascript);
            this.tabPageJavascript.Location = new System.Drawing.Point(4, 57);
            this.tabPageJavascript.Name = "tabPageJavascript";
            this.tabPageJavascript.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJavascript.Size = new System.Drawing.Size(762, 330);
            this.tabPageJavascript.TabIndex = 1;
            this.tabPageJavascript.Text = "Javascript";
            // 
            // txtCodigoJavascript
            // 
            this.txtCodigoJavascript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtCodigoJavascript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoJavascript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoJavascript.Location = new System.Drawing.Point(3, 3);
            this.txtCodigoJavascript.Name = "txtCodigoJavascript";
            this.txtCodigoJavascript.ReadOnly = true;
            this.txtCodigoJavascript.Size = new System.Drawing.Size(756, 324);
            this.txtCodigoJavascript.TabIndex = 0;
            this.txtCodigoJavascript.Text = "";
            // 
            // tabPagePython
            // 
            this.tabPagePython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tabPagePython.Controls.Add(this.txtCodigoPython);
            this.tabPagePython.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePython.Location = new System.Drawing.Point(4, 57);
            this.tabPagePython.Name = "tabPagePython";
            this.tabPagePython.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePython.Size = new System.Drawing.Size(762, 330);
            this.tabPagePython.TabIndex = 2;
            this.tabPagePython.Text = "Python";
            // 
            // txtCodigoPython
            // 
            this.txtCodigoPython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtCodigoPython.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoPython.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoPython.Location = new System.Drawing.Point(3, 3);
            this.txtCodigoPython.Name = "txtCodigoPython";
            this.txtCodigoPython.ReadOnly = true;
            this.txtCodigoPython.Size = new System.Drawing.Size(756, 324);
            this.txtCodigoPython.TabIndex = 1;
            this.txtCodigoPython.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbAlgoritmo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 59);
            this.panel1.TabIndex = 9;
            // 
            // cmbAlgoritmo
            // 
            this.cmbAlgoritmo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlgoritmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.cmbAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgoritmo.FormattingEnabled = true;
            this.cmbAlgoritmo.Items.AddRange(new object[] {
            "Bubble sort",
            "Quick sort"});
            this.cmbAlgoritmo.Location = new System.Drawing.Point(194, 6);
            this.cmbAlgoritmo.Name = "cmbAlgoritmo";
            this.cmbAlgoritmo.Size = new System.Drawing.Size(566, 46);
            this.cmbAlgoritmo.TabIndex = 5;
            this.cmbAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.cmbAlgoritmo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Algoritmo:";
            // 
            // frmCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCodigo";
            this.Text = "Código";
            this.panelContenido.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tbLenguajesDeProgramacion.ResumeLayout(false);
            this.tabPageCSharp.ResumeLayout(false);
            this.tabPageJavascript.ResumeLayout(false);
            this.tabPagePython.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbAlgoritmo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tbLenguajesDeProgramacion;
        private System.Windows.Forms.TabPage tabPageCSharp;
        private System.Windows.Forms.TabPage tabPageJavascript;
        private System.Windows.Forms.TabPage tabPagePython;
        private System.Windows.Forms.RichTextBox txtCodigoJavascript;
        private System.Windows.Forms.RichTextBox txtCodigoCSharp;
        private System.Windows.Forms.RichTextBox txtCodigoPython;
        private FontAwesome.Sharp.IconButton btnCopiarCodigo;
    }
}