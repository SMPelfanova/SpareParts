import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { DetailsComponent } from './details/details.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';

const routes: Routes = [
  { path: 'parts', redirectTo: 'parts/list', pathMatch: 'full' },
  { path: 'parts/list', component: ListComponent },
  { path: 'parts/:partId/details', component: DetailsComponent },
  { path: 'parts/create', component: CreateComponent },
  { path: 'parts/:partId/edit', component: EditComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PartsRoutingModule { }
