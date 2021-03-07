using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Compte
    {
        private static int cpt=0;
        private int id;
        private double solde;
        private Client titulaire;
        private static double plafond = 4000;
        public Compte()
        {
            solde = 0;
            this.id = ++cpt;
            titulaire = new Client();
        }
        public Compte(double solde , Client Prop)
        {
            this.id = ++cpt;
            this.solde = solde;
            this.titulaire = Prop;
        }
        public void Afficher()
        {
            Console.WriteLine("Compte Numero : "+id+"\nPropriétaire :");
            this.titulaire.Afficher();
            Console.WriteLine("Solde : " + solde + " DH");
        }
        public void Créditer(double montant)
        {
            if (montant > 0)
            {
                this.solde += montant;
                Console.WriteLine("Montant bien ajouter ");
                this.Afficher();
            }
            else
                Console.WriteLine("Entrez un montant positif");
        }
        public void Débiter(double montant)
        {
            if (montant > 0 && montant<=plafond)
            {
                if (montant < this.solde)
                {
                    this.solde -= montant;
                    Console.WriteLine("Montant bien retirer ");
                    this.Afficher();
                }
                else
                {
                    Console.WriteLine("Solde insuffisant ");
                    this.Afficher();
                }
            }
            else
                Console.WriteLine("Entrez un montant correct , plafond : "+plafond);
        }
        public void Verser(Compte C, double montant)
        {
            if(this.id!=C.id)
            {
                this.Débiter(montant);
                C.Créditer(montant);
            }
            else
                Console.WriteLine("Impossible d'effectuer ce virement.");
        }
    }
    
}
