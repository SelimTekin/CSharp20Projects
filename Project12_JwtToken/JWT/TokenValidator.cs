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
	public class TokenValidator
	{
		public ClaimsPrincipal ValidateJwtToken(string token)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.UTF8.GetBytes(token);

			try
			{
				var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = true,
					ValidIssuer = "localhost",
					ValidateAudience = true,
					ValidAudience = "localhost",
					ValidateLifetime = true, // süresi bittiğinde token geçersiz kalsın mı
					ClockSkew = TimeSpan.Zero 
				}, out SecurityToken validatedToken);
				return principal;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
