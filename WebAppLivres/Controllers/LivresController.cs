using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppLivres.Models;

namespace WebAppLivres.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LivresController
    {
        private IEnumerable<Livres> livres = new List<Livres>
            {
                new Livres{ IdLiv=1,NomLivre="l'Enfant",Auteur="MD",NbPages=300,Prix=200},
                 new Livres{ IdLiv=2,NomLivre="You",Auteur="HA",NbPages=100,Prix=80},
                  new Livres{ IdLiv=3,NomLivre="Le desert",Auteur="LL",NbPages=200,Prix=70},
            };
       
        [HttpGet]
        public IEnumerable<Livres> GetLivres()
        {
            return livres;
        }
        [HttpGet("{id}")]
        public Livres GetLivre(int id)
        {
            return livres.FirstOrDefault(p => p.IdLiv == id);
        }
    }
}
