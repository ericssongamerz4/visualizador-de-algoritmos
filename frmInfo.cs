using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
        }
    }
}
