using System.Text;
using Microsoft.Owin;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security;
using Owin;
using Microsoft.IdentityModel.Tokens;
using System;

[assembly: OwinStartup(typeof(MyWebapiapp_JWTAuth.Startup))]

namespace MyWebapiapp_JWTAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var key = Encoding.ASCII.GetBytes("SuperSecretKey@123");

            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                }
            });
        }
    }
}