using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess.Entities
{
    public class AuthorEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public byte[] Photo { get; set; }
    }
}