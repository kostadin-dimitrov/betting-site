namespace BettingSite.Infrastructure.Data.Migrations
{
    using BettingSite.Infrastructure.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BettingSite.Infrastructure.Data.EventDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BettingSite.Infrastructure.Data.EventDb";
        }

        protected override void Seed(BettingSite.Infrastructure.Data.EventDb context)
        {
            context.Events.AddOrUpdate(x => x.Id,
            new SportEvent()
            {
                Id = Guid.NewGuid(),
                EventId = 1,
                Name = "Liverpool - Juventus",
                HomeTeamOdds = 1.95,
                DrawOdds = 3.15,
                AwayTeamOdds = 2.2,
                StartDate = new DateTime(2018, 12, 25, 22, 00, 00, DateTimeKind.Utc)

            }, new SportEvent()
            {
                Id = Guid.NewGuid(),
                EventId = 2,
                Name = "Grigor Dimitrov - Rafael Nadal",
                HomeTeamOdds = 2,
                DrawOdds = 3.05,
                AwayTeamOdds = 2.7,
                StartDate = new DateTime(2018, 6, 6, 19, 00, 00, DateTimeKind.Utc)

            }, new SportEvent()
            {
                Id = Guid.NewGuid(),
                EventId = 3,
                Name = "Barcelona - Ludogorets",
                HomeTeamOdds = 1.01,
                DrawOdds = 4.20,
                AwayTeamOdds = 15.20,
                StartDate = new DateTime(2017, 12, 31, 18, 30, 00, DateTimeKind.Utc)

            });
        }
    }
}
