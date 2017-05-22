using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasFIFO
{
    public partial class Form1 : Form
    {
       
        int cont = 0;
        static Random numeroRandom = new Random();
        Queue<Proceso> guests = new Queue<Proceso>();
        string espera;
        ProcesosFIFO Fifo = new ProcesosFIFO();
        Proceso nuevo;
        string atendidos = "";
        int contAtendido=0;
        int contVacio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
          
            //Fifo.agregarFifo();
        }

        private void buttonAtendidos_Click(object sender, EventArgs e)
        {
           //textBoxAtendidos.Text=""+Fifo.Atendidos();
        }

        private void buttonEspera_Click(object sender, EventArgs e)
        {
            //textBoxEspera.Text = "" + Fifo.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            for (int i = 1; i < 200; i++)
            {
                int random = numeroRandom.Next(1, 100);
                if (random <= 25)
                {
                    int randomN = numeroRandom.Next(4, 14);
                    nuevo = new Proceso(randomN);
                    Fifo.Enqueue(nuevo);
                }
                    if (Fifo.peek() != null)
                    {
                        Fifo.peek().proceso--;

                        if (Fifo.peek().proceso == 0)
                        {
                            Fifo.Denqueue(Fifo.peek());
                            contAtendido++;
                        }
                    }

                    else
                    {
                        contVacio++;
                    }

                
               


            }
         
            textBoxAtendidos.Text = "Total de procesos atendidos: " + contAtendido + " Ciclos Vacios: " + contVacio + " Total de procesos en espera: " + Fifo.enEspera();
        }



        //int contAtendido = 0;
        //string atendidos = "";
        //int randomAtendido = 0;


        //for (int i = 1; i < 201; i++)
        //{
        //    int random = numeroRandom.Next(1, 100);

        //    if (random <= 25)
        //    {
        //        randomAtendido = numeroRandom.Next(4, 15);
        //        Proceso Nuevo = new Proceso(randomAtendido);
        //        guests.Enqueue(Nuevo);
        //         cont++;
        //         contAtendido++;


        //        if (guests.Peek() != null)
        //        {

        //            atendidos += guests.Dequeue() + "Atendido: " + " Tiempo " + (i) + ":" + "\r\n" + "\r\n"; ;
        //            contAtendido = 0;
        //            randomAtendido = 0;
        //            guests.Peek().proceso--;

        //        }


        //    }
        //}


        //textBoxAtendidos.Text = atendidos;

        //textBoxEspera.Text = EnEspera();


        public string EnEspera()
        {
            string espera = "";
            for (int i = 0; i < guests.Count-1; i++)
            {
               espera +="" + guests.ElementAt(i) +" en espera" + "\r\n" + "\r\n";
            }
            return espera;
        }
    }
}
