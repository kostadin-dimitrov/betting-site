import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FootballEvent } from '../models/event.model';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class EventsService {

    setRoute = (subroute) => `http://localhost:65017/api/${subroute}`;

    constructor(private http: HttpClient) { }

    getEvents(): Observable<FootballEvent[]> {
        return this.http.get<FootballEvent[]>(this.setRoute('event/GetEvents'));
    }
}
