import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {map, catchError} from 'rxjs/operators';
import {environment} from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private headers: HttpHeaders;

  constructor(protected http:HttpClient) { }
 
  getALL(path:string): Observable<any[]>{
    //we need to append the common url with path that is being passed
    return this.http
      .get(`${environment.apiUrl}${path}`)
      .pipe(
        map((resp) => resp as any[])
      
        );
  }
  //get movie by movieId
  //get userinfo by id
  getOne(path: string, id:number): Observable<any>{
    return this.http
      .get(`${environment.apiUrl}${path}`+'/'+id)
      .pipe(
        map(resp => resp as any)
        );
  }
  create(path:string, resource: any): Observable<any> {
    return this.http.post(`${environment.apiUrl}${path}`,resource)
    .pipe( map( response => response));
  }
  update(path: string, resource) {
    return this.http
      .put(
        `${environment.apiUrl}${path}` + '/' + resource.id,
        JSON.stringify({ isRead: true })
      )
      .pipe(
        map(response => response),
        catchError(this.handleError)
      );
  }

  delete(path: string, id) {
    return this.http.delete(`${environment.apiUrl}${path}` + '/' + id).pipe(
      map(response => response),
      catchError(this.handleError)
    );
  }
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.log(error.error.errorMessage);
      console.error(
        `Backend returned code ${error.status}, ` + `body was: ${error.message}`
      );
    }
    // return an observable with a user-facing error message
    return throwError(error.error.errorMessage);

  }
  }
  
