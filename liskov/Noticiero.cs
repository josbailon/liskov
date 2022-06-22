using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov
{
    //clase hija
    class Noticiero : Principal
    {
        //constructor de noticiero resive un mensaje y el mensaje se lo envia a la clase padre
        public Noticiero(string pMensaje) : base(pMensaje)
        {

        }
        //polimorfismo
        public override void Muestra()
        {
            Console.WriteLine(" desde el noticiero : {0} ", mensaje);
        }

    }
}
