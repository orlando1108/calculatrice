using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Menu
    {
        private String _reponse;
        public String Reponse
        {
            get { return _reponse; }
            set { _reponse = value; }
        }

        private String _message;
        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public Menu(string reponse, string message){
            this._message = message;
            this._reponse = message;
        }
        
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
