// src/app/app.module.ts

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NumaratoareComponent } from './numaratoare/numaratoare.component';


@NgModule({
  declarations: [
    NumaratoareComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [NumaratoareComponent]
})
export class AppModule { }
