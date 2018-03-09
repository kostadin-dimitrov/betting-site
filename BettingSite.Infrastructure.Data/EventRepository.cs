using BettingSite.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingSite.Infrastructure.Data
{
    public class EventRepository 
    {
        private EventDb db;

        public EventRepository()
        {
            if (db == null)
            {
                db = new EventDb();
            }
        }

        public IEnumerable<SportEvent> GetEvent()
        {
            //var result = db.Events.ToList();
            var result = new List<SportEvent>();
            result.Add(new SportEvent()
            {
                Id = Guid.NewGuid(),
                Name = "Liverpool - Juventus",
                HomeTeamOdds = 1.95,
                DrawOdds = 3.15,
                AwayTeamOdds = 2.2,
                StartDate = new DateTime(2018, 12, 25, 22, 00, 00, DateTimeKind.Utc)

            });
            result.Add(new SportEvent()
            {
                Id = Guid.NewGuid(),
                Name = "Grigor Dimitrov - Rafael Nadal",
                HomeTeamOdds = 2,
                DrawOdds = 3.05,
                AwayTeamOdds = 2.7,
                StartDate = new DateTime(2018, 6, 6, 19, 00, 00, DateTimeKind.Utc)

            });
            result.Add(new SportEvent()
            {
                Id = Guid.NewGuid(),
                Name = "Barcelona - Ludogorets",
                HomeTeamOdds = 1.01,
                DrawOdds = 4.20,
                AwayTeamOdds = 15.20,
                StartDate = new DateTime(2017, 12, 31, 18, 30, 00, DateTimeKind.Utc)

            });

            return result;
        }
    }
}
