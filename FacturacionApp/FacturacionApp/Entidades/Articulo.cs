using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionApp.Entidades
{
    internal class Articulo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Articulo(string nombre, double precio) { Nombre = string.Empty; Precio = 0; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}