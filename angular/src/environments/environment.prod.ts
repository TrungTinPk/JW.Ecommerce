import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Ecommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394/',
    redirectUri: baseUrl,
    clientId: 'Ecommerce_App',
    responseType: 'code',
    scope: 'offline_access Ecommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44361',
      rootNamespace: 'JW.Ecommerce',
    },
  },
} as Environment;
