using EazyBizAPI.DTOs;
using EazyBizAPI.Models;

namespace EazyBizAPI.Repositories.User
{
    public interface IUserRepository
    {
        Task AddUserAsync(UserDTO user);
        Task UpdateUserAsync(UserDTO user);
        Task DeleteUserAsync(int userId);
        Task<UserListResponse> GetUsersAsync(UserListRequest request);
    }
}
