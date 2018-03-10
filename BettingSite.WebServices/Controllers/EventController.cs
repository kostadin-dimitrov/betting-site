using BettingSite.Infrastructure.Data;
using BettingSite.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BettingSite.WebServices.Controllers
{
    public class EventController : ApiController
    {
        private readonly IEventRepository eventRepository;

        public EventController()
        {
            this.eventRepository = new EventRepository();
        }

        [HttpGet]
        public IHttpActionResult GetEvents()
        {
            var result = eventRepository.GetEvents();

            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SaveEvent(SportEvent sportEvent)
        {
            var result = eventRepository.SaveEvent(sportEvent);

            return Ok(result);
        }

        protected override void Dispose(bool disposing)
        {
            this.eventRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}