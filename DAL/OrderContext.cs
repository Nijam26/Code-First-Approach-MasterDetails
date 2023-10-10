using My_Evidence.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace My_Evidence.DAL
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("Exam_DB")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Configuration.ProxyCreationEnabled = false;
        }
    }
}