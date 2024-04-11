using System;
using System.Windows.Forms;

namespace visualizador_de_algoritmos
{
    public partial class frmVisualizar : Form
    {
        int elementos = 10;        
        int[] numerosGenerados;
        int velocidadDeReproducion = 1;
        bool estaReproduciendo = false;

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
        private void ActualizarGrafica(int[] arr)//Muestra los valores en la grafica
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
        private void HabilitarBotones()
        {
            btnFinal.Enabled = true;
            btnInicio.Enabled = true;
            btnReproducir.Enabled = true;
            btnBarajear.Enabled = true; 
            tbVelocidad.Enabled = true;
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
        private void DetenerTimer()
        {
            //Detiene el timer
            timer.Stop();
            estaReproduciendo = false;
        }
        private void ElegirAlgoritmo(int[] arr)//Elige el algoritmo a utilizar en base al texto del combobox
        {
            switch (cmbAlgoritmo.Text)
            {
                case "SELECTION SORT":
                    SelectionSort(arr);
                    break;

                case "BUBBLE SORT":
                    BubbleSort(arr);
                    break;

                default:
                    break;
            }
        }

        #region Algoritmos de Ordenamiento

        private void SelectionSort(int[] arr)
        {

        }

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            int i, j, temp;
            bool swapped;

            for (i = 0; i < n - 1; i++)
            {                
                //Actualizar la grafica despues de cada cambio
                ActualizarGrafica(arr);

                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Intercambia arr[j] y arr[j+1]
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
            #endregion

            #endregion

        #region Eventos
        private void BtnBarajear_Click(object sender, EventArgs e)
        {
            GenerarNumerosAleatorios(tbNumeroDeElementos.Value);

            ActualizarGrafica(numerosGenerados);//Se vuelve a generar los valores 

            DetenerTimer();
        }
        private void BtnReproducir_Click(object sender, EventArgs e)
        {
            if (!estaReproduciendo)
            {
                //cambia el icono a pausa
                btnReproducir.IconChar = FontAwesome.Sharp.IconChar.Pause;
                
                //Empieza el timer
                timer.Start();
                estaReproduciendo = true;
            }
            else //estaReproduciendo
            {
                //cambia el icono a reproducir
                btnReproducir.IconChar = FontAwesome.Sharp.IconChar.Play;

                //Detiene el timer
                timer.Stop();
                estaReproduciendo=false;
            }
        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            DetenerTimer();

            ActualizarGrafica(numerosGenerados);//Vuelve a mostrar el array original
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
            
            DetenerTimer();

        }
        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotones();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ElegirAlgoritmo(CopiarValores(numerosGenerados));
        }
        #endregion
    }
}
