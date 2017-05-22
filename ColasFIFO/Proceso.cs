using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        private int _proceso;
        private Proceso _siguiente;
        private Proceso _anterior;

        public Proceso(int proceso)
        {
            this.proceso = proceso;
        }
        public int proceso
            {
            get
            {
                return _proceso;
            }
            set
            {
                _proceso = value;
            }
          
            }
        public Proceso siguiente{

            get
            {
                return _siguiente;
            }
            set
            {
                _siguiente = value;
            }
            
            }
        public Proceso anterior
        {

            get
            {
                return _anterior;
            }
            set
            {
                _anterior = value;
            }

        }

        public override string ToString()
        {
            return "Proceso:" + _proceso.ToString() + " "+ "\r\n" + "\r\n"; 
        }

    }
    
}
