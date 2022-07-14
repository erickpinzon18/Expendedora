using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    internal class Producto
    {
        private int Clave;
        private string nombre;
        private double Precio;
        private int Stock;
        private double TotVenta;

        public int Clave1 { get => Clave; set => Clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public int Stock1 { get => Stock; set => Stock = value; }
        public double TotVenta1 { get => TotVenta; set => TotVenta = value; }
    }
}