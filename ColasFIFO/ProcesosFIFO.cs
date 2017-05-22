using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class ProcesosFIFO
    {
        static Random numeroRandom = new Random();
        Proceso primerProceso;
        Proceso ultimo;
        Proceso Nuevo;

        string atendidos = "";
        int contEspera = 0;

        public ProcesosFIFO()
        {
            primerProceso = null;
            ultimo = null;
        }


      
        

        public Proceso peek()
        {
            return primerProceso;
        }

        public void Enqueue(Proceso nuevo)
        {

            if (primerProceso == null)
            {
                primerProceso = nuevo;
            }
            else
            {
                Proceso temporal = primerProceso;
                ultimo = nuevo;

                while (temporal.siguiente != null)
                {
                    temporal = temporal.siguiente;

                }

                temporal.siguiente = ultimo;

            }
        }


        //if (primerProceso == null)
        //{
        //    primerProceso = nuevo;
        //    ultimo = nuevo;
        //}
        //else
        //{
        //    ultimo.siguiente = nuevo;
        //    nuevo.anterior = ultimo;
        //    ultimo = nuevo;

        //}

        public Proceso Denqueue(Proceso nuevo)
        {

            Proceso temporal = primerProceso;

            primerProceso = primerProceso.siguiente;

            return temporal;
        }

        public int enEspera()
        {

            string str = " ";

            Proceso t = primerProceso;

            while (t.siguiente != null)
            {
                contEspera++;
                str += t.ToString();
                t = t.siguiente;
            }
               return contEspera;
            }
        
        public override string ToString()
        {
            string str = " ";

            Proceso t = primerProceso;

            while (t.siguiente != null)
            {
              
                str += t.ToString();
                t = t.siguiente;

            }
            return str;
        }


    }
}


//for (int i = 1; i < 200; i++)
//{
//    Proceso Nuevo = new Proceso(cont);

//    int random = numeroRandom.Next(1, 100);

//    if (randomAtendido == 0)
//    {
//        randomAtendido = numeroRandom.Next(4, 14);
//    }
//    if (randomAtendido == contAtendido)
//    {

//        atendidos += "Proceso:" + primerProceso.proceso + " Atendido"+" Tiempo "+(i)+ ":"+ randomAtendido + "\r\n" + "\r\n"; ;
//        primerProceso = primerProceso.siguiente;
//        contAtendido = 0;
//        randomAtendido = 0;

//    }

//    if(random <= 25)
//    {
//        if (primerProceso == null)
//        {
//            primerProceso = Nuevo;
//            cont++;
//        }
//        else
//        {
//            Proceso temporal = primerProceso;


//            while (temporal.siguiente != null)
//            {
//                temporal = temporal.siguiente;

//            }

//            temporal.siguiente = Nuevo;
//            cont++;
//            contAtendido++;
//        }
//    }
//}