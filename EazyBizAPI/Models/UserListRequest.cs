namespace EazyBizAPI.Models
{
    public class UserListRequest
    {
        public string Search { get; set; } = "";
        public string SortColumn { get; set; } = "FullName";
        public string SortDirection { get; set; } = "ASC";
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
