using App1.DTOs;
using App1.Entities;
using App1.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App1.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int targetUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}
