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
            bool succeeded = false;
            float result = 0;

            do
            {
                Console.WriteLine(prompt);
                _reponse = Console.ReadLine();
                                                                         //chars = _reponse.ToCharArray();

                if (String.IsNullOrEmpty(_reponse))
                {
                    try
                    {
                        if (float.TryParse(_reponse, out result))
                        {
                            succeeded = true;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Tapez un nombre svp"); 
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine("Désolé je ne gere pas les nombres aussi gros.");
                    }
                }

            } while (succeeded == false);

            return result;
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
