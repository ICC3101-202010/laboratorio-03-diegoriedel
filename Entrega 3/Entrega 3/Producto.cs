using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_3
{
    class Producto
    {
        private string name;
        private int price;
        private string marca;
        private int stock;

        private Producto(string name, int price, string marca, string nation, int stock)
        {
            this.name = name;
            this.price = price;
            this.marca = marca;
            this.stock = stock;
        }

        public Producto()
        {

        }
    }
}
