using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Bloque : Pared
    {
        public String Nombre { get; set; }
        //public String Marca { get; set; }
        public String Modelo { get; set; }
        public Bloque(String Modelo)
        {
            this.Modelo = Modelo;
        }

        public void doStuf()
        {
            Console.WriteLine("- Estoy en Bloque / doStuf()");
            Console.WriteLine("- - Nombre:" + this.Nombre);
            Console.WriteLine("- - - Modelo: " + this.Modelo);
        }
    }
}
