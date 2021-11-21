using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppLivres.Models.TokenAuthentification
{
    public class Token
    {
        public string Value { get; set; }
        public DateTime Expiredate { get; set; }
    }
}
