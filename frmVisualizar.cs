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
    public partial class frmVisualizar : Form
    {
        public frmVisualizar()
        {
            InitializeComponent();

        }
        #region Click
        private void btnBarajear_Click(object sender, EventArgs e)
        {

        }
        private void btnFinal_Click(object sender, EventArgs e)
        {

        }
        private void btnReproducir_Click(object sender, EventArgs e)
        {

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {

        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Hover
        private void btnBarajear_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "");
        }        
        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "Ir al inicio");
        }
        private void btnFinal_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "Ir al final");
        }
        private void btnReproducir_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "reproducir");
        }
        private void btnReiniciar_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            toolTip1.SetToolTip(button, "Reiniciar");
        }
        #endregion



        private void tbVelocidad_Scroll(object sender, EventArgs e)
        {
            int velocidad =tbVelocidad.Value;
            if(velocidad == 0)
                lblVelocidad.Text = "0.5x";
            else
                lblVelocidad.Text = velocidad + "x";
            
        }

        private void tbElementos_Scroll(object sender, EventArgs e)
        {
            int elementos = tbElementos.Value;
            if (elementos == 0)
                lblElementos.Text = "0.5";
            else
                lblElementos.Text = elementos.ToString();
        }
    }
}
