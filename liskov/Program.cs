namespace liskov
{
class Program
{
    static void Main(string[] args)
    {
            // usamos el principio de liskov 

        // tenemos las funciones de principal y lo propio de noticiero
        Principal miNoticiero = new Noticiero("hola todos");
        miNoticiero.Muestra();
            // tenemos los comportamienos de radio y no perdemos los de principal
         Principal miRadio = new Radio("como estan");
        miRadio.Muestra();

        Console.WriteLine("---------");

        
        



    }
}   
    

    }

