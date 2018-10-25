using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DomainModels
{
    public class Review
    {
        public string Text { get; set; }
        public Book For { get; set; }
        public UInt16 Rating { get; set; }
        public User Reviewer { get; set; }
        public List<User> Likes { get; set; }
        public List<User> Dislikes { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}