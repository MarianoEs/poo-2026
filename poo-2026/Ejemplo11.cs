using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo11
    {
        int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
        //int[] num = Enumerable.Range(45, 55).ToArray();

        Provincia[] provincias = new Provincia[5]
        {
            new Provincia() { Cod = "01", Nombre = "Buenos Aires", CantHabitantes = 15625084 },
            new Provincia() { Cod = "02", Nombre = "Córdoba", CantHabitantes = 258021 },
            new Provincia() { Cod = "03", Nombre = "Santa Fe", CantHabitantes = 3500000 },
            new Provincia() { Cod = "04", Nombre = "Mendoza", CantHabitantes = 2000000 },
            new Provincia() { Cod = "05", Nombre = "Tucumán", CantHabitantes = 100000 }
        };

        public Ejemplo11()
        {
            //var pepe = num;
            //sintaxis de métodos
            //var numerosPares = numeros.Where(n => n % 2 == 0).ToArray();
            //var numerosMAyorA3 = numeros.Where(n => n > 3);

            //sintaxis de queries
            //var numerosPares = (from n in numeros
            //                    where n % 2 == 0
            //                    select n).ToList();

            var ProvMenos1000000 = provincias.Where(p => p.CantHabitantes < 1000000).ToList();

            //Ejecución diferida: se ejecuta la consulta cada vez que se itera sobre el resultado
            //if (numeros[2] == 0)
            //{
            //    Console.WriteLine("pepe");
            //    Console.WriteLine("si");
            //}

            var numerosPares = numeros.Where(n =>
            {
                Console.WriteLine($"Evaluando si es par {n}");
                return n % 2 == 0;

            }); //.ToList();

            Console.WriteLine("Empezando");
            foreach (var item in numerosPares)
            {
                Console.WriteLine($"Numero par {item}");
            }

        }
    }
}
