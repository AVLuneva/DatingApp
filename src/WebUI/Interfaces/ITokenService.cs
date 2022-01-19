using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Entities;

namespace WebUI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}