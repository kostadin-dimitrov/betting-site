import { NgModule } from '@angular/core';
import { EventsComponent } from './events.component';

import { CommonModule } from '@angular/common';
import { EventsRouterModule } from './events-routing.module';

@NgModule({
    imports: [
        CommonModule,
        EventsRouterModule
    ],
    declarations: [EventsComponent]
})

export class EventsModule { }
