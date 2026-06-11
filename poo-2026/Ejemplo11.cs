using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo11
    {
        int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
        //int[] num = Enumerable.Range(1, 5).ToArray();

        Provincia[] provincias = new Provincia[5]
        {
            new Provincia() { Cod = "01", Nombre = "Buenos Aires", CantHabitantes = 15625084 },
            new Provincia() { Cod = "02", Nombre = "Córdoba", CantHabitantes = 258021 },
            new Provincia() { Cod = "03", Nombre = "Santa Fe", CantHabitantes = 3500000 },
            new Provincia() { Cod = "04", Nombre = "Mendoza", CantHabitantes = 2000000 },
            new Provincia() { Cod = "05", Nombre = "Tucumán", CantHabitantes = 100000 }
        };

        ProvinciaCiudad[] provinciasCiudad = new ProvinciaCiudad[]
        {
            new ProvinciaCiudad()
            {
                Cod = "x", Nombre = "Córdoba", CantHabitantes= 2514,
                Ciudades = ["Córdoba", "Cruz del Eje"]
            },
            new ProvinciaCiudad() { Cod = "c", Nombre = "CABA", CantHabitantes= 50000 },
            new ProvinciaCiudad()
            {
                Cod = "b", Nombre = "Buenos Aires", CantHabitantes = 2358785,
                Ciudades = ["La Plata", "Mar del Plata", "Bahía Blanca"]
            },
            new ProvinciaCiudad() { Cod = "s", Nombre = "Santa Fe", CantHabitantes = 2500000 },
            new ProvinciaCiudad() { Cod = "m", Nombre = "Mendoza", CantHabitantes = 150000 }
        };

        List<Provincia> provinciasList = new List<Provincia>();

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

            //var ProvMenos1000000 = provincias.Where(p => p.CantHabitantes < 1000000).ToList();

            //Ejecución diferida: se ejecuta la consulta cada vez que se itera sobre el resultado

            //if (numeros[2] == 0)
            //{
            //    Console.WriteLine("pepe");
            //    Console.WriteLine("si");
            //}

            //var numerosPares = numeros.Where(n =>
            //{
            //    Console.WriteLine($"Evaluando si es par {n}");
            //    return n % 2 == 0;

            //}); //.ToList();

            //Console.WriteLine("Empezando");
            //foreach (var item in numerosPares)
            //{
            //    Console.WriteLine($"Numero par {item}");
            //}


            //CONSULTAS COMPLEJAS
            var provinciasConsulta = provincias.Where(p => p.CantHabitantes > 1000000
                                                        && p.Nombre.Substring(0, 1) == "C").ToList();


            var provinciaPrimera = provincias.First();
            //var provinciaPrimerav = provinciasList.First(); //error
            var provinciaPrimeraLista = provinciasList.FirstOrDefault(); //Primero de carga

            int[] pepe = { }; // Array de enteros
            var numero = pepe.FirstOrDefault();

            string[] caracteres = { };
            var letra = caracteres.FirstOrDefault();

            var provincia = provincias?
                .Where(p => p.CantHabitantes < 2000000
                            && p.Nombre.Substring(0, 1) == "C")
                .FirstOrDefault();

            var provincia1 = provincias?
                .FirstOrDefault(p => p.CantHabitantes < 2000000
                            && p.Nombre.Substring(0, 1) == "C");

            var provinciasCons = (provincias
                         .OrderByDescending(p => p.Nombre)
                         .ToList());

            var num1 = numeros
                .OrderDescending()
                .ToList();

            var provinciasCons2 = (provincias
                .Where(p => p.CantHabitantes < 2000000
                            && p.Nombre.Substring(0, 1) == "C")
                .OrderByDescending(p => p.Nombre)
                .ToList())
                .FirstOrDefault();

            var provinciasCons3 = (provincias
                .Where(p => p.CantHabitantes < 2000000
                            && p.Nombre.Substring(0, 1) == "C")
                .OrderDescending()
                .ToList())
                .FirstOrDefault();

            var numerosOrdenados = numeros.OrderByDescending(n => n).ToList();

            ////SELECT
            ///
            var nomProvincias = provincias
                                 .Select(p => p.Nombre)
                                 .ToList();

            var nombreCodProvincias = provincias
                                        .Select(p => new
                                        {
                                            Codigo = p.Cod,
                                            Nombre = p.Nombre,
                                            pepe = "pepe"
                                        })
                                        .ToList();

            var numerosAlCuadrado = numeros.Select(n => n * n).ToList();


            var provIndice = provincias
                .Select((provincia, indice) => new
                {
                    Indice = indice,
                    Nombre = provincia.Nombre
                });

            var provOrdenDesc =
                (
                    provincias
                        .Select((provincia, indice) => new
                        {
                            Orden = indice + 1,
                            Nombre = provincia.Nombre
                        })
                )
                .OrderByDescending(o => o.Orden)
                .ToList();

            var ciudades = provinciasCiudad
                .Select(p => p.Ciudades)
                .ToList();

            var ciudadesMany = provinciasCiudad
                .SelectMany(p => p.Ciudades)
                .ToList();

            int[] arreglo = { 100, 222 };

            var productoCartesiano = provincias
                                    .SelectMany(p => arreglo, (provincia, numero) =>
                                    new
                                    {
                                        Provincia = provincia,
                                        Numero = numero
                                    });

            //foreach (var item in productoCartesiano)
            //{
            //    Console.WriteLine($"{item.Provincia.Nombre} - {item.Numero}");
            //}

            Console.WriteLine($"cantidad de números {numeros.Count()}");
            Console.WriteLine($"cantidad de números {numeros.LongCount()}");
            Console.WriteLine($"cantidad de provincias {provincias.Count()}");

            Console.WriteLine($"suma de números {numeros.Sum()}");
            Console.WriteLine($"suma de habitantes {provincias.Sum(p => p.CantHabitantes)}");

            Console.WriteLine($"número mínimo {numeros.Min()}");
            Console.WriteLine($"Provincia con num. minimo de habitantes {provincias
                                                        .MinBy(p => p.CantHabitantes)!
                                                        .Nombre}");


            Console.WriteLine($"número máximo {numeros.Max()}");
            Console.WriteLine($"Provincia con num. máximo de habitantes {provincias
                                                        .Max(p => p.CantHabitantes)}");
            Console.WriteLine($"Provincia con num. máximo de habitantes {provincias
                                                        .MaxBy(p => p.CantHabitantes)!
                                                        .Nombre}");

            Console.WriteLine($"PROMEDIO DE NÚMEROS {numeros.Average()}");
            Console.WriteLine($"Promedia de habitantes {provincias
                                                        .Average(p => p.CantHabitantes)}");



            Console.WriteLine($"cantidad de provincias que empiezan con C {provincias
                                  .Count(p => p.Nombre.Substring(0, 1) == "C")}");

            Console.WriteLine($"cantidad de provincias que empiezan con C {provincias?
                                  .Where(p => p.Nombre.Substring(0, 1) == "C")
                                  .Count()}");
            

        }

        public class ProvinciaCiudad : Provincia
        {
            public string[] Ciudades { get; set; } = [];

        }

    }
}
    
    