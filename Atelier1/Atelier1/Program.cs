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
            Compte Cp1 = new Compte(8500, C1);
            Compte Cp2 = new Compte(600, C2);
            Cp1.Afficher();
            Console.WriteLine("------Ajouter--------");
            Cp1.Créditer(3600);
            Console.WriteLine("------Retier--------");
            Cp1.Débiter(2600);
            Console.WriteLine("-------Verser-------");
            Cp1.Verser(Cp2, 500);
            Console.ReadKey();
        }
    }
}
