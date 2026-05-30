using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo9
    {
        public List<int> listaNumeros { get; set; } = new List<int>() 
            { 
                 1, 2, 3, 4, 5 
            
            };

        public List<string> listaNombres { get; set; } = new List<string>()
            {
                "Juan",
                "María",
                "Pedro",
                "Ana",
                "Luis"

            };



        public Ejemplo9() 
        {
            //Console.WriteLine($"Elemento en posicion 3: {listaNumeros[2]}");
            //Console.WriteLine("-------------------------------------");

            //foreach (var item in listaNumeros)
            //{
            //    Console.WriteLine(item);
            //}
            // Console.WriteLine("-------------------------------------");

            //listaNumeros.Add(6);
            //listaNumeros.Add(7);
            //listaNumeros.Add(8);

            //foreach ( var item in listaNumeros)
            // {
            //    Console.WriteLine(item);
            // }
            // Console.WriteLine("-------------------------------------");

            // listaNumeros.RemoveAt(1 ); //elimina el elemento en la posicion 1, es decir el numero 2
            // listaNumeros.Remove(6);
            // listaNumeros.Remove(4);
            // listaNumeros.Remove(8);

            // foreach (var item in listaNumeros)
            // {
            //     Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------------------------");

            // listaNumeros.Clear(); //elimina todos los elementos de la lista
            // foreach (var item in listaNumeros)
            //  {
            //      Console.WriteLine(item);
            //  }


            Console.WriteLine($"Cantidad de elementos: {listaNombres.Count}"); //Lista la cantidad de elementos

            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("-------------------------------------");

            foreach (var item in listaNombres)
                  {
                    Console.WriteLine(item);
                 }

            Console.WriteLine("-------------------------------------");

            listaNombres.Reverse(); // Lista en orden inverso
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");

            listaNombres.Sort(); //Orden Alfabetico por defecto
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");



            listaNombres.Sort(2,2, default); //el metodo sort ordena la lista
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");

            listaNombres.Reverse();
            foreach (var item in listaNombres)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------");




        }


    }
}
