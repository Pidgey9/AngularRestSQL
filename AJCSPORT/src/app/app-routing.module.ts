import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HommesComponent } from './hommes/hommes.component';
import { FemmesComponent } from './femmes/femmes.component';
import { AcceuilComponent } from './acceuil/acceuil.component';
import { DetailcommandeComponent } from './detailcommande/detailcommande.component';
import { HistoriqueCommandeComponent } from './historique-commande/historique-commande.component';
import { ChatboxComponent } from './chatbox/chatbox.component';



const routes: Routes = [
  { path: 'hommes', component: HommesComponent},
  { path: 'femmes', component: FemmesComponent},
  { path: 'acceuil', component: AcceuilComponent},
  { path: 'detailcommande', component: DetailcommandeComponent},
  { path: 'historiquecommande/:id', component: HistoriqueCommandeComponent},
  { path: 'chatbox', component: ChatboxComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
