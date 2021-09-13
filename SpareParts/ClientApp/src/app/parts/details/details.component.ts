import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Part } from "src/app/parts/part";
import { PartsService } from "../parts.service";
import { ManufacturerService } from "../manufacturer.service";
import { Manufacturer } from '../manufacturer';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})

export class DetailsComponent implements OnInit {
  id: number;
  currentManufacturerId?: number;
  manufacturerName: string;
  part: Part;

  constructor(
    public partsService: PartsService,
    public manufacturerService: ManufacturerService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['partId'];
    this.partsService.getPart(this.id).subscribe((data: Part) => {
      this.part = data;
      this.currentManufacturerId = data[0].manufId;
    });

    this.manufacturerService.GetManufacturerPart(this.id).subscribe((data: Manufacturer[]) => {
      data.forEach(childObj => {
        if (childObj.selectedYN == true) {
          this.manufacturerName = childObj.name;
        }
      });
    });
  }
}
