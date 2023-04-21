import { Component, OnInit } from '@angular/core';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-portafolio',
  templateUrl: './portafolio.component.html',
  styleUrls: ['./portafolio.component.css']
})
export class PortafolioComponent implements OnInit {
 
  nombreUsuario= '';

  constructor(private loginService:LoginService) { }

  ngOnInit(): void {
    this.getNombreUsuario();
  }

  getNombreUsuario(): void{

    this.nombreUsuario = this.loginService.getNombreUsuario();
    console.log(this.nombreUsuario, 'xd')

   
  }

}
