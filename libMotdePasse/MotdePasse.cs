using System;

namespace libMotdePasse
{
    public class MotdePasse
    {
        private string mdp;
        private string login;

        public MotdePasse(string login, string mdp)
        {
            this.login = login;
            this.mdp = mdp;
        }
        public bool Vérifier(string mdp2)
        {
          
          return mdp == mdp2;
        }
            

        public bool Longueur()
        {
           
            return mdp.Length >= 12;
        }
         public bool EstNumeric()
        {
            bool f = false;
            for (int i = 0; i < mdp.Length; i++) 
            {
                if(Char.IsNumber(mdp, i))
                {
                    f = true;
                }
            }
            return f;

        }
        public bool EstMajuscule()
        {
            bool f = false;
            for (int i = 0; i < mdp.Length; i++)
            {
                if (Char.IsUpper(mdp, i))
                {
                    f = true;
                }
            }
            return f;
        }
 
        
   
    
    }


}

 

  
