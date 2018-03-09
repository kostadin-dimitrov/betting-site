import { NgModule } from '@angular/core';
import { PreviewEventsComponent } from './components/preview-events.component';

import { CommonModule } from '@angular/common';
import { EventsRouterModule } from './events-routing.module';
import { EventsService } from './services/events.service';

@NgModule({
    imports: [
        CommonModule,
        EventsRouterModule
    ],
    declarations: [PreviewEventsComponent],
    providers: [EventsService]
})

export class EventsModule { }
