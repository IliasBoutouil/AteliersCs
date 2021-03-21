using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class CompteCourant:Compte
    {
        private MAD Découvert;
        private List<Opération> ListeOp;
        public CompteCourant():base()
         {
            Découvert = new MAD(100);
            ListeOp = new List<Opération>();
         }
        public CompteCourant(MAD solde, Client Prop):base(solde,Prop)
        {
            Découvert = new MAD(100);
            ListeOp = new List<Opération>();
        }
        public override string ToString()
        {
            string chaine = "Liste des oppérations pour ce compte ";
            foreach (var item in ListeOp)
            {
                chaine += "\n " + item.ToString();
            }
            return chaine;
        }
        public override bool Créditer(MAD M)
        {
            this.ListeOp.Add(new Opération(M, "+"));
            return base.Créditer(M);
        }
        public override bool Débiter(MAD montant)
        {
            this.ListeOp.Add(new Opération(montant, "-"));
            return base.Débiter(montant);
        }
        public override bool Verser(Compte C, MAD montant)
        {
            return base.Verser(C, montant);
        }
    }
}
