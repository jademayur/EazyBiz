namespace EazyBizAPI.DTOs
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserType { get; set; }
        public bool Status { get; set; }
        public bool AllowAdmin { get; set; }
        public bool AllowTrading { get; set; }
        public bool AllowAccounts { get; set; }
        public bool AllowProduction { get; set; }
        public bool AllowHR { get; set; }
        public string ProfileImagePath { get; set; }
    }

}
