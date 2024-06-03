using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmVisualizar : Form
    {
        #region Metodos

        private void GenerarNumerosAleatorios(int NumeroElementos)// Generar numeros enteros aleatorios entre 1 y 100 
        {
            Random random = new Random();
            numerosGenerados = new int[NumeroElementos]; // Se inicializa el array

            for (int i = 0; i < NumeroElementos; i++)
            {
                int numeroAleatorio = random.Next(1, 101);
                numerosGenerados[i] = numeroAleatorio;
            }
        }
        private void GenerarGrafica(int[] arr)//Muestra los valores en la grafica
        {
            chart.Series["Series1"].Points.Clear();//Limpia los valores anteriores

            for (int i = 0; i < arr.Length; i++)
            {
                chart.Series["Series1"].Points.AddXY(i + 1, arr[i]);
            }
        }
        private int[] CopiarValores(int[] arrayOriginal)//Se duplica el array original en caso de que se necesiten los valores originales.
        {
            int[] numerosAOrdenar = new int[arrayOriginal.Length];

            Array.Copy(arrayOriginal, numerosAOrdenar, arrayOriginal.Length);

            return numerosAOrdenar;
        }            
        private void ResaltarElemento(int index, Color color)
        {
            chart.Series["Series1"].Points[index].Color = color;
        }
        private int DeterminarRetraso()
        {
            switch (velocidadDeReproducion)
            {
                case 0://x0.5
                    return 2000;
                case 1://x1
                    return 1000;
                case 2://x2
                    return 750;
                case 3://x3
                    return 250;
                case 4://x4
                    return 100;
                case 5://x5
                    return 10;
                default://sin retraso
                    return 0;
            }
        }          
        private void HabilitarBotones()
        {
            btnInicio.Enabled = true;
            btnReproducir.Enabled = true;
            btnBarajear.Enabled = true;
            tbVelocidad.Enabled = true;
        }
        private void EstaOrdenando(bool estaOrdenando)
        {
            tbNumeroDeElementos.Enabled = !estaOrdenando;

            btnBarajear.Enabled  = !estaOrdenando;            
            btnInicio.Enabled = !estaOrdenando;

            btnReproducir.Visible = !estaOrdenando;
            btnReproducir.Enabled = !estaOrdenando;
        }

        private async Task ElegirAlgoritmo(int[] arr, CancellationToken cancellationToken)//Elige el algoritmo a utilizar en base al texto del combobox
        {
            switch (cmbAlgoritmo.Text)
            {
                case "SELECTION SORT":                    
                    await SelectionSort(arr, cancellationToken);
                    break;

                case "BUBBLE SORT":
                    await BubbleSort(arr, cancellationToken);
                    break;

                case "INSERTION SORT":
                    await InsertionSort(arr, cancellationToken);
                    break;

                case "QUICKSORT":
                    await QuickSort(arr, 0, arr.Length - 1);
                    break;

                default:
                    break;
            }
        }

        #region Algoritmos 
        private async Task SelectionSort(int[] arr, CancellationToken cancellationToken)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Check for cancellation
                if (cancellationToken.IsCancellationRequested)
                    return;

                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    // Check for cancellation
                    if (cancellationToken.IsCancellationRequested)
                        return;

                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }

                    GenerarGrafica(arr); // Actualiza la gráfica después de cada intercambio

                    ResaltarElemento(min_idx, Color.Red);
                    ResaltarElemento(j, Color.Orange);

                    await Task.Delay(DeterminarRetraso());
                }

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
            GenerarGrafica(arr);
            EstaOrdenando(false);
        }
        private async Task BubbleSort(int[] arr, CancellationToken cancellationToken)
        {
            int n = arr.Length;
            int i, j, temp;
            bool swapped;

            for (i = 0; i < n - 1; i++)
            {
                // Check for cancellation
                if (cancellationToken.IsCancellationRequested)
                    return;

                swapped = false;

                for (j = 0; j < n - i - 1; j++)
                {
                    // Check for cancellation
                    if (cancellationToken.IsCancellationRequested)
                        return;

                    if (arr[j] > arr[j + 1])
                    {
                        // Check for cancellation
                        if (cancellationToken.IsCancellationRequested)
                            return;

                        // Intercambia arr[j] y arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                        GenerarGrafica(arr); // Actualiza la gráfica después de cada intercambio

                        ResaltarElemento(j, Color.Red);
                        ResaltarElemento(j + 1, Color.Orange);

                        await Task.Delay(DeterminarRetraso());
                    }
                }
                // Si no hubo intercambios en esta iteración, el arreglo está ordenado y se sale del ciclo
                if (!swapped)
                    break;
            }
            EstaOrdenando(false);
            GenerarGrafica(arr); // Actualiza la gráfica después de cada intercambio
        }
        private async Task InsertionSort(int[] arr, CancellationToken cancellationToken)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                int key = arr[i];
                int j = i - 1;

                GenerarGrafica(arr); // Update the chart before the inner loop starts

                while (j >= 0 && arr[j] > key)
                {
                    if (cancellationToken.IsCancellationRequested)
                        return;

                    arr[j + 1] = arr[j];

                    GenerarGrafica(arr); // Update the chart after each swap
                    ResaltarElemento(j, Color.Red); // Highlight the element being moved
                    await Task.Delay(DeterminarRetraso());

                    j--;
                }

                arr[j + 1] = key;

                GenerarGrafica(arr); // Update the chart after placing the key
                ResaltarElemento(j + 1, Color.Orange); // Highlight the element that was just inserted
                await Task.Delay(DeterminarRetraso());
            }

            EstaOrdenando(false);
            GenerarGrafica(arr); // Update the chart after sorting is completed
        }
        private async Task QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array and get the pivot index
                int pi = await Partition(arr, low, high);

                // Recursively sort elements before and after the pivot
                await QuickSort(arr, low, pi - 1);
                await QuickSort(arr, pi + 1, high);
            }

            EstaOrdenando(false);
            GenerarGrafica(arr); // Update the chart after sorting is completed
        }
        private async Task<int> Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Choose the rightmost element as pivot
            int i = (low - 1); // Index of smaller element

            for (int j = low; j < high; j++)
            {
                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    i++;

                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    GenerarGrafica(arr); // Update the chart after each swap
                    ResaltarElemento(i, Color.Red); // Highlight the element being swapped
                    ResaltarElemento(j, Color.Orange); // Highlight the other element being swapped
                    await Task.Delay(DeterminarRetraso());
                }
            }

            // Swap arr[i+1] and arr[high] (or the pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            GenerarGrafica(arr); // Update the chart after the partition
            ResaltarElemento(i + 1, Color.Green); // Highlight the pivot element's final position
            await Task.Delay(DeterminarRetraso());

            return i + 1;
        }
        #endregion

        #endregion
    }
}
