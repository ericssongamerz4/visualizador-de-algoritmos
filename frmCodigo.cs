using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmCodigo : Form
    {
        bool isCodigoCopiado = true;
        
        public frmCodigo()
        {
            InitializeComponent();

        }

        //
        //Eventos
        //
        #region Click
        private void btnCopiarCodigo_Click(object sender, EventArgs e)
        {
            if (isCodigoCopiado)
            {                
                btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
                isCodigoCopiado=false;
         
                Clipboard.SetText(txtCodigo.Text + " ");
            }
            else
            {
                btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
                isCodigoCopiado=true;
                
            }
        }

        private void btnCSharp_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Hover
        private void btnCopiarCodigo_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "Copiar código");
        }

        private void btnJS_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "JavaScript");
        }

        private void btnPython_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "Python");
        }

        private void btnCSharp_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "C#");
        }

        #endregion



    }
}
