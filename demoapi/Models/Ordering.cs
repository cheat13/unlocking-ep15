using System;
using System.Collections.Generic;

namespace demoapi.Models
{
    public class Ordering
    {
        public string Username { get; set; }
        public IEnumerable<string> ProductIds { get; set; }
    }
}