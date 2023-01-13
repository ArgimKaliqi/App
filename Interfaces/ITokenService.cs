using App1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
