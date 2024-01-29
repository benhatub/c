using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque bibliotheque = new Bibliotheque();
            while (true)
            {
                MenuInteractif.AffichezMenu();
                Console.Write("Choisissez une des options : ");
                int option = int.Parse(Console.ReadLine());
                MenuInteractif.ExecuterOption(option, bibliotheque);
            }
        }
    }
}
