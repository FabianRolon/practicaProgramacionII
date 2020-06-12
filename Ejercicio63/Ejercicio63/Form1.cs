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
        delegate void DelegadoColor();
        public void AgregarColor()
        {
            if (this.InvokeRequired)
            {
                DelegadoColor d = new DelegadoColor(AgregarColor);
                this.Invoke(d);
            }
            else
            {
                int c1 = r1.Next(0, 255);
                int c2 = r1.Next(0, 255);
                int c3 = r1.Next(0, 255);

                this.BackColor = Color.FromArgb(c1, c2, c3);
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
            do
            {
                AgregarColor();
                Thread.Sleep(100);
            } while (true);
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
    }
}
