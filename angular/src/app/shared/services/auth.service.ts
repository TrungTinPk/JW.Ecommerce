import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequestDto, LoginResponseDto } from '../models';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { ACCESS_TOKEN, REFRESH_TOKEN } from '../constants/common';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
  constructor(private httpClient: HttpClient) {
  }
    public login(input: LoginRequestDto) : Observable<LoginResponseDto> {
      const body = {
        username: input.userName,
        password: input.password,
        client_id: environment.oAuthConfig.clientId,
        client_secret: environment.oAuthConfig.dummyClientSecret,
        grant_type: 'password',
        scope: environment.oAuthConfig.scope
      }
      const data = Object.keys(body)
        .map((key,index) => `${key}=${encodeURIComponent(body[key])}`)
        .join('&');
      return this.httpClient.post<LoginResponseDto>(
        environment.oAuthConfig.issuer + 'connect/token',
        data,
        {headers: {
            'Content-Type': 'application/x-www-form-urlencoded'
          }
        }
        )
    }

    public isAuthenticated(): boolean {
      return localStorage.getItem(ACCESS_TOKEN) !== null;
    }

    public logout() {
      localStorage.removeItem(ACCESS_TOKEN);
      localStorage.removeItem(REFRESH_TOKEN);
    }
}
