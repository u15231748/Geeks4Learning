import { Component, OnInit } from '@angular/core';
import { MdbModalRef, MdbModalService } from 'mdb-angular-ui-kit/modal';
import { ToastrService } from 'ngx-toastr';
import { CaptureGoalsComponent } from './capture-goals/capture-goals.component';
import { LunchTimeNotificationComponent } from './lunch-time-notification/lunch-time-notification.component';
import { ReviewGoalsComponent } from './review-goals/review-goals.component';



@Component({
  selector: 'app-attendence-register',
  templateUrl: './attendence-register.component.html',
  styleUrls: ['./attendence-register.component.css']
})
export class AttendenceRegisterComponent implements OnInit {

  modalDialog: MdbModalRef<CaptureGoalsComponent> | null = null;
  modalRef: any;
  time= new Date();
  today= new Date();
  todaysDataTime = '';
 

  constructor(
    private modalService: MdbModalService,
    private toastr: ToastrService,
  
  ) { }

  ngOnInit(): void {

    
   
  }

  CreateGoalsDialog() {
    this.modalDialog = this.modalService.open(CaptureGoalsComponent, {
      animation: true,
      backdrop: true,
      containerClass: 'modal top fade modal-backdrop',
      ignoreBackdropClick: false,
      keyboard: true,
      modalClass: 'modal-xl modal-dialog-centered',
    });
  }

  
  LunchDialog() {
    this.modalDialog = this.modalService.open(LunchTimeNotificationComponent, {
      animation: true,
      backdrop: true,
      containerClass: 'modal top fade modal-backdrop',
      ignoreBackdropClick: false,
      keyboard: true,
      modalClass: 'modal-xl modal-dialog-centered',
    });
  }

  
  GoalsDialog() {
    this.modalDialog = this.modalService.open(ReviewGoalsComponent, {
      animation: true,
      backdrop: true,
      containerClass: 'modal top fade modal-backdrop',
      ignoreBackdropClick: false,
      keyboard: true,
      modalClass: 'modal-xl modal-dialog-centered',
    });
  }
 
}
