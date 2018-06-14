using System;
using System.Collections.Generic;

namespace demoapi.Models
{
    public class Billing
    {
        public string Username { get; set; }
        public string ReferenceCode { get; set; }
        public double Price { get; set; }
    }
}