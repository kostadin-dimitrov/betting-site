using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingSite.Infrastructure.Data.Entities
{
    public class SportEvent
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public double HomeTeamOdds { get; set; }

        public double AwayTeamOdds { get; set; }

        public double DrawOdds { get; set; }

        public DateTime StartDate { get; set; }
    }
}
