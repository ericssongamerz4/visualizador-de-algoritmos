using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace visualizador_de_algoritmos
{
    public partial class frmCodigo : Form
    {
        //Se crea la cadena de conexion a la base de datos
        string cadenaConexion = @"URI=file:" + Application.StartupPath + "\\algoritmos.s3db";
        bool isCodigoCopiado = true;

        public frmCodigo()
        {
            InitializeComponent();
            MostrarAlgoritmosDisponibles();
        }

        private void MostrarAlgoritmosDisponibles()
        {
            cmbAlgoritmo.Items.Clear();//Limpiar elementos del combobox
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
                                cmbAlgoritmo.Items.Add(reader.GetString(0));
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





        //
        //Eventos
        //
        #region Click
        private void btnCopiarCodigo_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
         
            if (isCodigoCopiado)
            {                
                btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
                isCodigoCopiado=false;
         
                Clipboard.SetText(txtCodigoJavascript.Text + " ");                
                toolTip1.SetToolTip(button, "Código copiado");

            }
            else
            {
                btnCopiarCodigo.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
                isCodigoCopiado=true;
                toolTip1.SetToolTip(button, "Copiar código");
            }
        }
        #endregion

        #region Hover
        private void btnCopiarCodigo_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isCodigoCopiado)
            {
                toolTip1.SetToolTip(button, "Copiar código");
            }
            else
            {
                toolTip1.SetToolTip(button, "Código copiado");
            }
        }


        #endregion

        private void cmbAlgoritmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAlgoritmo.Text != null)
            {
                MostrarCodigo();
            }
        }
    }
}
