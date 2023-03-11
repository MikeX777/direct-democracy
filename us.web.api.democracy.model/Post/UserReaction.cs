namespace Us.Web.Api.Democracy.Model.Post
{
    public class UserReaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Reaction Reaction { get; set; }
        public Spread Spread { get; set; } = Spread.Neutral;
        public double HierarchyScoreSnapshot { get; set; } = 1.0;
    }
}