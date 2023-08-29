using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionApp.Entidades
{
    internal class Factura
    {
        public int FacturaNro { get; set; }
        public DateTime Fecha { get; set; }
       
        public string Cliente { get; set; }      
        public List<DetalleFactura> Detalles { get; set; }


        public Factura()
        {
            Cliente = string.Empty;
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int posicion)
        {
            Detalles.RemoveAt(posicion);
        }
        public double CalcularTotal()
        {
            double total = 0;
            
            foreach (DetalleFactura d in Detalles)
            {
                total += d.CalcularSubtotal();
            }
            return total;
        }


    }
}
