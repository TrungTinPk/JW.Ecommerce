import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { LayoutService } from "./service/app.layout.service";
import { Router } from '@angular/router';
import { AuthService } from '../shared/services';
import { LOGIN_URL } from '../shared/constants/common';

@Component({
    selector: 'app-topbar',
    templateUrl: './app.topbar.component.html'
})
export class AppTopBarComponent implements OnInit{

    items!: MenuItem[];
    userMenuItems!: MenuItem[];

    @ViewChild('menubutton') menuButton!: ElementRef;

    @ViewChild('topbarmenubutton') topbarMenuButton!: ElementRef;

    @ViewChild('topbarmenu') menu!: ElementRef;

    constructor(
      public layoutService: LayoutService,
      private router: Router,
      private authService: AuthService
    ) { }

  ngOnInit() {
      this.userMenuItems = [
        {
          label: 'Profile',
          icon:'pi pi-id-card',
          routerLink: ['/profile']
        },
        {
          label: 'Change password',
          icon:'pi pi-key',
          routerLink: ['/change-password']
        },
        {
          label: 'Logout',
          icon:'pi pi-sign-out',
          command: event => {
            this.authService.logout();
            this.router.navigate([LOGIN_URL])
          }
        }
      ];
  }
}
