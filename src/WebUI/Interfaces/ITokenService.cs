using System.Threading.Tasks;
using WebUI.Entities;

namespace WebUI.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}