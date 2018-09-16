using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace FriendAPI
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public AuthenticationMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string authToken = httpContext.Request.Headers["Authorization"];

            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                var validations = new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("Google for NWOBHM")),
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateIssuerSigningKey = true
                };

                var claimsPrincipal = tokenHandler.ValidateToken(authToken, validations, out SecurityToken token);

                await requestDelegate.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.StatusCode = 401;
                return;
            }
        }
    }
}
