using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class AppBanque
    {
        public void Run()
        {
            //Creation des Comptes + Clients
            Client Client1 = new Client("Boutouil", "Ilias", "Casablanca");
            Client Client2 = new Client("Tazi", "Ali", "Paris");
            Compte Compte1 = new Compte(new MAD(8500), Client1);
            Compte Compte2 = new Compte(new MAD(700), Client2);
            Compte Compte3 = new Compte(new MAD(700), Client1);
            //Remplire la liste 
            Client1.AjouterCompte(Compte1);
            Client1.AjouterCompte(Compte2);
            Console.WriteLine("------Afficher un Client--------");
            Client1.Afficher();
            Console.WriteLine("------Afficher un Compte-------");
            Compte1.Afficher();
            Console.WriteLine("------Ajouter--------");
            Compte1.Créditer(new MAD(3600));
            Compte1.Afficher();
            Console.WriteLine("------Retier--------");
            Compte1.Débiter(new MAD(2600));
            Compte1.Afficher();
            Console.WriteLine("-------Verser-------");
            Compte1.Verser(Compte2, new MAD(500));
            Compte1.Afficher();
            Compte2.Afficher();
            //Compte D'epargne 
            Console.WriteLine("-------Compte D'epargne------");
            CompteEpargne CE1 = new CompteEpargne(new MAD(4500), Client1,20);
            CE1.Afficher2();
            Console.WriteLine("-------Calculer Intéret-------");
            CE1.CalculIntéret();
            CE1.Afficher2();
            //Compte Courant
            Compte CCourant1 = new CompteCourant(new MAD(8500), Client1);
            Console.WriteLine("------Ajouter--------");
            CCourant1.Créditer(new MAD(3600));
            Console.WriteLine("------Retier--------");
            CCourant1.Débiter(new MAD(2600));
            Console.WriteLine("-------Verser-------");
            CCourant1.Verser(Compte2, new MAD(500));
            Console.WriteLine("------historique des opérations pour le compte--------");
            Console.WriteLine(CCourant1.ToString());
        }
    }
}
