using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Stock
    {
        private int _cantidad;
        private Producto _producto;

        public  Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public void Administra()
        {
            ///ingresa-quita productos del stock 
        }

    }
}
