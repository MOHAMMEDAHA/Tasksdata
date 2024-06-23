import { Routes } from '@angular/router';
import { PageNotFoundComponent } from './error-routing/not-found/not-found.component';
import { UncaughtErrorComponent } from './error-routing/error/uncaught-error.component';
import { KanbanViewComponent } from './kanban-view/kanban-view.component';
import { ListViewComponent } from './list-view/list-view.component';

export const routes: Routes = [
  { path: '', redirectTo: 'kanban-view', pathMatch: 'full' },
  { path: 'error', component: UncaughtErrorComponent },
  { path: 'kanban-view', component: KanbanViewComponent, data: { text: 'Kanban View' } },
  { path: 'list-view', component: ListViewComponent, data: { text: 'List View' } },
  { path: '**', component: PageNotFoundComponent } // must always be last
];
