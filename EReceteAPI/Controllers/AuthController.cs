using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EreceteApiCore.Controllers
{
    [Route("API/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost("token")]
        public IActionResult Index()
        {
            var authHeader = Request.Headers["Authorization"];
            if (!authHeader.ToString().StartsWith("Basic"))
            {
                return Unauthorized();
            }
            var creadVal = authHeader.ToString().Substring("Basic ".Length).Trim();
            byte[] data = Convert.FromBase64String(creadVal);
            string decodedString = Encoding.UTF8.GetString(data);

            if (string.IsNullOrEmpty(decodedString))
                throw new UnauthorizedAccessException("Authorization bilgileri gecersiz");

            var userCredentials = decodedString.Split(":");
            ///check this creadentials against DB
            if (false)//userCredentials[0] != "test" && userCredentials[1] == "test" 
            {
                throw new UnauthorizedAccessException("Kullanici bilgileri bulunamadi");
            }
            var claim = new[] { new Claim(ClaimTypes.Name, userCredentials[0])};
            var keySing = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my_scret_key_fromConfig"));
            var signedKey = new SigningCredentials(keySing, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                issuer: "mysite.com",
                audience: "mysite.com",
                expires: DateTime.Now.AddMinutes(1),
                claims: claim,
                signingCredentials: signedKey
                );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(tokenString);

        }
    }
}