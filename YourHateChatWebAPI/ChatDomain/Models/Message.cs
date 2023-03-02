namespace ChatData.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Created { get; set; }
        public int LikeCount { get; set; }
        public string Content { get; set; }
    }
}
