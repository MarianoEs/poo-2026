using System;
using System.Collections.Generic;
using System.Text;

namespace poo_2026
{
    public class Ejemplo7
    {
        //EntidadBase entidad = new EntidadBase();

        public Ejemplo7()
        {
            //Instancia de la clase base
            //entidad.Id = 10;
            //Console.WriteLine(entidad.MostrarId());

            //Instancia de la clase derivada
            Producto producto = new Producto();
            producto.Nombre = "Pepe";
            //Console.WriteLine(producto.MostrarId());
            //Console.WriteLine(producto.MostrarProducto());
           
            producto.Id = 20;
            Console.WriteLine(producto.MostrarId());
            Console.WriteLine(producto.MostrarProducto();
            producto.IncrementarId();
            //producto.MetodoProtegido();

        }


    }

    abstract public class EntidadBase
    {
        public int Id { get; set; }

        public string MostrarId()
        {
            return $"El Id es: {Id}";
        }

        public virtual int IncrementarId()
        {
            Id++;
            return Id;

        }

        protected void MetodoProtegido()
        {
            Console.WriteLine("Protegido");
            
        }

        abstract public int ReiniciarId();

    }

    public class Producto : EntidadBase
    {
        public string? Nombre { get; set;}

        public Producto()
        {
            MetodoProtegido();
        }

        public string MostrarProducto()
        {
            return $"El nombre del producto es: {Nombre} con Id: {Id}";
        }

        public override int ReiniciarId()
        {
            Id = 0;
            return Id;
        }

        public override int IncrementarId()
        {
            Id = Id + 10;
            return Id;
        }


    }

    public class Cliente : EntidadBase
    {
        public string? NombreCliente { get; set; }

        public string MostrarProducto()
        {
            return $"El nombre del Cliente es: {NombreCliente} con Id: {Id}";


        }

        public override int ReiniciarId()
        {
            Id = 0;
            return Id;
        }
    }
}
