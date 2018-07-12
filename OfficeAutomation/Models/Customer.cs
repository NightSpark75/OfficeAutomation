using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeAutomation.Models
{
    public class Customer
    {
        // Primary Key
        [Key]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Password { get; set; }

        [StringLength(50, ErrorMessage = "名字不可超過50字元")]
        [Required]
        public string Name { get; set; }

        // 新加入的屬性以記錄顧客住址
        public String Address { get; set; }

        public DateTime RegisterOn { get; set; }

        // Navigation Properties
        // virtual = Lazy loading, only be load orders when called Customer.Orders
        public virtual ICollection<Order> Orders { get; set; }
    }
}