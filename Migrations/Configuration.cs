﻿namespace My_Evidence.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<My_Evidence.DAL.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(My_Evidence.DAL.OrderContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
