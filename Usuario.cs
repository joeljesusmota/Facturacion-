using System;

namespace Facturacion
{
    public class Usuario
    {
        #region Atributos 
        private string username;
        private string password;
        private string getUsername;
        private string getPassword;
        private bool validacion;
        #endregion

        public string usernamename{
            get{
                return username;
            }
            set{
                username = value;
            }
        }
        
        public Usuario()
        {  
          username = "chris";
          password = "joel";
          getUsername = "";
          getPassword = "";
        }
        public bool login()
        {
            do
            {
                Console.Write("Usuario:");
                getUsername = Console.ReadLine();
                Console.Write("Contraseña:");
                getPassword = Console.ReadLine();
          
                if(getUsername!=username | getPassword!=password)
                {
                    Console.WriteLine("Usuario no registrado, intentelo otra vez!");
                }
            }
            while(getUsername!=username | getPassword!=password);
            {    
                 Console.WriteLine("****************************************");
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("          Bienbenido {0}",getUsername);
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("****************************************");
                 Console.WriteLine("");
                 validacion = true;
                 return validacion;
            }            
        }
    }
}