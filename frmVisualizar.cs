using System;
using System.Threading;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmVisualizar : Form
    {
        int elementos = 10;
        int[] numerosGenerados;
        int velocidadDeReproducion = 1;
        private CancellationTokenSource cancellationTokenSource;

        public frmVisualizar()
        {
            InitializeComponent();

            //Se muestran todos los algoritmos disponibles en el combobox
            frmCodigo frmCodigo = new frmCodigo();
            frmCodigo.MostrarAlgoritmosDisponibles(cmbAlgoritmo);

            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);
            GenerarGrafica(numerosGenerados);//Se muestran los elementos a ordenar en la grafica

            cancellationTokenSource = new CancellationTokenSource();
        }

        #region Eventos
        private void BtnBarajear_Click(object sender, EventArgs e)
        {
            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);
            GenerarGrafica(numerosGenerados);//Se vuelve a generar los valores 
        }
        private async void BtnReproducir_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            EstaOrdenando(true);
            await ElegirAlgoritmo(CopiarValores(numerosGenerados), cancellationTokenSource.Token);
        }
        private void btnDetener_Click(object sender, EventArgs e)
        {
            EstaOrdenando(false);
            cancellationTokenSource.Cancel();
        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            GenerarGrafica(numerosGenerados);//Vuelve a mostrar el array original
        }
        private void TbVelocidad_Scroll(object sender, EventArgs e)
        {
            velocidadDeReproducion = tbVelocidad.Value;//El valor maximo es 5

            if (velocidadDeReproducion == 0)
                lblVelocidad.Text = "0.5x";
            else
                lblVelocidad.Text = velocidadDeReproducion + "x";
        }
        private void TbNumeroDeElementos_Scroll(object sender, EventArgs e)
        {
            elementos = tbNumeroDeElementos.Value;
            //Mostrar la cantidad de elementos a utilizar
            lblElementos.Text = elementos.ToString();
            //Genera los elementos aleatorios
            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);
            //Se muestran los elementos a ordenar en la grafica
            GenerarGrafica(numerosGenerados);
        }
        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotones();
        }
        #endregion
    }
}
