import { Component, OnInit } from '@angular/core';
import { Tipo } from 'src/app/models/Tipo';
import { TiposService } from 'src/app/services/tipos.service';

import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-nova-categoria',
  templateUrl: './nova-categoria.component.html',
  styleUrls: ['../listagem-categorias/listagem-categorias.component.css'],
})
export class NovaCategoriaComponent implements OnInit {

  formulario: any;
  tipos: Tipo[];
  
  constructor(private tiposService: TiposService) { }

  ngOnInit(): void {

    this.tiposService.PegarTodos().subscribe(resultado => {
      this.tipos = resultado;

      console.log(resultado);

    });

    this.formulario = new FormGroup({
      nome: new FormControl(null),
      icone: new FormControl(null),
      tipoId: new FormControl(null),
    });

  }

  get propriedade(){
      return this.formulario.controls;
  }

}
