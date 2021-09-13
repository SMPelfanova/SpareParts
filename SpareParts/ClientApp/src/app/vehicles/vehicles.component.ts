import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-vehicle',
  templateUrl: './vehicles.component.html'
})
export class VehiclesComponent {
  public vehicles: Vehicles[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Vehicles[]>(baseUrl + 'api/Vehicles').subscribe(result => {
      this.vehicles = result;
    }, error => console.error(error));
  }
}

interface Vehicles {
  id: number;
  name: string;
  engine: string;
  fuel: string;
}
