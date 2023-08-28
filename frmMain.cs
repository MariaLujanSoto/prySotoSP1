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
            StreamWriter swCrearArchivo = new StreamWriter("Archivo1", false);

            if (swCrearArchivo != null)
                MessageBox.Show("Archivo creado");
        
        
        }
    }
}
