import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root'
})
export class BusyService {
  busyRequestCount = false;

  constructor(private spinnerService: NgxSpinnerService) { }

  busy() {
    // this.busyRequestCount = true;
    this.spinnerService.show(undefined, {
      type: 'timer',
      bdColor: 'rgba(255,255,255,0.7)',
      color: '#333333'
    });
  }

  idle() {
    // this.busyRequestCount = false;
    if(!this.busyRequestCount) {
      this.spinnerService.hide();
    }
  }
}
