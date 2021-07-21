namespace FrontDeskApp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FrontDeskApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FrontDeskContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FrontDeskContext context)
        {
            var categories = new List<Category> {
                new Category { strCategory = "Small", intLimit = 46 },
                new Category { strCategory = "Medium", intLimit = 14 },
                new Category { strCategory = "Large", intLimit = 12 }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}
