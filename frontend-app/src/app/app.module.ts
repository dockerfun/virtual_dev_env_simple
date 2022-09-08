import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { UsersComponent } from './users/users.component';
import { UserListComponent } from './users/user-list/user-list.component';
import { HttpClientModule } from '@angular/common/http';

//new imports
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AccordionModule } from 'ngx-bootstrap/accordion';
import { AlertModule,AlertConfig } from 'ngx-bootstrap/alert';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BsDatepickerModule, BsDatepickerConfig } from 'ngx-bootstrap/datepicker';
import { BsDropdownModule,BsDropdownConfig } from 'ngx-bootstrap/dropdown';
import { ModalModule, BsModalService } from 'ngx-bootstrap/modal';
import { UserDialogComponent } from './users/user-dialog/user-dialog.component';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    UsersComponent,
    UserListComponent,
    UserDialogComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AccordionModule,
    AlertModule,
    ButtonsModule,
    FormsModule,
    CarouselModule,
    CollapseModule,
    BsDatepickerModule.forRoot(),
    BsDropdownModule,
    ModalModule,
    TooltipModule.forRoot(),
    ReactiveFormsModule
  ],
  providers: [AlertConfig, BsDatepickerConfig, BsDropdownConfig,BsModalService, DatePipe],
  bootstrap: [AppComponent],
})
export class AppModule { }
