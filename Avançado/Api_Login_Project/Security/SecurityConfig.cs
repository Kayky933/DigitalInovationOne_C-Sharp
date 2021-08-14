

using System.Text;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Api_Login_Project.Contracts;
using Api_Login_Project.Models;
using System.IdentityModel.Tokens.Jwt;

namespace Api_Login_Project.Security
{
    public class SecurityConfig
    {
        public static IConfiguration Configuration { get; }
        public static string ConfigureSecurity(PessoaModel pessoaModel)
        {
            var secret = Encoding.ASCII.GetBytes("ChavePresenteNoServidor");
            var SecurityKey = new SymmetricSecurityKey(secret);
            var token = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, pessoaModel.Id.ToString()),
                    new Claim(ClaimTypes.Email, pessoaModel.Email.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };
            var jwtToken = new JwtSecurityTokenHandler();
            var tokenGenerated = jwtToken.CreateToken(token);           
            return jwtToken.WriteToken(tokenGenerated);
        }        

    }
}
