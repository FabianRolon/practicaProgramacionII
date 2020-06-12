using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        Thread primerHilo;
        Thread segundoHilo;
        Random r1;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            r1 = new Random();
            ThreadStart ts = new ThreadStart(ModificarHora);
            ThreadStart tsDos = new ThreadStart(ModificarColor);
            primerHilo = new Thread(ts);
            segundoHilo = new Thread(tsDos);
            primerHilo.Start();
            segundoHilo.Start();
        }

        delegate void DelegadoHora();
        public void AgregarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                DelegadoHora d = new DelegadoHora(AgregarHora);
                this.Invoke(d);
            }
            else
            {
                int c1 = r1.Next(0, 255);
                int c2 = r1.Next(0, 255);
                int c3 = r1.Next(0, 255);
                int x = r1.Next(10, 340);
                int y = r1.Next(10, 300);

                lblHora.Text = DateTime.Now.ToString();
                lblHora.ForeColor = Color.FromArgb(c1, c2, c3);
                lblHora.Location = new Point(x, y);
            }
        }
        delegate void DelegadoColor(int cantidadRojo, int cantidadVerde, int cantidadAzul, int intensidadRojo, int intensidadVerde, int intensidadAzul);
        public void AgregarColor(int cantidadRojo, int cantidadVerde, int cantidadAzul, int intensidadRojo, int intensidadVerde, int intensidadAzul)
        {
            if (this.InvokeRequired)
            {
                DelegadoColor d = new DelegadoColor(AgregarColor);
                object[] objs = new object[] { cantidadRojo, cantidadVerde, cantidadAzul, intensidadRojo, intensidadVerde, intensidadAzul };
                this.Invoke(d, objs);
            }
            else
            {
                this.BackColor = Color.FromArgb(intensidadRojo, intensidadVerde, intensidadAzul);
            }
        }
        public void ModificarHora()
        {
            do
            {
                AgregarHora();

                Thread.Sleep(1000);
            } while (true);
        }
        public void ModificarColor()
        {
            int cantidadRojo = 255;
            int cantidadVerde = 64;
            int cantidadAzul = 0;
            int intensidadRojo = 255;
            int intensidadVerde = 64;
            int intensidadAzul = 0;
            do
            {
                AgregarColor(cantidadRojo, cantidadVerde, cantidadAzul, intensidadRojo, intensidadVerde, intensidadAzul);
                intensidadRojo = intensidadRojo + cantidadRojo;
                intensidadVerde = intensidadVerde + cantidadVerde;
                intensidadAzul = intensidadAzul + cantidadAzul;

                if (intensidadRojo > 255)
                {
                    intensidadRojo = 255;
                    cantidadRojo = -cantidadRojo;
                }
                else if (intensidadRojo < 0)
                {
                    intensidadRojo = 0;
                    cantidadRojo = -cantidadRojo;
                }


                if (intensidadVerde > 255)
                {
                    intensidadVerde = 255;
                    cantidadVerde = -cantidadVerde;
                }
                else if (intensidadVerde < 0)
                {
                    intensidadVerde = 0;
                    cantidadVerde = -cantidadVerde;
                }


                if (intensidadAzul > 255)
                {
                    intensidadAzul = 255;
                    cantidadAzul = -cantidadAzul;
                }
                else if (intensidadAzul < 0)
                {
                    intensidadAzul = 0;
                    cantidadAzul = -cantidadAzul;
                }
                Thread.Sleep(200);
            } while (true);
        }
    }
}
