using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Entities
{
    public class ReviewEntity
    {
        public string Text { get; set; }
        public Book For { get; set; }
        public UInt16 Rating { get; set; }
        public UserEntity Reviewer { get; set; }
        public List<UserEntity> Likes { get; set; }
        public List<UserEntity> Dislikes { get; set; }
        public List<CommentEntity> Comments { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}