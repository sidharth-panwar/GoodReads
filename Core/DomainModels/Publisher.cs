﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.DomainModels
{
    public class Publisher
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public byte[] Logo { get; set; }
    }
}