using System;
using System.Collections.Generic;

namespace codefirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Details { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}