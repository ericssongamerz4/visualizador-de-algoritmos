using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace visualizador_de_algoritmos
{
    public partial class frmCodigo : Form
    {
        //Se crea la cadena de conexion a la base de datos
        readonly string cadenaConexion = @"URI=file:" + Application.StartupPath + "\\algoritmos.s3db";

        public frmCodigo()
        {
            InitializeComponent();
            MostrarAlgoritmosDisponibles(cmbAlgoritmo);
        }

        #region Metodos
        public void MostrarAlgoritmosDisponibles(ComboBox comboBox)
        {
            comboBox.Items.Clear();//Limpiar elementos del combobox
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT ALGORITMO FROM CODIGO";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception v) { MessageBox.Show("Error: " + v, "Aviso", MessageBoxButtons.OK); Close(); }
        }
        private void MostrarCodigo()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion))
                {
                    connection.Open();

                    string query = "SELECT CSHARP,PYTHON,JAVASCRIPT FROM CODIGO WHERE ALGORITMO=@ALGORITMO";

                    using (var cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ALGORITMO", cmbAlgoritmo.Text);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtCodigoCSharp.Text = reader.GetString(0);
                                txtCodigoPython.Text = reader.GetString(1);
                                txtCodigoJavascript.Text = reader.GetString(2); 
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception v) { MessageBox.Show("Error: " + v, "Aviso", MessageBoxButtons.OK); Close(); }
        }
        private void CopiarCodigo()
        {
            // Copia el codigo dependiendo del lenguaje de programacion elegido

            if (tbLenguajesDeProgramacion.SelectedTab == tabPageCSharp)
            {
                Clipboard.SetText(txtCodigoCSharp.Text + " ");
            }
            else if (tbLenguajesDeProgramacion.SelectedTab == tabPagePython)
            {
                Clipboard.SetText(txtCodigoPython.Text + " ");
            }
            else if (tbLenguajesDeProgramacion.SelectedTab == tabPageJavascript)
            {
                Clipboard.SetText(txtCodigoJavascript.Text + " ");
            }
        }
        #endregion

        #region Eventos
        private void BtnCopiarCodigo_Click(object sender, EventArgs e)
        {
            //Copiar codigo a portapapeles
            CopiarCodigo();               

            //Actualizar el icono y tooltip
            btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            toolTip1.SetToolTip(btnCopiarCodigo, "Código copiado");

            //Empezar el temporizador para reiniciar el icono del boton y el tooltip
            timer1.Interval = 3000;            
            timer1.Start();         
        }
        private void CmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAlgoritmo.Text != null)
            {
                btnCopiarCodigo.Enabled = true;
                MostrarCodigo();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Reiniciar el boton y el tooltip a su estado original
            btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            toolTip1.SetToolTip(btnCopiarCodigo, "Copiar código");
            
            //Detener el temporizador
            timer1.Stop();
        }
        #endregion
    }
}
