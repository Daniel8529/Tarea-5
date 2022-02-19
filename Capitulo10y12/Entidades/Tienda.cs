using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo10y12.Entidades
{
    public class Tienda
    {
         public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public float Cantidad { get; set; }
        public float Precio { get; set; }

        public Tienda(int codigo, string descripcion, int cantidad, float precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio=precio;
        }
        
    }
}