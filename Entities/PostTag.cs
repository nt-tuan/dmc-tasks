﻿
namespace dmc_tasks.Entities
{
    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string TagId { get; set; }
        public string Tag { get; set; }
    }
}