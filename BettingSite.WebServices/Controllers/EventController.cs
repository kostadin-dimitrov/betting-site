using BettingSite.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BettingSite.WebServices.Controllers
{
    public class EventController : ApiController
    {
        private EventRepository eventRepository;
        public EventController()
        {
            eventRepository = new EventRepository();
        }
        public IHttpActionResult GetEvents()
        {
            var result = eventRepository.GetEvent();

            return Ok(result);
        }
    }
}