using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DomainModels
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public byte[] Photo { get; set; }
    }
}