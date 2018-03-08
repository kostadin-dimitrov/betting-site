using BettingSite.Infrastructure.Data;
using BettingSite.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EventDb())
            {
                var stud = new Team() { Id = 1, Name = "Leverpool" };

                ctx.Teams.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
