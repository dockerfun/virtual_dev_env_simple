import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { User } from '../users/user.model';
import { map, Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url = 'http://localhost:5271/user';


  constructor(private http: HttpClient) {}

  httpOptions = {
    headers: new HttpHeaders({
      "Content-Type": "application/json",
    }),
  };

  getUsers(): Observable<User[]> {
        return this.http.get(this.url).pipe(
          map((users: User[]) =>
            users.map((user) => {
              return new User(user.id, user.firstName, user.lastName, user.dateOfBirth );
            })));
  }

  create(user: User) {

      if(!user.dateOfBirth)
      {
        user.dateOfBirth = new Date();
      }

      user.id = 0;
      console.log('Here: '+JSON.stringify(user))

      return this.http.post(this.url, JSON.stringify(user), this.httpOptions);
      //.subscribe((resp) => { console.log(resp) }, (error) => { console.log(error) });
  }
  
  update(id: number, user: User): Observable<User> {
      return this.http.put<User>(this.url + "?id=" + id, JSON.stringify(user), this.httpOptions);
  }
  
  delete(id: number) {
      return this.http.delete<User>(this.url + "?id=" + id, this.httpOptions);
  }
}
