using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            try
            {            
                webBrowser1.Navigate("C:\\Users\\hp\\source\\repos\\visualizador-de-algoritmos\\Algoritmos\\Info General.html");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error al cargar el contenido","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
