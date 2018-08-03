using System;
using System.IO;

namespace Facturacion
{
    public class Factura
    {
       #region Atributos
        private string nameP;
        private string nameC;
        private string description;
        private int quantity;
        private int price;
        private int nProduct;
        private int nFactura;
        private int value;
        private int total;
        private string x;
        private bool y;
       #endregion

        public Factura()
        {}

        public void getFactura(bool vl)
        {
            if(vl == true)
            {
                nFactura ++;
            // TextWriter archivo;
            //archivo = new StreamWriter("archivo.txt");
                Console.WriteLine("'x' para cerrar la factura");
                StreamWriter getFacturaFile = File.AppendText("facturaFile.txt");
                getFacturaFile.WriteLine("*************** Factura: #{0} **************",nFactura);
                getFacturaFile.WriteLine("Colmado Jose Luis");
                getFacturaFile.WriteLine("Tel: 809-456-4564 | Cel: 829-456-7841 ");
                getFacturaFile.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                
            do
            {
                nProduct ++;
               
                    //obtener datos
                    Console.WriteLine("Nonbre del producto");
                    nameP = Console.ReadLine();
                    Console.WriteLine("descripcion del producto");
                    description = Console.ReadLine();
                    //Console.WriteLine("precio del producto");
                    //price = Console.Read();
                    //Console.WriteLine("Cantidad");
                    //quantity = Console.Read();

                    //calculo
                   // value = quantity * price;

                    //imprecion
                    getFacturaFile.WriteLine("------------------------------------------");
                    getFacturaFile.WriteLine("Producto: #{0}" ,nProduct);
                    getFacturaFile.WriteLine("Nombre: {0}" ,nameP);
                    getFacturaFile.WriteLine("Descripcion: {0}",description);
                    getFacturaFile.WriteLine("Valor: {0}", value);
                    getFacturaFile.WriteLine("Cantidad: {0}", quantity);
                    getFacturaFile.WriteLine("Total: {0}", total);           
                    
                     // if(nameP == "x");{y=true;}
                     // else{y=false;}
            } 
            while(nameP!="x");
            {
                nProduct=0;
                DateTime thisDay = DateTime.Today;
                Console.WriteLine("Nonbre del cliente");
                nameP = Console.ReadLine();

                getFacturaFile.WriteLine("");
                getFacturaFile.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                getFacturaFile.WriteLine("Nonbre del cliente: {0}",nameC);
                getFacturaFile.WriteLine("Emicion de factura: ",thisDay.ToString());
                getFacturaFile.WriteLine("Valor total:");
                getFacturaFile.WriteLine("");
                getFacturaFile.WriteLine("******************************************");
                getFacturaFile.WriteLine("");
                getFacturaFile.Close();
                Console.Clear();
                
                postFactuta();

                Console.WriteLine("Desea facturar nuevamente?  'y' o 'n'");   
                x = Console.ReadLine();
                if (x == "y"){getFactura(vl);}
                else{Console.WriteLine("bye");}
            }
         }
         else{
             Console.WriteLine("mal");
         }  
        }

        public void postFactuta()
        {
            TextReader readFactura;
            readFactura = new StreamReader("facturaFile.txt");
            Console.WriteLine(readFactura.ReadToEnd());
            readFactura.Close();
        }
    }
}








                /*
                using System.IO.StreamReader;
                
                StreamWriter fichero;
                fichero = File.CreateText("prueba.txt"); 
                
                fichero.WriteLine("esto es una línea");
                fichero.Write("fin de la cita.");
                fichero.Close();

                string linea;
                
                fichero = File.OpenText("prueba.txt");
                linea = fichero.ReadLine();
                fichero.Close();*/





            