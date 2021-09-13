import { Component, OnInit } from '@angular/core';

import { Part } from "../part";
import { PartsService } from "../parts.service";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})

export class ListComponent implements OnInit {
  parts: Part[] = [];

  constructor(public partsService: PartsService) { }

  ngOnInit(): void {
    this.partsService.getParts().subscribe((data: Part[]) => {
      this.parts = data;
    });
  }

  deletePart(id) {
    this.partsService.deletePart(id).subscribe(res => {
      this.parts = this.parts.filter(item => item.partId !== id);
    });
  }
}
