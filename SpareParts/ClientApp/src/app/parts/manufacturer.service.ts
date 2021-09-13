import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { Manufacturer } from '../parts/manufacturer';

@Injectable({
  providedIn: 'root'
})
export class ManufacturerService {

  private apiURL = "http://localhost:36378/api";

  constructor(private httpClient: HttpClient) { }

  getManufacturers(): Observable<Manufacturer[]> {
    return this.httpClient.get<Manufacturer[]>(this.apiURL + '/manufacturers/getmanufacturers')
      .pipe(
        catchError(this.errorHandler)
      );
  }
  getManufacturerById(manufId): Observable<Manufacturer[]> {
    return this.httpClient.get<Manufacturer[]>(this.apiURL + '/manufacturers/getManufacturerById/' + manufId)
      .pipe(
        catchError(this.errorHandler)
      );
  }
  GetManufacturerPart(partId): Observable<Manufacturer[]> {
    return this.httpClient.get<Manufacturer[]>(this.apiURL + '/manufacturers/getmanufacturerpart/' + partId)
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
