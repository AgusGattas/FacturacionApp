using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionApp.Entidades
{
    internal class DetalleFactura
    {
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

        public DetalleFactura(Articulo articulo, int cantidad)
        {
            Articulo = articulo;
            Cantidad = cantidad;
        }

        public double CalcularSubtotal()
        {
            return Cantidad * Articulo.Precio;
        }
    }
}
