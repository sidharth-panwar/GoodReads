using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Entities
{
    public class CommentEntity
    {
        public string Text { get; set; }
        public UserEntity Commenter { get; set; }
    }
}