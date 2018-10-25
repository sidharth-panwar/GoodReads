using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Entities
{
    public class BookEntity
    {
        public string Title { get; set; }
        public List<AuthorEntity> Authors { get; set; }
        public List<TagEntity> UserTags { get; set; }
        public List<TagEntity> SystemTags { get; set; }
        public List<BookEditionEntity> Editions { get; set; }
    }
}