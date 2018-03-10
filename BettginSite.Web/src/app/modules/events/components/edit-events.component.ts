import { Component } from '@angular/core';
import { SportEvent } from '../models/sport-event.model';
import { EventsService } from '../services/events.service';

@Component({
    templateUrl: 'edit-events.component.html',
    styleUrls: ['edit-events.component.scss']
})

export class EditEventsComponent { 

    events: SportEvent[];
    hasError: boolean = false;
    
    constructor(private eventService: EventsService) { }

    ngOnInit() {
        this.eventService.getEvents().subscribe(response => {
            this.events = response;
        });
    }

    addEvent() {
     const id = Math.max(...this.events.map(x => x.eventId)) + 1;
     const event: SportEvent = {
        id: "",
        eventId: id,
        name: '',
        homeTeamOdds: null,
        awayTeamOdds: null,
        drawOdds: null,
        startDate: Date.now(),
     }
     this.events.push(event);
    }

    deleteEvent(event) {
        console.log(event);
    }

    saveEvent(event) {
        this.eventService.updateEvents(event).subscribe(response => {
            this.hasError = response;
        });
    }
}
