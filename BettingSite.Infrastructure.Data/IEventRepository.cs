using BettingSite.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingSite.Infrastructure.Data
{
    public interface IEventRepository: IDisposable
    {
        IEnumerable<SportEvent> GetEvents();

        SportEvent GetEvent(int eventId);

        bool SaveEvent(SportEvent sportEvent);

        bool DeleteEvent(int eventId);
    }
}
