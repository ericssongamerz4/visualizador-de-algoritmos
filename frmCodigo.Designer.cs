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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodigo));
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCopiarCodigo = new FontAwesome.Sharp.IconButton();
            this.btnJS = new FontAwesome.Sharp.IconButton();
            this.btnPython = new FontAwesome.Sharp.IconButton();
            this.btnCSharp = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.RichTextBox();
            this.panelContenido.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panel3);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(15);
            this.panelContenido.Size = new System.Drawing.Size(800, 500);
            this.panelContenido.TabIndex = 6;
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
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(770, 391);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panel5.Controls.Add(this.btnCopiarCodigo);
            this.panel5.Controls.Add(this.btnJS);
            this.panel5.Controls.Add(this.btnPython);
            this.panel5.Controls.Add(this.btnCSharp);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(770, 44);
            this.panel5.TabIndex = 0;
            // 
            // btnCopiarCodigo
            // 
            this.btnCopiarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnCopiarCodigo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopiarCodigo.FlatAppearance.BorderSize = 0;
            this.btnCopiarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarCodigo.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnCopiarCodigo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnCopiarCodigo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopiarCodigo.IconSize = 36;
            this.btnCopiarCodigo.Location = new System.Drawing.Point(714, 0);
            this.btnCopiarCodigo.Name = "btnCopiarCodigo";
            this.btnCopiarCodigo.Size = new System.Drawing.Size(56, 44);
            this.btnCopiarCodigo.TabIndex = 4;
            this.btnCopiarCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopiarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCopiarCodigo.UseVisualStyleBackColor = false;
            this.btnCopiarCodigo.Click += new System.EventHandler(this.btnCopiarCodigo_Click);
            this.btnCopiarCodigo.MouseHover += new System.EventHandler(this.btnCopiarCodigo_MouseHover);
            // 
            // btnJS
            // 
            this.btnJS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnJS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnJS.FlatAppearance.BorderSize = 0;
            this.btnJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnJS.IconChar = FontAwesome.Sharp.IconChar.Js;
            this.btnJS.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnJS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJS.IconSize = 36;
            this.btnJS.Location = new System.Drawing.Point(191, 0);
            this.btnJS.Name = "btnJS";
            this.btnJS.Size = new System.Drawing.Size(90, 44);
            this.btnJS.TabIndex = 3;
            this.btnJS.UseVisualStyleBackColor = false;
            this.btnJS.MouseHover += new System.EventHandler(this.btnJS_MouseHover);
            // 
            // btnPython
            // 
            this.btnPython.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnPython.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPython.FlatAppearance.BorderSize = 0;
            this.btnPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPython.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnPython.IconChar = FontAwesome.Sharp.IconChar.Python;
            this.btnPython.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnPython.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPython.IconSize = 36;
            this.btnPython.Location = new System.Drawing.Point(96, 0);
            this.btnPython.Name = "btnPython";
            this.btnPython.Size = new System.Drawing.Size(95, 44);
            this.btnPython.TabIndex = 1;
            this.btnPython.UseVisualStyleBackColor = false;
            this.btnPython.MouseHover += new System.EventHandler(this.btnPython_MouseHover);
            // 
            // btnCSharp
            // 
            this.btnCSharp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnCSharp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCSharp.FlatAppearance.BorderSize = 0;
            this.btnCSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSharp.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.btnCSharp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnCSharp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCSharp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnCSharp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCSharp.IconSize = 36;
            this.btnCSharp.Location = new System.Drawing.Point(0, 0);
            this.btnCSharp.Name = "btnCSharp";
            this.btnCSharp.Size = new System.Drawing.Size(96, 44);
            this.btnCSharp.TabIndex = 2;
            this.btnCSharp.Text = " C#";
            this.btnCSharp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCSharp.UseVisualStyleBackColor = false;
            this.btnCSharp.Click += new System.EventHandler(this.btnCSharp_Click);
            this.btnCSharp.MouseHover += new System.EventHandler(this.btnCSharp_MouseHover);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panel8.Controls.Add(this.txtCodigo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 44);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10);
            this.panel8.Size = new System.Drawing.Size(770, 347);
            this.panel8.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtCodigo.Location = new System.Drawing.Point(10, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(750, 327);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = resources.GetString("txtCodigo.Text");
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
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnCopiarCodigo;
        private FontAwesome.Sharp.IconButton btnJS;
        private FontAwesome.Sharp.IconButton btnPython;
        private FontAwesome.Sharp.IconButton btnCSharp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RichTextBox txtCodigo;
    }
}