using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque
{
    class Bibliotheque
    {
       public List<Livre> Livres { get; set; }
        public List<Emprunt> Emprunts { get; set; }

        public Bibliotheque()
        {
            Livres = new List<Livre>();
            Emprunts = new List<Emprunt>();
        }

        public void AjouterLivre(Livre livre)
        {
            Livres.Add(livre);
            Console.WriteLine($"Livre ajouté : {livre.Titre} par {livre.Auteur}");
        }

        public void EmprunterLivre(Livre livre)
        {
            // Logique pour gérer l'emprunt d'un livre
            if (livre.NombreExemplairesDisponibles > 0)
            {
                Emprunt emprunt = new Emprunt
                {
                    DateEmprunt = DateTime.Now,
                    DateRetourPrevue = DateTime.Now.AddDays(14),
                    LivreEmprunte = livre
                };
                Emprunts.Add(emprunt);
                livre.NombreExemplairesDisponibles--;
                Console.WriteLine($"Livre emprunté : {livre.Titre} par {livre.Auteur}");
            }
            else
            {
                Console.WriteLine("Désolé, le livre n'est pas disponible pour l'emprunt.");
            }
        }

        public void RetournerLivre(Livre livre)
        {
            // Logique pour gérer le retour d'un livre
            Emprunt emprunt = Emprunts.Find(e => e.LivreEmprunte == livre);
            if (emprunt != null)
            {
                Emprunts.Remove(emprunt);
                livre.NombreExemplairesDisponibles++;
                Console.WriteLine($"Livre retourné : {livre.Titre} par {livre.Auteur}");
            }
            else
            {
                Console.WriteLine("Ce livre n'est pas actuellement emprunté.");
            }
        }

        public void AfficherLivresDisponibles()
        {
            // Logique pour afficher la liste des livres disponibles
            Console.WriteLine("Livres disponibles :");
            foreach (Livre livre in Livres)
            {
                Console.WriteLine($"{livre.Titre} par {livre.Auteur}");
            }
        }

        public void AfficherEmpruntsEnCours()
        {
            // Logique pour afficher la liste des emprunts en cours
            Console.WriteLine("Emprunts en cours :");
            foreach (Emprunt emprunt in Emprunts)
            {
                Console.WriteLine($"{emprunt.LivreEmprunte.Titre} par {emprunt.LivreEmprunte.Auteur} (Retour prévu le {emprunt.DateRetourPrevue.ToShortDateString()})");
            }
        }
    }
}

