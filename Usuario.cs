using System;

namespace Facturacion
{
    public class Usuario
    {
        #region Atributos 
        private string user;
        private string password;
        private string getUser;
        private string getPassword;
        private bool validacion;
        #endregion
        public Usuario()
        {  
          user = "chris";
          password = "joel";
          getUser = "";
          getPassword = "";
        }
        public bool login()
        {
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
                // Console.Clear();
                 Console.WriteLine("Bienbenido {0}",getUser);
                 validacion = true;
                 return validacion;
            }            
        }
    }
}