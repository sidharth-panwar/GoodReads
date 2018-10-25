using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DomainModels
{
    public class Comment
    {
        public string Text { get; set; }
        public User Commenter { get; set; }
    }
}