using System;
/* 
using System.Collections.Generic;
using System.Linq;
using System.Text;*/

namespace Facturacion
{
    public class Productos
    {
       
        public Productos()
        {} 
        public void getProductos()
        {
          string[] nombres = new string[5];
          int[] edad = new int[5];
          int edadCap = 0;

          for(int i = 0; i < nombres.Length; i++)
          {
              Console.WriteLine("Ingrese el nombre de la persona" + (i+1));
              nombres[i] = Console.ReadLine();

               while(int.TryParse(Console.ReadLine(), out edadCap))
                  Console.WriteLine("Ingrese la edad de" + nombres[i]);
                edad[i] = edadCap;

                Console.Clear();
          } 

          Console.WriteLine("Las personas mayores de edad son");

          for(int j = 0 ; j < nombres.Length; j++)
          {
              if(edad[j] >=18)
                Console.WriteLine(nombres[j] + "con" + edad[j] + "años.");
          }

         

        }
    }
}




         /*string a = "";

            do{
            Console.Write("Inserte productos");
             a =Console.ReadLine();
            string Nombre = a;
            string[] Productos = new string[] {Nombre};
            string b = Productos[0]; 
            for(int i = 0; i < Productos.Length; i++)
            {
                 Console.WriteLine(Productos[i]);
            }

            }
            while(Nombre!="x");
            {    
                    foreach (int i in Productos[i])
                    {
                    Console.Write(i + " ");
                    }  
            }
           */


           