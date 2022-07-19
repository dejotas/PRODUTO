using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Labrillo : Pared
    {     
        public String Nombre { get; set;}
        //public String Modelo { get; set;}
        public String Modelo { get; set;}
       // public int Año { get; set;}

        public Labrillo(String Modelo)
        {
            this.Modelo = Modelo;
          //  this.Año = Año;
        }

        public void doStuf()
        {
            Console.WriteLine(" - Estoy en Labrillo / doStuf()");
            Console.WriteLine("- - Nombre: " + this.Nombre);
            //Console.WriteLine("- - - Año: " + this.Año);
            Console.WriteLine("- - - Modelo: " + this.Modelo);
        }
    }
}
