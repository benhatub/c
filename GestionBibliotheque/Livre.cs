using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionBibliotheque
{
    class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string ISBN { get; set; }
        public int NombreExemplairesDisponibles { get; set; }
    }
}
