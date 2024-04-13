namespace visualizador_de_algoritmos
{
    partial class frmAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjustes));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnGitHub = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panelBarraTitulo.Controls.Add(this.label4);
            this.panelBarraTitulo.Controls.Add(this.label3);
            this.panelBarraTitulo.Controls.Add(this.btnGitHub);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 425);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 75);
            this.panelBarraTitulo.TabIndex = 2;
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.Transparent;
            this.btnGitHub.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnGitHub.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGitHub.IconSize = 75;
            this.btnGitHub.Location = new System.Drawing.Point(0, 0);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(79, 75);
            this.btnGitHub.TabIndex = 0;
            this.btnGitHub.TabStop = false;
            this.btnGitHub.Click += new System.EventHandler(this.BtnGitHub_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(107, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hecho por Erick Montaño";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(446, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 65);
            this.label4.TabIndex = 4;
            this.label4.Text = "Taller de Investigación II";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(40, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 290);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 32F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 86);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿Qué es VisualSort?";
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjustes";
            this.Text = "Ajustes";
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox btnGitHub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}