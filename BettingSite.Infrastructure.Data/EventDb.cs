using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BettingSite.Infrastructure.Data.Entities;

namespace BettingSite.Infrastructure.Data
{
    public class EventDb : DbContext
    {
        public EventDb() : base()
        {

        }
        public DbSet<SportEvent> Events { get; set; }
    }
}
