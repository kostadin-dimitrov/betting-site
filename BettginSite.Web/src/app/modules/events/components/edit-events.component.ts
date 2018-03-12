import { Component } from '@angular/core';
import { SportEvent } from '../models/sport-event.model';
import { EventsService } from '../services/events.service';

@Component({
    templateUrl: 'edit-events.component.html',
    styleUrls: ['edit-events.component.scss']
})

export class EditEventsComponent { 

    events: SportEvent[];
    showMessage: string;
    private cellIndex: number;
    private rowIndex: number;
    
    constructor(private eventService: EventsService) { }

    ngOnInit() {
        this.loadData();
    }

    toggle(cell, rowIndex) {
       const cellIndex = cell.cellIndex;
        this.cellIndex = cellIndex;
        this.rowIndex = rowIndex;
    }

    isCellEdit(rowIndex, cell) {
        if (this.cellIndex === cell.cellIndex && this.rowIndex ===rowIndex) {
            return true;
        }
        return false;
    }

    addEvent() {
     const id = Math.max(...this.events.map(x => x.eventId)) + 1;
     const event: SportEvent = {
        id: "",
        eventId: id ? id : 1,
        name: '',
        homeTeamOdds: null,
        awayTeamOdds: null,
        drawOdds: null,
        startDate: new Date(Date.now()),
     }
     this.events.push(event);
    }

    deleteEvent(eventId: number) {
        this.eventService.deleteEvent(eventId).subscribe(response => {
            if (response) {
                this.showMessage = "Event was deleted.";
                this.loadData();
            }
            else {
                this.showMessage = "There was error on the server and the event was not deleted.";
            }
        });
    }

    saveEvent(event) {
        this.eventService.updateEvents(event).subscribe(response => {
            if(response) {
                this.showMessage = "Event was updated.";
            }
            else {
                this.showMessage = "There was error on the server and the event was not updated.";
            }
        });
    }

    loadData() {
        this.eventService.getEvents().subscribe(response => {
            this.events = response;
        });
    }
}
