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
            int x = 10;
            Console.WriteLine($"Antes de llamar al metodo Valor {x}");

            tt.Valor(x);

            Console.WriteLine($"Despues de llamar al metodo Valor {x}");
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
    }
}
