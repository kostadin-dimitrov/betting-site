import { Routes, RouterModule } from '@angular/router';
import { 
    PreviewEventsComponent,
    EditEventsComponent 
} from './components';
import { NgModule } from '@angular/core';

const routes: Routes = [
    {
        path: '',
        component: PreviewEventsComponent
    },
    {
        path: 'edit-events',
        component: EditEventsComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class EventsRouterModule { }
