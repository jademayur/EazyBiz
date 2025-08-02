using EazyBizAPI.DTOs;
using EazyBizAPI.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace EazyBizAPI.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AddUserAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserListResponse> GetUsersAsync(UserListRequest request)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
