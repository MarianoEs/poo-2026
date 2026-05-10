using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo7
    {
        EntidadBase entidad = new EntidadBase();

        public Ejemplo7()
        {
            //Instancia de la clase base
            entidad.Id = 10;
            Console.WriteLine(entidad.MostrarId());

            //Instancia de la clase derivada
            Producto producto = new Producto();
            producto.Nombre = "Pepe";
            Console.WriteLine(producto.MostrarId());
            Console.WriteLine(producto.MostrarProducto());
           
            producto.Id = 20;
            Console.WriteLine(entidad.MostrarId());
            Console.WriteLine(producto.MostrarProducto());

        }


    }

    public class EntidadBase
    {
        public int Id { get; set; }

        public string MostrarId()
        {
            return $"El Id es: {Id}";
        }
     
    }

    public class Producto : EntidadBase
    {
        public string? Nombre { get; set; }

        public string MostrarProducto()
        {
            return $"El nombre del producto es: {Nombre} con Id: {Id}";
        }
    }
}
