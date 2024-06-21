using System.Security.Claims;

namespace EduPrime.Infrastructure.Security;

public static class ClaimsExtension
{
    public static List<Claim> AddIfValueNotNull(this List<Claim> claims, string type, string? value)
    {
        if (value is not null)
        {
            claims.Add(new Claim(type: type, value: value));
        }

        return claims;
    }
}
