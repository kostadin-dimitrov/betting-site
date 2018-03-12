import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SportEvent } from '../models/sport-event.model';
import { Observable } from 'rxjs/Observable';
import { HttpHeaders } from '@angular/common/http';

@Injectable()
export class EventsService {

    setRoute = (subroute) => `http://localhost:65017/api/${subroute}`;

    constructor(private http: HttpClient) { }

    getEvents(): Observable<SportEvent[]> {
        return this.http.get<SportEvent[]>(this.setRoute('event/GetEvents'));
    }

    updateEvents(event: SportEvent): Observable<boolean> {
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })
        };

        return this.http.post<boolean>(this.setRoute('event/SaveEvent'), event, httpOptions);
    }

    deleteEvent(eventId: number): Observable<boolean> {
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })
        };

        return this.http.post<boolean>(this.setRoute('event/DeleteEvent'), eventId, httpOptions);
    }
}
