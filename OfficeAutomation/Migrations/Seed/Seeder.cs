using OfficeAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeAutomation.Migrations.Seed
{
    public class Seeder : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{Name="Carson1",Email="Carson1@gmail.com",RegisterOn=DateTime.Parse("2005-09-01")},
            new Customer{Name="Carson2",Email="Carson2@gmail.com",RegisterOn=DateTime.Parse("2005-09-02")},
            new Customer{Name="Carson3",Email="Carson3@gmail.com",RegisterOn=DateTime.Parse("2005-09-03")},
            new Customer{Name="Carson4",Email="Carson4@gmail.com",RegisterOn=DateTime.Parse("2005-09-04")},
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{ProductId=1050,Name="Chemistry",Price=3,},
            new Product{ProductId=4022,Name="Microeconomics",Price=3,},
            new Product{ProductId=4041,Name="Macroeconomics",Price=3,},
            new Product{ProductId=1045,Name="Calculus",Price=4,},
            new Product{ProductId=3141,Name="Trigonometry",Price=4,},
            new Product{ProductId=2021,Name="Composition",Price=3,},
            new Product{ProductId=2042,Name="Literature",Price=4,}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
            new Order{CustomerId=1,ProductId=1050,Memo="memo11"},
            new Order{CustomerId=1,ProductId=4022,Memo="memo12"},
            new Order{CustomerId=1,ProductId=4041,Memo="memo13"},
            new Order{CustomerId=2,ProductId=1045,Memo="memo14"},
            new Order{CustomerId=2,ProductId=3141,Memo="memo15"},
            new Order{CustomerId=2,ProductId=2021,Memo="memo16"},
            new Order{CustomerId=3,ProductId=1050},
            new Order{CustomerId=4,ProductId=1050},
            new Order{CustomerId=4,ProductId=4022,Memo="memo17"},

            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}