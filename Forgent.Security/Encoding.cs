using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgent.Security
{
    public class Encoding
    {
        private readonly string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
        public void EncodeToken(Dictionary<string, object> data) { 
        
        IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
        IJsonSerializer serializer = new JsonNetSerializer();
        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
        IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

        var token = encoder.Encode(data, secret);
        Console.WriteLine(token);
        }

        public void DecodeToken(string Token)
        {
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);

                var json = decoder.Decode(Token, secret, verify: true);
                Console.WriteLine(json);
            }
            catch (TokenExpiredException ex)
            {
                Console.WriteLine("Token has expired: " + ex.Message);
            }
            catch (SignatureVerificationException ex)
            {
                Console.WriteLine("Token has invalid signature: " + ex.Message);
            }
        }
    }
}
