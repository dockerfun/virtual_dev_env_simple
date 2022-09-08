import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';


@Component({
  selector: 'app-user-dialog',
  templateUrl: './user-dialog.component.html',
  styleUrls: []
})
export class UserDialogComponent implements OnInit {

  modalRef: BsModalRef;
  constructor(private modalService: BsModalService) {}

  openModal(template: TemplateRef<any>) {
     this.modalRef = this.modalService.show(template);
  }

  ngOnInit(): void {
  }
}
