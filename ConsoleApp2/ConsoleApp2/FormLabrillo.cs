using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    
        public class FormLabrillo : Form
        {
            public FormLabrillo(string Nombre) : base(Nombre)
            {
                this.Nombre = Nombre;
            }
            public override Pared CreateProduct(string Nombre)
            {
                Console.WriteLine("- labrillo / CreateProduct()");
                //ProductB product = new ProductB("laptop", 2017);
                Labrillo product = new Labrillo("Karmis");
                product.Nombre = Nombre;
                return product;
            }
        
    }
}
