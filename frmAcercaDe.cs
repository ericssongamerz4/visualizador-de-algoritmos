using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ericssongamerz4/visualizador-de-algoritmos");//Te envia al proyecto de github
        }
    }
}
