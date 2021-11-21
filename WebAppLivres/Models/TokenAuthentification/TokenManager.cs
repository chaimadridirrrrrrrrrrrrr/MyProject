using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAppLivres.Models.TokenAuthentification
{
    public class TokenManager : ITokenManager 
    {
        private List<Token> _token = new List<Token>();
        public bool Authenticate(string user, string pwd)
        {
            if (!(string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pwd)) && user.ToLower() == "admin" && pwd == "password")
                return true;
            return false;
        }
        public Token NewToken()
        {
            var token = new Token
            {
                Value = Guid.NewGuid().ToString(),
                Expiredate = DateTime.Now.AddDays(30)
            };
            _token.Add(token);
            return token;
        }
        public bool VerifyToken(string tokenValue)
        {
            if (_token.FirstOrDefault(t => t.Value == tokenValue && t.Expiredate > DateTime.Now) != null)
                return true;
            return false;
        }
    }
}
