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
        private EventRepository eventRepository;
        public EventController()
        {
            eventRepository = new EventRepository();
        }

        [HttpGet]
        public IHttpActionResult GetEvents()
        {
            var footbalEvent = new Event() {
                Id = new Guid(),
                Name = "Liverpool - Juventus",
                HomeTeamOdds = 1.95,
                DrawOdds = 3.15,
                AwayTeamOdds = 2.2,
                StartDate = new DateTime(2018, 12, 25, 22, 00, 00, DateTimeKind.Utc)

            };
            //var result = eventRepository.GetEvent();

            return Ok(new List<Event>() { footbalEvent });
        }
    }
}