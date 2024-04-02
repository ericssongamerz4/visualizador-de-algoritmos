using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace visualizador_de_algoritmos
{
    public partial class frmVisualizar : Form
    {
        int elementos = 10;        
        int[] numerosGenerados;
        int velocidadDeReproducion = 1;

        public frmVisualizar()
        {
            InitializeComponent();

            //Se muestran todos los algoritmos disponibles en el combobox
            frmCodigo frmCodigo = new frmCodigo();
            frmCodigo.MostrarAlgoritmosDisponibles(cmbAlgoritmo);

            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);
            ActualizarGrafica(numerosGenerados);//Se muestran los elementos a ordenar en la grafica
        }

        #region Metodos
        private void GenerarNumerosAleatorios(int NumeroElementos)// Generar numeros enteros aleatorios entre 0 y 100 
        {
            Random random = new Random();
            numerosGenerados = new int[NumeroElementos]; // Se inicializa el array

            for (int i = 0; i < NumeroElementos; i++)
            {
                int numeroAleatorio = random.Next(0, 101);
                numerosGenerados[i] = numeroAleatorio;
            }
        }

        private void ActualizarGrafica(int[] arr)
        {
            chart.Series["Series1"].Points.Clear();//Limpia los valores anteriores

            for (int i = 0; i < arr.Length; i++)
            {
                chart.Series["Series1"].Points.AddXY(i + 1, arr[i]);
            }
        }//Muestra los valores en la grafica

        private int[] CopiarValores(int[] arrayOriginal)//Se duplica el array original en caso de que se necesiten los valores originales.
        {
            int[] numerosAOrdenar = new int[arrayOriginal.Length];

            Array.Copy(arrayOriginal, numerosAOrdenar, arrayOriginal.Length);

           return numerosAOrdenar;
        }

        private void HabilitarBotones()
        {
            btnFinal.Enabled = true;
            btnInicio.Enabled = true;
            btnReiniciar.Enabled = true;
            btnReproducir.Enabled = true;
            btnBarajear.Enabled = true; 
        }

        private void ElegirAlgoritmo(ComboBox comboBox, int[] arr)//Elige el algoritmo a utilizar en base al texto del combobox
        {
            switch (comboBox.Text)
            {
                case "SELECTION SORT":
                    SelectionSort(arr);
                    break;

                case "BUBBLE SORT":
                    break;


                default:
                    break;
            }

        }
        
        private void DeterminarVelocidad()
        {
            //Estos valores son de prueba
            switch (velocidadDeReproducion)
            {
                case 0:
                    timer.Interval = 2000;
                    break;
                case 1:
                    timer.Interval = 1000;
                    break;
                case 2:
                    timer.Interval = 750;
                    break;
                case 3:
                    timer.Interval = 500;
                    break;
                case 4:
                    timer.Interval = 250;
                    break;
                case 5:
                    timer.Interval = 100;
                    break;
            }
        }

        #region Algoritmos de Ordenamiento
        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

                //Actualizar la grafica despues de cada cambio
                ActualizarGrafica(arr);

            }
        }//

        #endregion

        #endregion

        #region Eventos
        private void BtnBarajear_Click(object sender, EventArgs e)
        {
            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);

            //Se vuelve a generar los valores 
            ActualizarGrafica(numerosGenerados);
        }
        private void BtnReproducir_Click(object sender, EventArgs e)
        {
            ElegirAlgoritmo(cmbAlgoritmo, CopiarValores(numerosGenerados));  
        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            ActualizarGrafica(numerosGenerados);
        }            
        private void BtnInicio_Click(object sender, EventArgs e)
        {

        } 
        private void BtnFinal_Click(object sender, EventArgs e)
        {

        }
        private void TbVelocidad_Scroll(object sender, EventArgs e)
        {
            velocidadDeReproducion = tbVelocidad.Value;//El valor maximo es 5

            if(velocidadDeReproducion == 0)
                lblVelocidad.Text = "0.5x";
            else
                lblVelocidad.Text = velocidadDeReproducion + "x";

            DeterminarVelocidad();
        }
        private void TbNumeroDeElementos_Scroll(object sender, EventArgs e)
        {
            elementos = tbNumeroDeElementos.Value;
            //Mostrar la cantidad de elementos a utilizar
            lblElementos.Text = elementos.ToString();

            //Genera los elementos aleatorios
            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);
            //Se muestran los elementos a ordenar en la grafica
            ActualizarGrafica(numerosGenerados);
        }        
        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotones();
        }
        private void timer_Tick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
