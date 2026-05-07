using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo2
    {

        //pasar un argumento por valor
        private Tipos tt = new Tipos();
        public Ejemplo2()
        {
            // int x = 10;
            // Console.WriteLine($"Antes de llamar al metodo Valor {x}");
            //tt.Valor(x);
            //Console.WriteLine($"Despues de llamar al metodo Valor {x}");

            //pasar un argumento por referencia
            Pepe p = new Pepe();
            p.Numero = 5;
            Console.WriteLine ($"Antes de llamar al metodo Referencia {p.Numero}");
            tt.Referencia(p);
            Console.WriteLine($"Despues de llamar al metodo Referencia {p.Numero}");
        }
    }

    public class Tipos
    {
        public void Valor(int x)
        {
            Console.WriteLine($"Al inicio del metodo Valor {x}");

            x = x + 1000;

            Console.WriteLine($"Al final del metodo Valor {x}");
        }

        public void Referencia(Pepe p)
        {
            Console.WriteLine($"Al inicio del metodo Referencia {p.Numero}");
            p.Numero = p.Numero + 1000;
            Console.WriteLine($"Al final del metodo Referencia {p.Numero}");
        }
    }

    public class Pepe 
    {
        public int Numero { get; set; }
    }
}
