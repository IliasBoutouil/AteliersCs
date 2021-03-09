using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client C1=new Client("Boutouil","Ilias","Casablanca");
            Client C2=new Client("Tazi","Ali","Paris");
            Compte Cp1 = new Compte(new MAD(8500), C1);
            Compte Cp2 = new Compte(new MAD(700), C2);
            Cp1.Afficher();
            Console.WriteLine("------Ajouter--------");
            Cp1.Créditer(new MAD(3600));
            Cp1.Afficher();
            Console.WriteLine("------Retier--------");
            Cp1.Débiter(new MAD(2600));
            Cp1.Afficher();
            Console.WriteLine("-------Verser-------");
            Cp1.Verser(Cp2, new MAD(-500));
            Cp1.Afficher();
            Cp2.Afficher();
            Console.ReadKey();
        }
    }
}
