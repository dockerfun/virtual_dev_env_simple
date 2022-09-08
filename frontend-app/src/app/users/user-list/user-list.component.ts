import {Component, OnInit, TemplateRef } from '@angular/core';
import { User } from '../user.model';
import { UserService } from '../../services/user.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})

export class UserListComponent implements OnInit {
  users: User[];
  isNew: Boolean;
  modalRef: BsModalRef;
  userForm: FormGroup = new FormGroup({
    id: new FormControl(''),
    firstName: new FormControl('string'),
    lastName: new FormControl('string'),
    dateOfBirth: new FormControl('2020-09-08T06:01:10.899Z')
  });

  constructor(private datePipe:DatePipe, private service: UserService, public formBuilder: FormBuilder, private modalService: BsModalService) {}

  ngOnInit(){
    this.reload();
  }

  newUser(template: TemplateRef<any>) {
    this.reload();
  
    this.modalRef = this.modalService.show(template);
  }

  reload() {
    this.isNew = true;
    this.service.getUsers().subscribe((data) => {
      this.users = data;
    });

    this.userForm = this.formBuilder.group({
      id: 0,
      firstName: "",
      lastName: "",
      dateOfBirth: this.datePipe.transform(new Date(),"yyyy-MM-dd")
    });
  }

  createUser(): void {
    this.service.create(this.userForm.value).subscribe((resp) => { this.reload() });
    console.log("User has been created!");
    this.modalRef.hide();
  }

  editUser(user, template: TemplateRef<any>): void {
    this.isNew = false;
    this.userForm = this.formBuilder.group ({
      id: [user.id],
      firstName: [user.firstName],
      lastName: [user.lastName],
      dateOfBirth: this.datePipe.transform(user.dateOfBirth,"yyyy-MM-dd")
    });

    this.modalRef = this.modalService.show(template);
  }

  public updateUser() {
    const { id } = this.userForm.value;
    this.service.update(id, this.userForm.value).subscribe(() => {
      console.log("User has been updated!");
      this.reload();

      this.modalRef.hide();
    });
  }

  deleteUser(id) : void {
    if (confirm("Are you sure?")) {
      this.service.delete(id).subscribe(() => {
        console.log("User has been deleted!");
        this.reload();
      });
    } 
  }

}
