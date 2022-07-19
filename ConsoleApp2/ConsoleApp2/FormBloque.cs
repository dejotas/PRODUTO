using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        public class FormBloque : Form
        {
            public FormBloque(string Nombre) : base(Nombre)
            {
                this.Nombre = Nombre;
            }
            public override Pared CreateProduct(string Nombre)
            {
                Console.WriteLine("- FormBloque / CreateProduct()");
                
                Bloque product = new Bloque("Arcof");
                product.Nombre = Nombre;

                return product;
            }
        }

}
