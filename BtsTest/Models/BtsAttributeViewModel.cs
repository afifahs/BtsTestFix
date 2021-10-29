using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtsTest.Models
{
    public class BtsAttributeViewModel
    {
        public class UserAttribute
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Postcode { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }

        public class ShoppingAttribute
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime CreatedDate { get; set; }
        }
    }
}