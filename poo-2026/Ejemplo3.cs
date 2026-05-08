using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo3
    {
        PracticaConstructor pcSinArg = new PracticaConstructor();
        PracticaConstructor pc = new PracticaConstructor("Nuevo Pepe");
        PracticaConstructor pcCompleto = new PracticaConstructor("Pepe completo", 50);

        public Ejemplo3()
        {
            Console.WriteLine("Constructor SIN firma");
            Console.WriteLine(pcSinArg.Nombre);
            Console.WriteLine(pcSinArg.Edad);

            Console.WriteLine("Constructor CON firma string");
            Console.WriteLine(pc.Nombre);
            Console.WriteLine(pc.Edad);

            Console.WriteLine("Constructor CON firma string e int");
            Console.WriteLine(pcCompleto.Nombre);
            Console.WriteLine(pcCompleto.Edad);
        }
    }

    public class  PracticaConstructor
    {
        public string? Nombre { get; set; } = "Pepe por defecto";
        public int Edad { get; set; }

        public PracticaConstructor()
        {
            //Nombre = "Pepe";
            Edad = 20;
        }

        public PracticaConstructor(string nombre) : this()
        {
            Nombre = nombre;
        }

        public PracticaConstructor(string nombre, int edad) //: this()
        {
            Nombre = nombre;
            Edad = edad;
        }

        public PracticaConstructor(int edad, string nombre) //: this()
        {
            Nombre = nombre;
            Edad = 20;
        }
    } 
}
