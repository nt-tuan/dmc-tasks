using System;
using System.Collections.Generic;

namespace dmc_tasks.Entities
{
    public class Post
    {
        public enum PostRestriction { NONE, ALLOW_USERS }
        public int FeatureLevel { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        //META DATA
        public DateTime LastModifiedDate { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }

        //REFERENCES
        public bool CanComment { get; set; }
        public ICollection<PostComment> Comments { get; set; }
        public int PostRestrictionType { get; set; }
        public ICollection<PostAccessUser> PostAccessUsers { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }

    public class PostAccessUser : BaseEntity
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string AppUser { get; set; }
    }
}
