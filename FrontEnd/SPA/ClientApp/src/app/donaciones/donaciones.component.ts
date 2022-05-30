import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-donaciones',
  templateUrl: './donaciones.component.html'
})
export class DonacionesComponent {
  public donaciones: ListarDonacionElemento[] = [];

  constructor(http: HttpClient, @Inject('API_URL') apiUrl: string) {
    http.get<ListarDonacionResponse>(apiUrl + 'donaciones').subscribe(result => {
      this.donaciones = result.elementos;
    }, error => console.error(error));
  }
}

interface ListarDonacionResponse {
    elementos: ListarDonacionElemento[];
}

interface ListarDonacionElemento {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
