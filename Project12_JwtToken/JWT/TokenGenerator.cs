using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project12_JwtToken.JWT
{
	public class TokenGenerator
	{
		public string GenerateJwtToken(string username, string email, string name, string surname)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT"));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			// İstekte bulunacak olan token kişisi
			var claimsExample = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, username), // Sub -> Id veya kullanıcı adı için kullanılan parametre
				new Claim(JwtRegisteredClaimNames.Email, email),
				new Claim(JwtRegisteredClaimNames.GivenName, name), // zorunlu değil
				new Claim(JwtRegisteredClaimNames.FamilyName, surname), // zorunlu değil
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())  // unique olarak oluşturduğu guid id
			};

			var token = new JwtSecurityToken(
				issuer: "localhost",   // yayınlayıcı (yani token kim tarafından oluşturuldu. Herhangi bir string ifade de olabiilr)
				audience: "localhost", // dinleyici
				claims: claimsExample,
				expires: DateTime.Now.AddMinutes(5),
				signingCredentials: credentials
				);

			return new JwtSecurityTokenHandler().WriteToken(token); // token'ı yaz
		}

		public string GenerateJwtToken2(string username)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT"));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			// İstekte bulunacak olan token kişisi
			var claimsExample = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, username), // Sub -> Id veya kullanıcı adı için kullanılan parametre
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())  // unique olarak oluşturduğu guid id
			};

			var token = new JwtSecurityToken(
				issuer: "localhost",   // yayınlayıcı (yani token kim tarafından oluşturuldu. Herhangi bir string ifade de olabiilr)
				audience: "localhost", // dinleyici
				claims: claimsExample,
				expires: DateTime.Now.AddMinutes(5),
				signingCredentials: credentials
				);

			return new JwtSecurityTokenHandler().WriteToken(token); // token'ı yaz
		} 

	}
}
