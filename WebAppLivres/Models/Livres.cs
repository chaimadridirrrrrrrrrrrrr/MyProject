using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLivres.Models
{
    public class Livres
    {
        public int IdLiv{ get; set; }
        public string NomLivre { get; set; }
        public string Auteur { get; set; }
        public int  NbPages{ get; set; }
        public double Prix { get; set; }
    }
}
