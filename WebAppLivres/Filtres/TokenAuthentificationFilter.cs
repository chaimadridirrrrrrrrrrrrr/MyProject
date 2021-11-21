using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using WebAppLivres.Models.TokenAuthentification;

namespace WebAppLivres.Filters
{
    public class TokenAuthentificationFilter : Attribute, IAuthorizationFilter
    {
      
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var tokenManager = (ITokenManager)context.HttpContext.RequestServices.GetService(typeof(ITokenManager));
            string token = String.Empty;
            if (context.HttpContext.Request.Headers.ContainsKey("Authorization"))
                token = context.HttpContext.Request.Headers.First(token => token.Key == "Authorization").Value;

            if (!tokenManager.VerifyToken(token))
                context.ModelState.AddModelError("Unauthorized", "you are not Authorized");
        }
    }
}
