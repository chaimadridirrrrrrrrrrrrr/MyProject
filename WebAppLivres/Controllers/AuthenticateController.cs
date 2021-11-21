using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

using WebAppLivres.Models.TokenAuthentification;

namespace WebAppLivres.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly ITokenManager _tokenManager;
        public AuthenticateController(ITokenManager tokenManager)
        {
            this._tokenManager = tokenManager;
        }
        public IActionResult Authenticate(string user, string pwd)
        {
            if (_tokenManager.Authenticate(user, pwd))
            
                return Ok(new {Token = _tokenManager.NewToken()});
                ModelState.AddModelError("unauthorized", "You are not allowd to assess");
                return Unauthorized(ModelState);
            
        }

      
    }
}
