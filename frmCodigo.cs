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
            Button button = (Button)sender;
         
            if (isCodigoCopiado)
            {                
                btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
                isCodigoCopiado=false;
         
                Clipboard.SetText(txtCodigoJavascript.Text + " ");                
                toolTip1.SetToolTip(button, "Código copiado");

            }
            else
            {
                btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
                isCodigoCopiado=true;
                toolTip1.SetToolTip(button, "Copiar código");
            }
        }
        #endregion

        #region Hover
        private void btnCopiarCodigo_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isCodigoCopiado)
            {
                toolTip1.SetToolTip(button, "Copiar código");
            }
            else
            {
                toolTip1.SetToolTip(button, "Código copiado");
            }
        }
        #endregion



    }
}
