import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../enviroments/enviroments';

const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      Accept: 'application/json',
      'Access-Control-Allow-Headers': 'Content-Type',
    }),
  };
  
  @Injectable({
    providedIn: 'root',
  })
  export class BaseService {
    url: string = environment.apiUrl;

    constructor(private http: HttpClient) {}

    SetUrl(url: string) {
        this.url = url;
      }
      delete(rota: string) {
        return this.http.delete(`${this.url}${rota}`);
    }
  
    deleteAllBody<T>(rota: string, body: T ): Observable<T[]> {
      return this.http.delete(`${this.url}${rota}`, {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
        }),
        body: body
      }) as Observable<T[]>;
    }
    
    deleteAllHeaders<T>(rota: string, headers: HttpHeaders): Observable<T> {
        return this.http.delete(`${this.url}${rota}`, {
          headers: headers,
        }) as Observable<T>;
      }
    
      get<T>(rota: string): Observable<T> {
        return this.http.get(`${this.url}${rota}`) as Observable<T>;
      }
    
      getHeaders<T>(rota: string, headers: HttpHeaders): Observable<T> {
        return this.http.get(`${this.url}${rota}`, {
          headers: headers,
        }) as Observable<T>;
      }
    
      getAll<T>(rota: string): Observable<T[]> {
        return this.http.get(`${this.url}${rota}`) as Observable<T[]>;
      }
    
      getAllHeaders<T>(rota: string, headers: HttpHeaders): Observable<T[]> {
        return this.http.get(`${this.url}${rota}`, {
          headers: headers,
        }) as Observable<T[]>;
      }
    
      getAllParams<T>(rota: string, params?: HttpParams): Observable<T[]> {
        return this.http.get(`${this.url}${rota}`, {
          params: params,
        }) as Observable<T[]>;
      }
    
      getArquivo(
        rota: string,
        id?: string,
        paramCabecalho?: { headers: HttpHeaders }
      ): Observable<any> {
        return this.http.get<any>(`${this.url}${rota}/${id}`, paramCabecalho);
      }
    
      getArquivos(
        rota: string,
        paramCabecalho?: { headers: HttpHeaders }
      ): Observable<any> {
        return this.http.get<any>(`${this.url}${rota}`, paramCabecalho) as Observable<any>;
      }
    
      post<T>(rota: string, data?: T): Observable<T> {
        return this.http.post(`${this.url}${rota}`, data) as Observable<T>;
      }
    
      put<T>(rota: string, data: T): Observable<T> {
        return this.http.put(`${this.url}${rota}`, data) as Observable<T>;
      }
}