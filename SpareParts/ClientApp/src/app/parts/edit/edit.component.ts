import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { Part } from "../part";
import { PartsService } from "../parts.service";
import { Manufacturer } from "../manufacturer";
import { ManufacturerService } from "../manufacturer.service";

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  partId: number;
  part: Part;
  manufacturers: Manufacturer[] = [];
  errorMessage: any;
  editForm;

  constructor(
    public partsService: PartsService,
    public manufacurerService: ManufacturerService,
    private route: ActivatedRoute,
    private router: Router,
    private formBuilder: FormBuilder
  ) {
    this.editForm = this.formBuilder.group({
      partId: [''],
      serialNr: ['', Validators.required],
      name: ['', Validators.required],
      manufId: [''],
      manufacId: [''],
      details: [''],
      price: [''],
    });
  }

  ngOnInit(): void {
    this.partId = this.route.snapshot.params['partId']; 

    this.manufacurerService.GetManufacturerPart(this.partId).subscribe((data: Manufacturer[]) => {
      this.manufacturers = data;
      this.editForm.patchValue(data);

    });

    this.partsService.getPart(this.partId).subscribe((data: Part) => {
      this.part = data;
      this.editForm.patchValue(data);
    });
  
  }
  showMsg: boolean = false;

  onSubmit(formData) {
    this.partsService.updatePart(this.partId, formData.value).subscribe((res) => {
      this.router.navigateByUrl('parts/' + this.partId + '/details');
      this.showMsg = true;
    });
  }
}
