import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { PartsService } from "../parts.service";
import { Manufacturer } from "../manufacturer";
import { ManufacturerService } from "../manufacturer.service";

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})

export class CreateComponent implements OnInit {
  manufacturers: Manufacturer[] = [];
  createForm;
  constructor(
    public partsService: PartsService,
    public manufacturerService: ManufacturerService,
    private route: ActivatedRoute,
    private router: Router,
    private formBuilder: FormBuilder
  ) {
    this.createForm = this.formBuilder.group({
      serialNr: ['', Validators.required],
      name: ['', Validators.required],
      id: [''],
      manufacturers:[],
      manufId: [''],
      manufacId: [''],
      details: [''],
      price: [''],
    });
  }

  ngOnInit(): void {
    this.manufacturerService.getManufacturers().subscribe((data: Manufacturer[]) => {
      this.manufacturers = data;
    });
  }

  onSubmit(formData) {
    this.partsService.createPart(formData.value).subscribe(res => {
      this.router.navigateByUrl('parts/list');
    
    });
  }
}
