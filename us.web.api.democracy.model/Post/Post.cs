using LanguageExt;

namespace Us.Web.Api.Democracy.Model.Post
{
    public class Post
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTimeOffset Timestamp { get; set; }
        public Seq<UserReaction> Reactions { get; set; }
        public double HierarchyScoreSnapshot { get; set; } = 1.0;
    }
}