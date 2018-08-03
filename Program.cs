using System;

namespace Facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
           Usuario us = new Usuario();
           bool vl = us.login();
           Factura ft = new Factura(); 
           ft.getFactura(vl);
        }
    }
}
