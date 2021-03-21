using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Opération
    {
        private static int cpt = 0;
        private int numero;
        private DateTime Date;
        private MAD Montant;
        private string Libelle;
        public Opération()
        {
            numero = ++cpt;
            Date = DateTime.Now;
        }
        public Opération(MAD Montant,string Lib)
        {
            numero = ++cpt;
            Date = DateTime.Now;
            this.Montant = Montant;
            this.Libelle = Lib;
        }
        public override string ToString()
        {
            return this.Date.ToShortDateString()+"| n° "+this.numero+" |"+this.Libelle+" |"+Montant.ToString();
        }

    }
}
