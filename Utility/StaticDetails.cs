namespace NewsPaper.Utility
{
    public class StaticDetails
    {
        public const string RoleAdmin = "ADMIN";
        public const string RoleModerator = "MODERATOR";
        public const string RoleCustomer = "CUSTOMER";

        public const string TokenCookie = "JWTToken";

        public static string AuthAPIBase { get; set; }
    }
}