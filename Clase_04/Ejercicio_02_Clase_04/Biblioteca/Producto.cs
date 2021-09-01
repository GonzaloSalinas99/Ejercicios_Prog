using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca,string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"Codigo de Barra: {p.codigoDeBarra}  Marca: {p.GetMarca()}  Precio: {p.GetPrecio()}";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, Producto p2)
        {
            if(!(p is null || p2 is null))
            {
                string codigoBarra1 = (string)p;
                string codigoBarra2 = (string)p2;

                return (p.GetMarca() == p2.GetMarca() && codigoBarra1 == codigoBarra2);
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Producto p, Producto p2)
        {
            string codigoBarra1 = (string)p;
            string codigoBarra2 = (string)p2;

            return !(p == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (p.GetMarca() == marca);
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p.GetMarca() == marca);
        }





    }
}
