using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace poo_2026
{
    public class Ejemplo6
    {
        //public static void PruebaStatic()
        // {
        //    Console.WriteLine("Ejemplo 6 metodo static");
        // }

        // public void PruebaNoStatic()
        // {
        //    Console.WriteLine("Ejemplo 6 metodo NO static");
        //}

        public void MetodoConError()
        {

            int res = 0;
            int a = 10;
            try
            {
                res = a / 0;
            }
            catch (Exception e)
            {

                var mensaje = Util.MensajeError("", e, true, true);
                Console.WriteLine(mensaje);
            }
        }

       public void CalculoEdad()
        {
         Console.WriteLine(Util.CalcularEdad(new DateTime(1990, 5, 15)));
         Console.WriteLine("--------------------------------------------");

            var fecha = new DateTime(1990, 5, 15);
         Console.WriteLine($"Edad conExtension: {fecha.CalcularEdad()}");
         Console.WriteLine("--------------------------------------------");
        }

    }

    public static class Util
    {
        public static string MensajeError(string mensaje = "",
                                            Exception? e = null,
                                            bool conTrace = false,
                                            bool conInner = false)
        {
            var msg = mensaje;
            if (e != null)
            {
                if (msg != "")
                {
                    msg = msg + "\r\n";
                }

                msg = $"{msg} Mensaje: {e.Message}";

                if (conTrace)
                {
                    msg = $"{msg} + \r\n Trace: {e.StackTrace}";

                }

                if (conInner && e.InnerException != null)
                {
                    msg = $"{msg} + \r\n Inner: {e.InnerException.Message}";
                }
            }

            return msg;

        }

        public static int CalcularEdad(this DateTime fechaNacimiento,
                                        DateTime? fecha = null)
        {
            var fechaCalculo = (fecha ?? DateTime.UtcNow).Date;
            var nacimiento = fechaNacimiento.ToUniversalTime();
            var edad = fechaCalculo.Year - fechaNacimiento.Year;
            if (fechaNacimiento > fechaCalculo.AddYears(-edad)) edad--;
            {
                edad--;
            }

            return edad;
        }

    }

}
 
