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
        private string Nombre;
        private double Precio;
        private int Stock;
        private double totVenta;

        public int Clave1 { get => Clave; set => Clave = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public double Precio1 { get => Precio; set => Precio = value; }
        public int Stock1 { get => Stock; set => Stock = value; }
        public double TotVenta { get => totVenta; set => totVenta = value; }
    }
}
