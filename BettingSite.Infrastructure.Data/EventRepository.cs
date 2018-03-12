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

        public SportEvent GetEvent(int eventId)
        {
            return db.Events.Where(x => x.EventId == eventId).FirstOrDefault();
        }

        public bool SaveEvent(SportEvent sportEvent)
        {
            try
            {
                sportEvent.StartDate = sportEvent.StartDate.ToUniversalTime();
                var dbEvent = GetEvent(sportEvent.EventId);
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

        public bool DeleteEvent (int eventId)
        {
            try
            {
                var dbEvent = GetEvent(eventId);
                if (dbEvent != null)
                {
                    db.Events.Remove(dbEvent);
                    db.SaveChanges();
                }
                else
                {
                    return false;
                }
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
            sportEvent.Id = Guid.NewGuid();
            db.Events.Add(sportEvent);
        }
    }
}
