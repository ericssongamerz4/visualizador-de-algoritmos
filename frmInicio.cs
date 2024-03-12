﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmInicio : Form
    {
        //Campos
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        //Structs
        private struct RGBColors
        {
            public static Color verde = Color.FromArgb(72, 238, 46);
            public static Color amarillo = Color.FromArgb(238, 203, 24);
            public static Color naranja = Color.FromArgb(240, 90, 21);
            public static Color azul = Color.FromArgb(22, 218, 192);
            public static Color morado = Color.FromArgb(152, 33, 253);
            public static Color botonActivado = Color.FromArgb(10, 33, 41);

            public static Color colorPanel = Color.FromArgb(1, 9, 9);
            public static Color colorPanel2 = Color.FromArgb(221, 235, 235);
            public static Color colorTexto = Color.FromArgb(227, 252, 247);
        }

        public frmInicio()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Methods
        private void BotonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeshablitarBoton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.botonActivado;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DeshablitarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.colorPanel;
                currentBtn.ForeColor = RGBColors.colorTexto;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.colorTexto;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DeshablitarBoton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.morado;
            lblTitleChildForm.Text = "Inicio";
            lblTitleChildForm.ForeColor = RGBColors.morado;
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            lblTitleChildForm.ForeColor = iconCurrentChildForm.ForeColor;
        }
        //
        //Eventos
        //
        #region Botones de los Formularios
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.verde);
            OpenChildForm(new frmVisualizar());
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.amarillo);
            OpenChildForm(new frmInfo());
        }
        private void btnCodigo_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.naranja);
            OpenChildForm(new frmCodigo());
        }
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.azul);
            OpenChildForm(new frmAjustes());
        }        
        private void pbInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }      
        #endregion

        #region Cerrar-Maximizar-Minimizar

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximizar.IconChar = IconChar.WindowRestore;
            }
            else
            { 
                WindowState = FormWindowState.Normal;
                btnMaximizar.IconChar = IconChar.WindowMaximize;
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Arrastrar Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


    }
}
