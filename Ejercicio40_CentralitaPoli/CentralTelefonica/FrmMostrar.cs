using Ejercicio40_CentralitaPoli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTelefonica
{
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        TipoLlamada tipoLlamada;
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;          
        }

        public TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch (tipoLlamada)
            {
                case TipoLlamada.Local:
                    rtbMostrar.AppendText($"Se facuraron: {centralita.GananciasPorLocal.ToString()}");
                    break;
                case TipoLlamada.Provincial:
                    rtbMostrar.AppendText($"Se facuraron: {centralita.GananciasPorProvincial.ToString()}");
                    break;
                case TipoLlamada.Todas:
                    rtbMostrar.AppendText($"Se facuraron: {centralita.GananciasPortotal.ToString()}");
                    break;
            }
        }
    }
}
