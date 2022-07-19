using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public abstract class Form
    {
        public String Nombre { get; set; }
        public Form(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SomeOperation()
        {
            Console.WriteLine("Se ejecuta: SomeOperation()");
            Pared product = CreateProduct(Nombre);
            product.doStuf();

        }
        public abstract Pared CreateProduct(String Nombre);
    }
    }

