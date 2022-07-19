using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(String[] args)
        {
            List<Form> lista = new List<Form>();            

            lista.Add(new FormBloque("Bloque prensado"));
            lista.Add(new FormBloque("Bloque solido"));
            lista.Add(new FormLabrillo("Ladrillo cocido de tierra"));
            lista.Add(new FormLabrillo("Ladrillo decorativo cara vista"));
            lista.Add(new FormLabrillo("Ladrillo refractario"));

            foreach (Form form in lista)
            {
                form.SomeOperation();
            }

        }
    }
}