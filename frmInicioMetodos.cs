using FontAwesome.Sharp;
using System.Drawing;
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
        public struct RGBColors
        {
            public static Color verde = Color.FromArgb(72, 238, 46);
            public static Color amarillo = Color.FromArgb(238, 203, 24);
            public static Color naranja = Color.FromArgb(240, 90, 21);
            public static Color azul = Color.FromArgb(22, 218, 192);
            public static Color morado = Color.FromArgb(152, 33, 253);
            public static Color botonActivado = Color.FromArgb(10, 33, 41);

            public static Color colorPanel = Color.FromArgb(1, 9, 9);
            public static Color colorPanel2 = Color.FromArgb(221, 235, 235);
            public static Color colorTexto = Color.FromArgb(227, 252, 247);//
            public static Color colorFondoCodigo = Color.FromArgb(39, 40, 34);
        }

        //Metodos
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
      
    }
}
