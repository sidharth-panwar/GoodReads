using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Entities
{
    public class BookEditionEntity
    {
        public DateTime PublishDate { get; set; }
        public byte[] Cover { get; set; }
        public PublisherEntity Publisher { get; set; }
        public string ISBN { get; set; }
    }
}