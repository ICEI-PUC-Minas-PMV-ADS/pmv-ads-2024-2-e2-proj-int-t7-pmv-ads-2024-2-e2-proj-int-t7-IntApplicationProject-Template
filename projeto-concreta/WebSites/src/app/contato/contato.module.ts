import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContatoComponent } from './contato.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
    declarations: [ContatoComponent],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
    ], exports: [
        ContatoComponent
    ]
})
export class ContatoModule { }