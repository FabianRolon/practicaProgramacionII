using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06
{
    public partial class frmMostrar : Form
    {
        public Persona[] personas;
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < personas.Length; i++)
            {
                lstPersonas.Items.Add(personas[i].Mostrar());
            }
        }
    }
}
