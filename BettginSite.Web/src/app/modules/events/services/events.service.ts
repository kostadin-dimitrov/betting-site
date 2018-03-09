import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SportEvent } from '../models/sport-event.model';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class EventsService {

    setRoute = (subroute) => `http://localhost:65017/api/${subroute}`;

    constructor(private http: HttpClient) { }

    getEvents(): Observable<SportEvent[]> {
        return this.http.get<SportEvent[]>(this.setRoute('event/GetEvents'));
    }
}
