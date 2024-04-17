using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ericssongamerz4/visualizador-de-algoritmos");//Te envia al proyecto de github
        }
    }
}
