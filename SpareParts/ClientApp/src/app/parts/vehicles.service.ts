import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { Vehicle } from '../parts/vehicle';

@Injectable({
  providedIn: 'root'
})
export class VehiclesService {

  private apiURL = "http://localhost:36378/api";

  constructor(private httpClient: HttpClient) { }

  getVehicles(): Observable<Vehicle[]> {
    return this.httpClient.get<Vehicle[]>(this.apiURL + '/SpareParts')
      .pipe(
        catchError(this.errorHandler)
      );
  }

  errorHandler(error) {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }
}
