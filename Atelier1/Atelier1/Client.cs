using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Client
    {
        private string Nom, Prenom, Adresse;
        public Client()
        {
            Nom = Prenom = Adresse = "";
        }
        public Client(string n,string p ,string a)
        {
            Nom = n;
            Prenom = p;
            Adresse = a;
        }
        public void Afficher()
        {
            Console.WriteLine(this.Nom+" "+this.Prenom+" - "+this.Adresse);
        }
    }
}
