using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{

class Program
{
#region   saluer

static void saluer()
{
// afficher un msg a l'utilisateur pour lui demander de saisir son nom
string message;
message = "saisissez votre nom :";

string nom;
nom = "";

string saluer;
saluer = "bonjour";

Console.WriteLine(message);
nom = Console.ReadLine();

// dire bonjour à l'utilisateur 
Console.WriteLine(saluer + " " + nom);
            Console.ReadLine();

}

#endregion

#region menu

static float choisirOperation()
{
Console.Clear();
float reponse;
reponse = 0;
reponse = saisirNombre("tapez le numero de l'operation que vous voulez effectuer: \n" +
            "1. addition\n 2. soustraction\n 3. multiplication\n 4. division"+
            "\n tapez -0 pour quitter");
            
return reponse;
}
#endregion

#region fonction saisir
static float saisirNombre(string prompt)
{
string reponse;
Console.WriteLine(prompt);
reponse = Console.ReadLine();
return float.Parse(reponse);

}
#endregion

#region additionner
//fonction pour additionner deux nombres
static void additionner()
{   //variables
float nombre1;
float nombre2;
float somme;

//demander des nombres
nombre1 = saisirNombre("entrez un permier nombre");
nombre2 = saisirNombre("entrez un deuxieme nombre");

//changer le type
//tryParse
somme = nombre1 + nombre2;
Console.WriteLine("la somme de vos nombres est:" + somme.ToString());
    Console.ReadLine();


}
#endregion

#region
//fonction pour soustraire deux nombres
static void soustraire()
{   //variables
float nombre1;
float nombre2;
float difference;

//demander des nombres
nombre1 = saisirNombre("entrez un permier nombre");
nombre2 = saisirNombre("entrez un deuxieme nombre");

//changer le type
//tryParse
difference = nombre1 - nombre2;
Console.WriteLine("la difference de vos nombres est:" + difference.ToString());
    Console.ReadLine();

}

#endregion

#region multiplier
//fonction pour multiplier deux nombres
static void multiplier()
{   //variables
float nombre1;
float nombre2;
float produit;

//demander des nombres
nombre1 = saisirNombre("entrez un nombre");
nombre2 = saisirNombre("entrez un deuxieme nombre");
            
produit = nombre1 * nombre2;
Console.WriteLine("la produit de vos nombres est:" + produit.ToString());
    Console.ReadLine();

}
#endregion

#region diviser
//fonction pour multiplier deux nombres
static void diviser()
{   //variables
float nombre1;
float nombre2;
float produit;

//demander des nombres
nombre1 = saisirNombre("entrez un nombre");
nombre2 = saisirNombre("entrez un deuxieme nombre");
            
while (nombre2 == 0)
{
                
    nombre2 = saisirNombre(" division impossible par zero, entrez un autre nombre !!! ");
}

produit = nombre1 / nombre2;
Console.WriteLine("le resultat de votre division est:" + produit.ToString());
    Console.ReadLine();
           
          
}
    #endregion
    static void choix(float reponse)
    {
        // choix de loperation en fonction de la reponse
        if (reponse != -0)
        {


            if (reponse == 1)
            {
                additionner();

            }
            if (reponse == 2)
            {
                soustraire();

            }
            if (reponse == 3)
            {
                multiplier();

            }
            if (reponse == 4)
            {
                diviser();

            }
        }
      
    }

    static void Main(string[] args)
{
    float reponse;
    reponse = 0;
    saluer();
    reponse = choisirOperation();


    while ( reponse != -0)
    {
        choix(reponse);
        reponse = choisirOperation();
    }

            Console.WriteLine("merci de votre participation");
            Console.ReadKey();



        }
}
}
