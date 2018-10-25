using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DomainModels
{
    public class BookEdition
    {
        public DateTime PublishDate { get; set; }
        public byte[] Cover { get; set; }
        public Publisher Publisher { get; set; }
        public string ISBN { get; set; }
    }
}