using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Compte
    {
        protected static int cpt=0;
        protected int id ;
        protected MAD solde;
        protected readonly Client titulaire;
        protected static MAD plafond = new MAD(4000);
        public Compte()
        {
            solde = new MAD(0);
            this.id = ++cpt;
            titulaire = new Client();
        }
        public Compte(MAD solde , Client Prop)
        {
            this.id = ++cpt;
            this.solde = solde;
            this.titulaire = Prop;
        }
        public void Afficher()
        {
            Console.WriteLine("Compte Numero : "+id+"\nPropriétaire :");
            this.titulaire.Afficher();
            Console.WriteLine("Solde : " + solde);
        }
        public bool Créditer(MAD M)
        {
            MAD s = new MAD(0);
            if (M > s)
            {
                this.solde += M;
                return true;
            }
            return false;
        }
        public bool Débiter(MAD montant)
        {
            MAD s = new MAD(0);
            if (montant > s && montant <=plafond)
            {
                if (montant < this.solde)
                {
                    this.solde -= montant;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        public bool Verser(Compte C, MAD montant)
        {
            if (this.id != C.id)
            {
                return this.Débiter(montant) && C.Créditer(montant);
            }
            else
                return false;
        }
    }
    
}
