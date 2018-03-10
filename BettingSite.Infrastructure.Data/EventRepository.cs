using BettingSite.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingSite.Infrastructure.Data
{
    public class EventRepository : IEventRepository
    {
        private readonly EventDb db;

        public EventRepository()
        {
            if (db == null)
            {
                db = new EventDb();
            }
        }

        public IEnumerable<SportEvent> GetEvents()
        {
            return db.Events.ToList();
        }

        public SportEvent GetEvent(Guid id)
        {
            return db.Events.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool SaveEvent(SportEvent sportEvent)
        {
            try
            {
                var dbEvent = GetEvent(sportEvent.Id);
                if (dbEvent != null)
                {
                    UpdateEvent(sportEvent, dbEvent);
                }
                else
                {
                    AddEvent(sportEvent);
                }

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        private void UpdateEvent(SportEvent newEvent, SportEvent existEvent)
        {
            existEvent.Name = newEvent.Name;
            existEvent.HomeTeamOdds = newEvent.HomeTeamOdds;
            existEvent.DrawOdds = newEvent.DrawOdds;
            existEvent.AwayTeamOdds = newEvent.AwayTeamOdds;
            existEvent.StartDate = newEvent.StartDate;
        }

        private void AddEvent(SportEvent sportEvent)
        {
            db.Events.Add(sportEvent);
        }
    }
}
