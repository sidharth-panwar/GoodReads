using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DomainModels
{
    public class Book
    {
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public List<Tag> UserTags { get; set; }
        public List<Tag> SystemTags { get; set; }
        public List<BookEdition> Editions { get; set; }
    }
}