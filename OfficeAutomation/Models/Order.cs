using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeAutomation.Models
{
    public class Order
    {
        // Primary Key
        [Key]
        public int OrderId { get; set; }

        public string Memo { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }

        // Foreign Key
        public int ProductId { get; set; }

        // Navigation Property
        public virtual Customer Customer { get; set; }

        // Navigation Property
        public virtual Product Product { get; set; }
    }
}