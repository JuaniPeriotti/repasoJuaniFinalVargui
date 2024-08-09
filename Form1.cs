using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasoJuaniFinalVargui
{
    public partial class Form1 : Form
    {
        private conexionBD miConexion;
        public Form1()
        {
            InitializeComponent();
            miConexion = new conexionBD(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./HELADITO.mdb;");
            miConexion.abrirConexion();
            miConexion.mostrarGustos(cbGustos);
        }
    }
}
