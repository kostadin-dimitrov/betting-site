import { Routes, RouterModule } from '@angular/router';
import { PreviewEventsComponent } from './components/preview-events.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
    {
        path: '',
        component: PreviewEventsComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class EventsRouterModule { }
