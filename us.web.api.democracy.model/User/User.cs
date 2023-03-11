namespace Us.Web.Api.Democracy.Model.User
{
    public class User
    {
        public int Id { get; set; }
        public string GivenName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public int Followers { get; set; }
    }
}