using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Entities
{
    public class PublisherEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public byte[] Logo { get; set; }
    }
}