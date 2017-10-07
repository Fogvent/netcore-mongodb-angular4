using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Forgent.Security
    {
        public class EncodingNet : IJWTEncoding
        {
            private readonly string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";
            public string EncodeToken(Dictionary<string, object> data)
            {
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                IJsonSerializer serializer = new JsonNetSerializer();
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

                var token = encoder.Encode(data, secret);
                return token;
            }
            private IJwtDecoder getDecoder()
            {
                try
                {
                    IJsonSerializer serializer = new JsonNetSerializer();
                    IDateTimeProvider provider = new UtcDateTimeProvider();
                    IJwtValidator validator = new JwtValidator(serializer, provider);
                    IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                    IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                    return decoder;
                }

                catch (TokenExpiredException ex)
                {
                    Console.WriteLine("Token has expired: " + ex.Message);
                }
                catch (SignatureVerificationException ex)
                {
                    Console.WriteLine("Token has invalid signature: " + ex.Message);
                }
                return null;
            }
            public string DecodeToken(string Token)
            {
                try
                {
                    var decoder = getDecoder();
                    if (decoder == null) return "";
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(decoder.Decode(Token, secret, verify: true));
                    return json;
                }

                catch (TokenExpiredException ex)
                {
                    Console.WriteLine("Token has expired: " + ex.Message);
                }
                catch (SignatureVerificationException ex)
                {
                    Console.WriteLine("Token has invalid signature: " + ex.Message);
                }
                return null;
            }
            public string[] getItems(string jwt)
            {
                var items = jwt.Split('.');
                return items;
            }

            public string DecodeClaimFrimToken(string Token, string ClaimName)
            {
                var decoder = getDecoder();
                if (decoder == null) return "";
                var payload = decoder.DecodeToObject<IDictionary<string, object>>(Token, secret, true);
                return payload.Where(s => s.Key == ClaimName).ToString();
            }

    }
    
}
