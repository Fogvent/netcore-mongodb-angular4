using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgent.Security
{
    interface IJWTEncoding
    {
        string EncodeToken(Dictionary<string, object> data);
        string DecodeToken(string Token);
        string DecodeClaimFrimToken(string Token, string ClaimName);
    }
}