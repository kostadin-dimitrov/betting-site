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

        public IEnumerable<Event> GetEvent()
        {
            var result = db.Events.ToList();

            return result;
        }
    }
}
