using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace poo_2026
{

    public class Ejemplo5
    {
        //public Ejemplo5()  // Constructor
       // {
            //PersonaBD personaBD = new PersonaBD();
            //personaBD.ObtenerPersona(1);

            //Console.WriteLine("---------------------------------------------");

            //PersonaLista pLista = new PersonaLista();
            //pLista.ObtenerPersona(2);

           // Console.WriteLine("---------------------------------------------");

        //}
            public void EjecutarBuscarPersona(IBuscarPersona bp, int id)
            {
                bp.ObtenerPersona(id);
            }
        public  IBuscarPersona EjecutarBuscarPersona(tipoBusqueda tipo)
        {
            switch (tipo)
            {
                case tipoBusqueda.BaseDatos:
                    return new PersonaBD();
                case tipoBusqueda.Lista:
                    return new PersonaLista();
                default:
                    throw new ArgumentException("Tipo de busqueda no valido");
            }
        }

    }

    public class PersonaBD : IBuscarPersona
    {
        public void ObtenerPersona(int id)
        {
            // Simulamos la obtencion de una persona desde la base de datos
            Console.WriteLine($"Obteniendo persona id = {id} de la base de datos...");
        }
    }

    public class PersonaLista : IBuscarPersona
    {
        public void ObtenerPersona(int id)
        {
            // Simulamos la obtencion de una persona desde una lista
            Console.WriteLine($"Obteniendo persona id = {id} desde una lista...");
        }
    }

    //Interfase
    public interface IBuscarPersona
    {
        void ObtenerPersona(int id);
    }

    //Enumeracion
    public enum tipoBusqueda
    {
        BaseDatos,
        Lista
    }


}
