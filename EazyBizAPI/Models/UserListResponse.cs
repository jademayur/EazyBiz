using EazyBizAPI.DTOs;

namespace EazyBizAPI.Models
{
    public class UserListResponse
    {
        public List<UserDTO> Users { get; set; }
        public int TotalCount { get; set; }
    }
}
