using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo4
    {

        PracticaMetodo pcSinArg = new PracticaMetodo();
        PracticaMetodo pc = new PracticaMetodo("Nuevo Pepe");
        PracticaMetodo pcCompleto = new PracticaMetodo("Pepe completo", 50);
        PracticaMetodo pcAntiguedad = new PracticaMetodo(5, "Pepe antiguo");

        public Ejemplo4()
        {
            Console.WriteLine("Constructor SIN firma");
            Console.WriteLine(pcSinArg.Nombre);
            Console.WriteLine(pcSinArg.Edad);
            Console.WriteLine(pcAntiguedad.Antiguedad);

            Console.WriteLine("Constructor CON firma string");
            Console.WriteLine(pc.Nombre);
            Console.WriteLine(pc.Edad);
            Console.WriteLine(pcAntiguedad.Antiguedad);

            Console.WriteLine("Constructor CON firma string e int");
            Console.WriteLine(pcCompleto.Nombre);
            Console.WriteLine(pcCompleto.Edad);
            Console.WriteLine(pcAntiguedad.Antiguedad);

            Console.WriteLine("Constructor CON firma int e string");
            Console.WriteLine(pcAntiguedad.Nombre);
            Console.WriteLine(pcAntiguedad.Edad);
            Console.WriteLine(pcAntiguedad.Antiguedad);
        }
    

        public class PracticaMetodo
        {

            #region Propiedades

            public string? Nombre { get; set; } = "Pepe por defecto";
            public int Edad { get; set; }
            public int Antiguedad { get; set; } = 0;
            #endregion


            #region Constructores
            public PracticaMetodo()
            {
                //Nombre = "Pepe";
                Edad = 20;
            }

            public PracticaMetodo(string nombre) : this()
            {
                Nombre = nombre;
            }

            public PracticaMetodo(string nombre, int edad) //: this()
            {
                Nombre = nombre;
                Edad = edad;
            }

            public PracticaMetodo(int antiguedad, string nombre) //: this()
            {
                Nombre = nombre;
                Antiguedad = antiguedad;
            }
            #endregion

            #region metodos
            public void RestarAntiguedad()
            {
                Antiguedad--;
            }

            public bool EsMayorDeEdad()
            {
                return Edad >= 18;
            }

            public string EsMayorDeEdad(int edadAComparar)
            {
                if (Edad >= edadAComparar)
                {
                    return $"Es mayor o igual a {edadAComparar}";
                }
                else
                {
                    return $"Es menor a {edadAComparar}";
                }
            }

            #endregion

        }

    }
}
