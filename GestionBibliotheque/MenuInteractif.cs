using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque
{
    class MenuInteractif
    {
        public static void AffichezMenu()
        {
            // Logique pour afficher le menu interactif
            Console.WriteLine("1. Ajouter un livre");
            Console.WriteLine("2. Emprunter un livre");
            Console.WriteLine("3. Retourner un livre");
            Console.WriteLine("4. Afficher la liste des livres disponibles");
            Console.WriteLine("5. Afficher la liste des emprunts en cours");
            Console.WriteLine("6. Quitter !");
        }

        public static void ExecuterOption(int option, Bibliotheque bibliotheque)
        {
            // Logique pour exécuter l'option sélectionnée
            switch (option)
            {
                case 1:
                    // Demander les détails du livre et l'ajouter à la bibliothèque
                    Livre livre = new Livre();
                    Console.Write("Titre du livre");
                    livre.Titre = Console.ReadLine();
                    Console.Write("Auteur du livre : ");
                    livre.Auteur = Console.ReadLine();
                    Console.Write("ISBN du livre : ");
                    livre.ISBN = Console.ReadLine();
                    Console.Write("Nombre d'exemplaires disponibles : ");
                    livre.NombreExemplairesDisponibles = int.Parse(Console.ReadLine());
                    bibliotheque.AjouterLivre(livre);
                    break;
                case 2:
                    // Demander le titre du livre à emprunter et l'emprunter
                    Console.Write("Titre du livre à emprunter : ");
                    string titreEmprunt = Console.ReadLine();
                    Livre livreEmprunt = bibliotheque.Livres.Find(l => l.Titre == titreEmprunt);
                    if (livreEmprunt != null)
                    {
                        bibliotheque.EmprunterLivre(livreEmprunt);
                    }
                    else
                    {
                        Console.WriteLine("Le livre spécifié n'existe pas dans la bibliothèque.");
                    }
                    break;
                case 3:
                    // Demander le titre du livre à retourner et le retourner
                    Console.Write("Titre du livre à retourner : ");
                    string titreRetour = Console.ReadLine();
                    Livre livreRetour = bibliotheque.Livres.Find(l => l.Titre == titreRetour);
                    if (livreRetour != null)
                    {
                        bibliotheque.RetournerLivre(livreRetour);
                    }
                    else
                    {
                        Console.WriteLine("Le livre spécifié n'existe pas dans la bibliothèque.");
                    }
                    break;
                case 4:
                    // Afficher la liste des livres disponibles
                    bibliotheque.AfficherLivresDisponibles();
                    break;
                case 5:
                    // Afficher la liste des emprunts en cours
                    bibliotheque.AfficherEmpruntsEnCours();
                    break;
                case 6:
                    // Quitter le programme
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Option invalide. Veuillez choisir une option valide.");
                    break;
            }
        }
    }
}