using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingSite.Infrastructure.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }

        public int HomeTeam { get; set; }

        public int AwayTeam { get; set; }

        public decimal HomeTeamOdds { get; set; }

        public decimal AwayTeamOdds { get; set; }

        public decimal DrawOdds { get; set; }

        public DateTime StartTime { get; set; }
    }
}
