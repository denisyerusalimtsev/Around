import { Component, OnInit } from '@angular/core';
import { CopterService } from '../service/copter.service';
import { NotificationService } from '../service/notification.service';
import { MatDialogRef } from '@angular/material';
import { CopterAggregate } from '../model/copter-aggregate';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { BrandService } from '../service/brand.service';
import { BrandDto } from '../interface/brand-dto';

@Component({
  selector: 'app-dialog-copter',
  templateUrl: './dialog-copter.component.html',
  styleUrls: ['./dialog-copter.component.css']
})
export class DialogCopterComponent implements OnInit {

  coptersForm!: FormGroup;
  brands: BrandDto[];
  constructor(private copterService: CopterService,
    private brandService: BrandService,
    private notificationService: NotificationService,
    public dialogRef: MatDialogRef<DialogCopterComponent>) { }

    ngOnInit() {
      this.coptersForm = new FormGroup({
        id : new FormControl(null),
        name: new FormControl('', {
            validators: [Validators.required]
        }),
        status: new FormControl('', {
          validators: [Validators.required]
        }),
        latitude: new FormControl('', {
          validators: [Validators.required]
        }),
        longitude: new FormControl('', {
          validators: [Validators.required]
        }),
        brandName: new FormControl('', {
          validators: [Validators.required]
        }),
        costPerMinute: new FormControl('', {
          validators: [Validators.required]
        }),
        maxSpeed: new FormControl('', {
          validators: [Validators.required]
        }),
        maxFlightHeight: new FormControl('', {
          validators: [Validators.required]
        }),
        control: new FormControl('', {
          validators: [Validators.required]
        }),
        droneType: new FormControl('', {
          validators: [Validators.required]
        })
    });

    this.brandService.getBrands()
    .subscribe(data => {
      this.brands = data;
      console.log(this.brands);
    });

    this.copterService.getCopters();
  }

  onClear() {
    this.coptersForm.reset();
  }

  onSubmit() {
    /*
    if (this.service.form.valid) {
      const copter = new CopterAggregate(
        this.service.form.controls['name'].value,
        this.service.form.controls['status'].value,
        this.service.form.controls['latitude'].value,
        this.service.form.controls['longitude'].value,
        this.service.form.controls['costPerMinute'].value,
        this.service.form.controls['brandName'].value,
        this.service.form.controls['costPerMinute'].value,
        this.service.form.controls['maxSpeed'].value,
        this.service.form.controls['maxFlightHeight'].value,
        this.service.form.controls['control'].value,
        this.service.form.controls['droneType'].value);
      this.service.createCopter(copter);
    } else {
      const copter = new CopterAggregate(
        this.service.form.controls['name'].value,
        this.service.form.controls['status'].value,
        this.service.form.controls['latitude'].value,
        this.service.form.controls['longitude'].value,
        this.service.form.controls['costPerMinute'].value,
        this.service.form.controls['brandName'].value,
        this.service.form.controls['costPerMinute'].value,
        this.service.form.controls['maxSpeed'].value,
        this.service.form.controls['maxFlightHeight'].value,
        this.service.form.controls['control'].value,
        this.service.form.controls['droneType'].value);
      this.service.updateCopter(copter);
      }
      this.service.coptersForm.reset();
      this.notificationService.success(':: Submitted successfully');
      this.onClose();
      */
    }

  onClose() {
    this.coptersForm.reset();
    this.dialogRef.close();
  }
}
