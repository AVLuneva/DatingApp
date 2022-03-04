using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs;
using WebUI.Entities;

namespace WebUI.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, int userId);
    }
}