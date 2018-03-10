using BettingSite.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingSite.Infrastructure.Data
{
    public class EventRepository : IDisposable
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
            return db.Events.ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
