using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo1
    {
        CamposyPropiedades ej1 = new CamposyPropiedades();
        
        public Ejemplo1()
        {
                ej1.Nombre = "Pepe";
            Console.WriteLine(ej1.Nombre);
        }
    }

    public class CamposyPropiedades
    {
        private string nombre;

        public String Nombre { get; set; }

    }
}
