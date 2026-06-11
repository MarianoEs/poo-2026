using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo10
    {

        public Dictionary<string, Provincia> Provincias { get; set; } = new Dictionary<string, Provincia>();
        public Ejemplo10()
        {
            Provincia p1 = new Provincia() 
            {  
                Cod = "01", 
                Nombre = "Buenos Aires", 
                CantHabitantes = 15625084 
            };
            string clave1 = Guid.NewGuid().ToString(); //clase statica GUID que genera un string unico cada vez que se llama a su metodo NewGuid()
            Provincias.Add(clave1, p1);


            Provincia p2 = new Provincia();
            p2.Cod = "02";
            p2.Nombre = "Córdoba";
            p2.CantHabitantes = 1258021;

            string clave2 = Guid.NewGuid().ToString();
            Provincias[clave2] = p2;

            Console.WriteLine($"Cantidad de elementos: {Provincias.Count.ToString()}");
            Console.WriteLine($"Nombre de la provincia con clave2: {Provincias[clave2].Nombre}");
            Console.WriteLine("-------------------");

            foreach (var item in Provincias)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Cod} - {item.Value.Nombre} - {item.Value.CantHabitantes.ToString()}");
            }
            Console.WriteLine("-------------------");

            foreach (var item in Provincias.Keys)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("-------------------");

            foreach (var item in Provincias.Values)
            {
                Console.WriteLine($"{item.Cod} - {item.Nombre} - {item.CantHabitantes}");
            }
            Console.WriteLine("-------------------");

        }

    }

    public class Provincia 
    {
        public string Cod { get; set; }
        public string Nombre { get; set; }
        public int CantHabitantes { get; set; }

        public override string ToString() 
        {
         return $"{Cod} - {Nombre} - {CantHabitantes}";
        }
    }

}
