import { NgModule } from '@angular/core';
import { EventsComponent } from './events.component';

import { CommonModule } from '@angular/common';
import { EventsRouterModule } from './events-routing.module';
import { EventsService } from './services/events.service';

@NgModule({
    imports: [
        CommonModule,
        EventsRouterModule
    ],
    declarations: [EventsComponent],
    providers: [EventsService]
})

export class EventsModule { }
