namespace ReadTheNews.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ReadTheNews.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ReadTheNews.Models.RssNewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ReadTheNews.Models.RssNewsContext";
        }

        protected override void Seed(ReadTheNews.Models.RssNewsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.RssCategories.AddOrUpdate(
                p => p.Name,
                new RssCategory { Name = "Sport" }
               );
            RssItem item = new RssItem { Title = "Херня", Description = "fsd", Link = "fewkfew", Date = DateTime.Now, IsLastNews = false, ImageSrc = "no" };
            context.RssItems.AddOrUpdate(
                item
                );
            context.DeletedNews.AddOrUpdate(
                new DeletedRssItemsByUser { RssItemId = 1, UserId = "fsdfdsfds" });

            context.DefferedNews.AddOrUpdate(
                new UserDefferedNews { RssItemId = 1, UserId = "fsdfdsfds" });
            context.FavoriteNews.AddOrUpdate(
                new FavoriteNews { RssItemId = 1, UserId = "ffff"});
        }
    }
}
