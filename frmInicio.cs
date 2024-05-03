using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

            leftBorderBtn = new Panel
            {
                Size = new Size(7, 100)
            };
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //
            OpenChildForm(new frmVisualizar());
        }

        //Eventos
        #region Botones de los Formularios
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.amarillo);
            OpenChildForm(new FrmInfo());
        }
        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.naranja);
            OpenChildForm(new frmCodigo());
        }
        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            BotonActivado(sender, RGBColors.azul);
            OpenChildForm(new FrmAcercaDe());
        }        
        private void PbInicio_Click(object sender, EventArgs e)
        {
            currentChildForm?.Close();//Si el formulario no es null lo cierra   
            Reset();
            OpenChildForm(new frmVisualizar());
        }
        private void BtnMaximizar_MouseHover(object sender, EventArgs e)
        {
            IconPictureBox pictureBox = (IconPictureBox)sender;
            toolTip1.SetToolTip(pictureBox, "Maximizar");
        }        
        private void BtnCerrar_Click(object sender, EventArgs e) => Application.Exit();
        private void BtnMaximizar_Click(object sender, EventArgs e)
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
        private void BtnMinimizar_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        #endregion

        #region Arrastrar Form
        //Esto es la funcionalidad de Arrastrar el formulario
        //Solo dios sabe como funciona esto asi que no le muevas 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}
