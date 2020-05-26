
namespace dmc_tasks.Entities
{
    public class PostComment
    {
        public string Content { get; set; }
        public int? PageId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }

    public class PostCommentRelation 
    {
    }
}
