using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;
        public CompteEpargne():base()
         {
            TauxInteret=1;
         }
        public CompteEpargne(MAD solde, Client Prop,double Taux):base(solde,Prop)
        {
            if (Taux > 0 && Taux < 100)
                TauxInteret = Taux;
            else
            {
                throw new Exception("Entrez un Taux compris ente 0 et 100");
            }
        }
        public void CalculIntéret()
        {
            this.solde += (solde * new MAD(this.TauxInteret)) / new MAD(100);
        }
    }
}
