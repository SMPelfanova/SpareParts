import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { Part } from '../parts/part';

@Injectable({
  providedIn: 'root'
})

export class PartsService {

  private apiURL = "http://localhost:36378/api";
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  constructor(private httpClient: HttpClient) { }

  getParts(): Observable<Part[]> {
    return this.httpClient.get<Part[]>(this.apiURL + '/SpareParts/getparts')
      .pipe(
        catchError(this.errorHandler)
      );
  }

  getPart(id): Observable<Part> {
    return this.httpClient.get<Part>(this.apiURL + '/SpareParts/details/' + id)
      .pipe(
        catchError(this.errorHandler)
      );
  }

  createPart(part): Observable<Part> {
    return this.httpClient.post<Part>(this.apiURL + '/spareparts/create', JSON.stringify(part), this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
      );
  }

  updatePart(id, part): Observable<Part> {
    return this.httpClient.put<Part>(this.apiURL + '/spareparts/edit/' + id, JSON.stringify(part), this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
      );
  }

  deletePart(id) {
    return this.httpClient.delete<Part>(this.apiURL + '/spareparts/delete/' + id, this.httpOptions)
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
