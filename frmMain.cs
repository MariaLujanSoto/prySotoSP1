using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace prySotoSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearArch_Click(object sender, EventArgs e)
        {
            
            try
            {
                StreamWriter swCrearArchivo = new StreamWriter("Archivo1", false);

                MessageBox.Show("Archivo creado");
            }
            catch (Exception)
            {

                MessageBox.Show("Error de Archivo");
                ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("Archivo1", true);

                swManejoArchivo.WriteLine(txtDatos.Text);

                swManejoArchivo.Close();
                MessageBox.Show("Archivo Grabado");
                txtDatos.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de Grabacion"+ ex.Message);
                txtDatos.Text = "";

            }
        }

        private void btnLeerArch_Click(object sender, EventArgs e)
        {
            StreamReader srManejoArchivo = new StreamReader("Archivo1");

            while (srManejoArchivo.EndOfStream == false)
            {
                txtDatos.Text += srManejoArchivo.ReadLine() + Environment.NewLine;
            }
            srManejoArchivo.Close();
        }
    }
}
