using System;
using System.Collections.Generic;
namespace codefirst.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}