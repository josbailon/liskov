using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov
{    
    // clase principal
    // se coloca todo que es constante y no se modifica
    abstract class Principal
    {
        protected string mensaje;

        public Principal (string pMensaje)
        {
            mensaje = pMensaje;
        }
        // creamos metodo abtracto para que cada version lo implemente 
        
        public abstract void Muestra();
    }
}
