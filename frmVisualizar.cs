using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace visualizador_de_algoritmos
{
    public partial class frmVisualizar : Form
    {
        int elementos = 10;        
        int[] numerosGenerados;
        int[] numerosAOrdenar;
        int velocidadDeReproducion = 1;

        public frmVisualizar()
        {
            InitializeComponent();

            frmCodigo frmCodigo = new frmCodigo();
            frmCodigo.MostrarAlgoritmosDisponibles();
            MostrarElementosAleatorios();//Se muestran los elementos a ordenar en la grafica
        }

        #region Metodos

        private void GenerarNumerosAleatorios(int NumeroElementos)
        {
            Random random = new Random();
            numerosGenerados = new int[NumeroElementos]; // Se inicializa el array

            for (int i = 0; i < NumeroElementos; i++)
            {
                // Generar un numero entero aleatorio entre 0 y 100 
                int numeroAleatorio = random.Next(0, 101);

                numerosGenerados[i] = numeroAleatorio;
            }
        }

        private void MostrarElementosAleatorios()//Muestra los elementos generados en GenerarNumerosAleatorios en la grafica
        {
            chart.Series["Series1"].Points.Clear();//Limpia los valores anteriores

            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);

            for (int i = 0; i < numerosGenerados.Length; i++)
            {
                chart.Series["Series1"].Points.AddXY(i + 1, numerosGenerados[i]);
            }
        }

        private void HabilitarBotones()
        {
            btnFinal.Enabled = true;
            btnInicio.Enabled = true;
            btnReiniciar.Enabled = true;
            btnReproducir.Enabled = true;
            btnBarajear.Enabled = true; 
        }

        private void ActualizarGrafica(int[] arr)
        {
            chart.Series["Series1"].Points.Clear();//Limpia los valores anteriores

            for (int i = 0; i < arr.Length; i++)
            {
                chart.Series["Series1"].Points.AddXY(i + 1, arr[i]);
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
        private void BubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }
        private void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }





        #endregion
        #endregion




        #region Eventos
        private void BtnBarajear_Click(object sender, EventArgs e)
        {
            //Se muestran los elementos a ordenar en la grafica
            MostrarElementosAleatorios();            
        }
        private void BtnFinal_Click(object sender, EventArgs e)
        {

        }
        private void BtnReproducir_Click(object sender, EventArgs e)
        {
            numerosAOrdenar = numerosGenerados;
            SelectionSort(numerosAOrdenar);
        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {

        }
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            ActualizarGrafica(numerosGenerados);
        }
        private void BtnReproducir_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnReproducir, "reproducir");
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

            MostrarElementosAleatorios();//Se muestran los elementos a ordenar en la grafica
        }
        #endregion

        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotones();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
