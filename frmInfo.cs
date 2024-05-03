using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            panelInfo.AutoScroll = false;
            panelInfo.HorizontalScroll.Enabled = false;
            panelInfo.HorizontalScroll.Visible = false;
            panelInfo.HorizontalScroll.Maximum = 0;
            panelInfo.AutoScroll = true;

            panelInfo2.AutoScroll = false;
            panelInfo2.HorizontalScroll.Enabled = false;
            panelInfo2.HorizontalScroll.Visible = false;
            panelInfo2.HorizontalScroll.Maximum = 0;
            panelInfo2.AutoScroll = true;
        }
    }
}
