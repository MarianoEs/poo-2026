using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
   
    public class Ejemplo8
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        int[] numerosSinDatos = {};
        string[] palabras = { "Hola", "Mundo", "C#", "Programación" };
        string[] nombres = {};
        DateTime[] fechas = { new DateTime(2020, 1, 1), new DateTime(2021, 2, 15), new DateTime(2022, 3, 30) };

        public Ejemplo8()

        {
            #region Metodos y Clases genericas

            //Util.Imprimir($"Cantidad de números: {Utilidades.CantidadDeElementos(numeros)}");
            //Util.Imprimir($"Cantidad de números: {Utilidades.CantidadDeElementos(palabras)}");
            //Util.Imprimir($"Cantidad de números: {Utilidades.CantidadDeElementos(fechas)}");


            //Util.Imprimir($"Cantidad de números: {Utilidades.CantidadDeElementos<int>(numeros)}");
            //Util.Imprimir($"Cantidad de palabras: {Utilidades.CantidadDeElementos<string>(palabras)}");
            //Util.Imprimir($"Cantidad de fechas: {Utilidades.CantidadDeElementos<DateTime>(fechas)}");

            //UtilidadesArrgelo<int> utilInt = new UtilidadesArrgelo<int>();
            //Util.Imprimir($"Primer elemento o valor por defecto: {utilInt.PrimerElementoOValorPorDefecto(numeros)}");
            //Util.Imprimir($"Primer elemento o valor por defecto: {utilInt.PrimerElementoOValorPorDefecto(numerosSinDatos)}");

            //Console.WriteLine("---------------------------------------------");

            //UtilidadesArrgelo<string> utilString = new UtilidadesArrgelo<string>();
            //Util.Imprimir($"Primer elemento o valor por defecto: {utilString.PrimerElementoOValorPorDefecto(palabras)}");
            //Util.Imprimir($"Primer elemento o valor por defecto: {utilString.PrimerElementoOValorPorDefecto(nombres)}");

            //Console.WriteLine("---------------------------------------------");

            //UtilidadesArrgelo<DateTime> utilfecha = new UtilidadesArrgelo<DateTime>();
            //Util.Imprimir($"Primer elemento o valor por defecto: {utilfecha.PrimerElementoOValorPorDefecto(fechas).ToString("dd/MM/yy")}");

            //Util.Imprimir($"Ultimo elemento o valor por defecto: {utilfecha.UltimoElementoOValorPorDefecto(fechas).ToString("dd/MM/yy")}");
            #endregion

            #region Control de Restricciones

            UtilidadesArrgelo<IVehiculo> utilVehiculo = new UtilidadesArrgelo<IVehiculo>();

            UtilidadesArrgelo<Auto> utilAuto = new UtilidadesArrgelo<Auto>(); 
            #endregion
        }
    }

    public static class Utilidades
    {
       // public static int CantidadDeElementos(int [] arreglo) 
       // {
       //     return arreglo.Length;
       // }
       //
       // public static int CantidadDeElementos(string[] arreglo)
       // {
       //     return arreglo.Length;
       // }

       // public static int CantidadDeElementos(DateTime[] arreglo)
       // {
       //     return arreglo.Length;
       // }

         public static int CantidadDeElementos<T>(T[] arreglo)
          {
              return arreglo.Length;
          }
    }

    //public class UtilidadesArrgelo<T>
    //public class UtilidadesArrgelo<T> where T : struct
    //public class UtilidadesArrgelo<T> where T : new()
    //public class UtilidadesArrgelo<T> where T : class
    public class UtilidadesArrgelo<T> where T : IVehiculo, new()
    {
        public T PrimerElementoOValorPorDefecto(T[] arreglo) 
        {
            if (arreglo.Length > 0) 
            {
                return arreglo[0];
            }
            else 
            {
                return default (T);
            }
        }

        public T UltimoElementoOValorPorDefecto(T[] arreglo)
        {
            if (arreglo.Length > 0)
            {
                return arreglo[arreglo.Length - 1];
            }
            else
            {
                return default(T);
            }
        }
    }
    public class IVehiculo : IVhiculo
    {


    }

    public class Auto : IVehiculo
    {
        private string Marca;
        public Auto (string marca)
        {
            Marca = marca;
        }
        public Auto()
        {
            
        }



    }

}
