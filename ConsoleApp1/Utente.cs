using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Utente
    {
        private static string _username;
        private static string _password;
        private static string _confermaPassword;

        public static string Username { get { return _username; } set { _username = value; } }
        public static string Password { get { return _password; } set { _password = value; } }
        public static string ConfermaPassword { get {  return _confermaPassword; } set { _confermaPassword = value; } }


        public static void Login()
        {
            Console.WriteLine("Inserisci UserName");
            _username = Console.ReadLine();
            Console.WriteLine("Inserisci Password");
            _password = Console.ReadLine();
            Console.WriteLine("Conferma Password");
            _confermaPassword = Console.ReadLine();

            if (_username != null || _password == _confermaPassword)
            {
                Console.WriteLine("Login effettuato con successo");
            }
            else
            {
                Console.WriteLine("Login fallito");
            }
        }

        public static void Logout()
        {
            if(_username != null && _password != null) 
            {
                _username = null; _password = null; _confermaPassword = null;
                Console.WriteLine("Logout eseguito con succeso");
            }
            else
            {
                Console.WriteLine("Fai prima il login");
            }
        }

        public static void MenuPrincipale()
        {
            Console.WriteLine("===============OPERAZIONI==============" + "\n" + "\n");
            Console.WriteLine("Scegli l'operazione da effettuare");
            Console.WriteLine("1) Login");
            Console.WriteLine("2) Logout");
            Console.WriteLine("3) Verifica data e ora del login");
            Console.WriteLine("4) Lista degli accessi");
            Console.WriteLine("Termina programma");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Login();
                    break;
                case 2:
                    Logout(); 
                    break;
                case 3:
                  //  VerificaOraData();
                    break;
                case 4:
                   // ListaAccessoUtenti();
                    break;
                case 5:
                    Console.WriteLine("Sei proprio sicuro di voler terminare il programma?  (y/n)");
                    Console.ReadKey();
                    break;
            }
        }
        
         
    }
}
