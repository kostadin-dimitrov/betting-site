import { NgModule } from '@angular/core';
import { 
    PreviewEventsComponent,
    EditEventsComponent
} from './components';

import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { EventsRouterModule } from './events-routing.module';
import { EventsService } from './services/events.service';

@NgModule({
    imports: [
        CommonModule,
        EventsRouterModule,
        FormsModule
    ],
    declarations: [
        PreviewEventsComponent,
        EditEventsComponent
    ],
    providers: [EventsService]
})

export class EventsModule { }
