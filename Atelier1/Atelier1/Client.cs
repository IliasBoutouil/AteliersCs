using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Atelier1
{
    class Client
    {
        private string Nom, Prenom, Adresse;
        private List<Compte> Comptes;
        public Client()
        {
            Comptes = new List<Compte>();
            Nom = Prenom = Adresse = "";
        }
        public Client(string n,string p ,string a)
        {
            Comptes = new List<Compte>();
            Nom = n;
            Prenom = p;
            Adresse = a;
        }
        public void AjouterCompte(Compte C)
        {
            Comptes.Add(C);
        }
        public void Afficher()
        {
            Console.WriteLine(this.Nom+" "+this.Prenom+" - "+this.Adresse+"\nListe des Comptes :");
            foreach (var item in Comptes)
            {
                item.Afficher2();
            }
            
        }
    }
}
