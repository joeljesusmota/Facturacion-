using System;

namespace Facturacion
{
    public class Usuario
    {
         string user;
         string password;
        
        public Usuario()
        {  
          user = "chris";
          password = "joel";
        }

        public bool login()
        {
            
            string getUser;
            string getPassword;

            do
            {
                Console.Write("Usuario:");
                getUser = Console.ReadLine();
                Console.Write("Contraseña:");
                getPassword = Console.ReadLine();

                if(getUser!=user | getPassword!=password)
                {
                    Console.WriteLine("Usuario no registrado, intentelo otra vez!");
                }
            }
            while(getUser!=user | getPassword!=password);
            {
                 Console.WriteLine("Bienbenido {0}",getUser);
                 bool validacion = true;
                 return validacion;
            }            
        }
    }
}



/*public string User
        {
            set{ user = value;}
        }  

        public string Password
        {
            set{ password = value;}
        }  */