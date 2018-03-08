import { Component, OnInit } from '@angular/core';
import { EventsService } from './services/events.service';
import { FootballEvent } from './models/event.model';

@Component({
    templateUrl: 'events.component.html'
})

export class EventsComponent implements OnInit {

    events: FootballEvent[];
    constructor(private eventService: EventsService) { }

    ngOnInit() {
        this.eventService.getEvents().subscribe(response => {
            this.events = response;
            console.log(this.events);
        });
    }
}
