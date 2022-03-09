using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Model
{
    internal class Producto
    {
        string Codigo;
        string Nombre;
        string Precio;
        string Cantidad;

        public string GetCodigo()
        {
            return Codigo;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetPrecio()
        {
            return Precio;
        }
        public string GetCantidad()
        {
            return Cantidad;
        }

        public void SetCodigo(string Codigo)
        {
            this.Codigo = Codigo;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SetPrecio(string Precio)
        {
            this.Precio = Precio;
        }
        public void SetCantidad(string Cantidad)
        {
            this.Cantidad = Cantidad;
        }

    }




}
