namespace Us.Web.Api.Democracy.Model.Post
{
    public enum Reaction
    {
        None,
        ThumbsUp,
        ThumbsDown,
        Smile,
        Laugh,
        Anger,
        Sadness,
    }

    public enum Spread
    {
        Neutral = 0,
        Postive = 1,
        Negative = -1
    }
}