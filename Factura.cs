using System;
using System.IO;

namespace Facturacion
{
    public class Factura
    {
       #region Atributos
        private string nameP;
        private string description;
        private int quantity;
        private int price;
        private int nProduct;
        private int nFactura;
        private int value;
        private string x;
        private bool y;
       #endregion

        public Factura()
        {}

        public void getFactura()
        {
            nFactura ++;
          // TextWriter archivo;
           //archivo = new StreamWriter("archivo.txt");
            Console.WriteLine("'x' para cerrar la factura");
           do
            {
                nProduct ++;
                StreamWriter getFacturaFile = File.AppendText("facturaFile.txt");
                Console.WriteLine("Nonbre del producto");
                nameP = Console.ReadLine();
                Console.WriteLine("descripcion del producto");
                description = Console.ReadLine();
                getFacturaFile.WriteLine("------------------------------------------"); 
                getFacturaFile.WriteLine("Nombre producto #{0}: {1}" ,nProduct, nameP);
                getFacturaFile.WriteLine("Descripcion producto #{0}: {1}" ,nProduct, description);
                getFacturaFile.WriteLine("");           
                getFacturaFile.Close();
    
           } 
           while((nameP!="x") || (description!="x"));
           {
             Console.Clear();
             Console.WriteLine("************** Factura: #{0}**************",nFactura);
             postFactuta();

           }
          
        }

        public void postFactuta()
        {
            TextReader readFactura;
            readFactura = new StreamReader("facturaFile.txt");
            Console.WriteLine(readFactura.ReadToEnd());
            readFactura.Close();
        
          Console.WriteLine("Desea facturar nuevamente?  'y' o 'n'");   
             x = Console.ReadLine();
             if (x == "y"){getFactura();}
             else{Console.WriteLine("bye");}
           
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





            