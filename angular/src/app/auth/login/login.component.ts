import { Component, OnDestroy } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { LoginRequestDto } from '../../shared/models';
import { AuthService } from '../../shared/services';
import { Subject, takeUntil } from 'rxjs';
import { ACCESS_TOKEN, REFRESH_TOKEN } from '../../shared/constants/common';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styles: [`
        :host ::ng-deep .pi-eye,
        :host ::ng-deep .pi-eye-slash {
            transform:scale(1.6);
            margin-right: 1rem;
            color: var(--primary-color) !important;
        }
    `]
})
export class LoginComponent implements OnDestroy{
    private ngUnsubscribe = new Subject<void>();
    valCheck: string[] = ['remember'];

    loginForm: FormGroup;

    constructor(
        public layoutService: LayoutService,
        private fb: FormBuilder,
        private router: Router,
        private authService: AuthService
    ) {
        this.loginForm = this.fb.group({
            userName: new FormControl('',Validators.required),
            password: new FormControl('',Validators.required)
        });
     }

     login() {
        const request: LoginRequestDto = {
          userName: this.loginForm.controls['userName'].value,
          password: this.loginForm.controls['password'].value,
        };
        this.authService.login(request)
          .pipe(takeUntil(this.ngUnsubscribe))
          .subscribe(res => {
            localStorage.setItem(ACCESS_TOKEN, res.access_token);
            localStorage.setItem(REFRESH_TOKEN,res.refresh_token);
            this.router.navigate(['']);
          })
     }

     ngOnDestroy() {
      this.ngUnsubscribe.next();
      this.ngUnsubscribe.complete();
     }
}
