import { Component, OnInit } from '@angular/core';
import { EventsService } from '../services/events.service';
import { SportEvent } from '../models/sport-event.model';
import { Router } from '@angular/router';

@Component({
    templateUrl: 'preview-events.component.html',
    styleUrls: ['preview-events.component.scss']
})

export class PreviewEventsComponent implements OnInit {

    events: SportEvent[];
    message: string;
    constructor(private eventService: EventsService, private router: Router) { }

    ngOnInit() {
        this.eventService.getEvents().subscribe(response => {
            this.events = response;
        });
    }

    setMessage(eventId, oddsValue, oddsType) {
        this.message = `${eventId} - ${oddsType} - ${oddsValue}`;
    }
}
