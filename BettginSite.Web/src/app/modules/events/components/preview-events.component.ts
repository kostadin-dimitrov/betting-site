import { Component, OnInit } from '@angular/core';
import { EventsService } from '../services/events.service';
import { SportEvent } from '../models/sport-event.model';

@Component({
    templateUrl: 'preview-events.component.html',
    styleUrls: ['preview-events.component.scss']
})

export class PreviewEventsComponent implements OnInit {

    events: SportEvent[];
    constructor(private eventService: EventsService) { }

    ngOnInit() {
        this.eventService.getEvents().subscribe(response => {
            this.events = response;
        });
    }
}
