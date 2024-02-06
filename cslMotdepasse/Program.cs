using libMotdePasse;
using System;

namespace cslMotdepasse
{
    class Program
    {
        static void Main(string[] args)
        {
            string mdp2,mdp,login;

            Console.WriteLine(" Saisir le login");
            login = Console.ReadLine();
            Console.WriteLine(" Saisir le mot de passe");
            mdp = Console.ReadLine();

            Console.WriteLine("Resaisissez le mot de passe");
            mdp2 = Console.ReadLine();

            MotdePasse Mdp = new MotdePasse(login, mdp) ;
            Console.WriteLine(Mdp.Vérifier(mdp2));

            if (Mdp.Vérifier(mdp2)) 
            {
                Console.WriteLine("Les mots de passes sont identiques.");
            }
              else
            {
                Console.WriteLine("Les mots de passes ne sont pas identiques.");
            }

            Console.WriteLine(Mdp.Longueur()) ;
             if (Mdp.Longueur())
             {
                Console.WriteLine("Le mot de passe contient au moins 12 caractères.");
             }
             else
             {
                Console.WriteLine("Le mot de passe doit contenir au moins 12 caractères.");
             }
            Console.WriteLine(Mdp.EstNumeric());
            if (Mdp.EstNumeric())
            {
                Console.WriteLine("Le mot de passe contient au moins 1 chiffre.");
            }
            else
            {
                Console.WriteLine("Le mot de passe doit contenir au moins 1 chiffres.");
            }

            
            Console.WriteLine(Mdp.EstMajuscule());
            if (Mdp.EstMajuscule())
            {
                Console.WriteLine("Le mot de passe contient au moins 1 majuscule.");
            }
            else
            {
                Console.WriteLine("Le mot de passe doit contenir au moins 1 majuscule.");
            }




        }







    }
}
