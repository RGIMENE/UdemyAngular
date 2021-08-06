import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';

import { TiposService } from '../app/services/tipos.service';
import { CategoriasService } from '../app/services/categorias.service';
import { ListagemCategoriasComponent } from './components/Categoria/listagem-categorias/listagem-categorias.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {MatTableModule} from '@angular/material/table';

import {MatIconModule} from  '@angular/material/icon';

import {MatButtonModule} from '@angular/material/button';
import { NovaCategoriaComponent } from './components/Categoria/nova-categoria/nova-categoria.component';

import {MatCardModule} from '@angular/material/card';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatDividerModule} from '@angular/material/divider';
import {MatSelectModule} from '@angular/material/select';

import {MatGridListModule} from '@angular/material/grid-list';
import { AtualizarCategoriaComponent } from './components/categoria/atualizar-categoria/atualizar-categoria.component';

@NgModule({
  declarations: [
    AppComponent,
    ListagemCategoriasComponent,
    NovaCategoriaComponent,
    AtualizarCategoriaComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatTableModule,
    MatIconModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatDividerModule,
    MatSelectModule,
    MatGridListModule,
  ],
  providers: [
    TiposService,
    CategoriasService,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
