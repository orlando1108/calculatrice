using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Interaction
    {
        private String _message;
        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private String _reponse;
        public String Reponse
        {
            get { return _reponse; }
            //set { _reponse = value; }
        }

        public Interaction()
        {
            
        }

        #region fonction saisir
        public float saisirNombre(string prompt)
        {
            float number = 0;
            char[] chars;
           

            do { 


                _
                Console.WriteLine(prompt);
                _reponse = Console.ReadLine();
                chars = _reponse.ToCharArray();


                try
                {
                    number = float.Parse(_reponse);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Tapez un nombre svp"); // à personnaliser
                                                              // number = saisirNombre(prompt);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Désolé je ne gere pas les nombres aussi gros.");
                    //number = saisirNombre(prompt);
                }
               // return number;
            }while(!  )
            
               
        }
        #endregion


       /* public string ChoisirOperation()
        {
            Console.ReadKey();
            Console.Clear();


            _reponse = saisirOperation("tapez le signe de l'operation que vous voulez effectuer: \n" +
                        " +  addition\n -  soustraction\n *  multiplication\n /  division" +
                        "\n /e  division euclidienne\n\ntapez -0 pour quitter");

            return reponse;
        }*/
      
    }
}
