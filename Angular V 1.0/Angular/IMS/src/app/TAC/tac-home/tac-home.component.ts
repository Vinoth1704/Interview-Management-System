import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/Services/authentication.service';

@Component({
  selector: 'app-tac-home',
  templateUrl: './tac-home.component.html',
  styleUrls: ['./tac-home.component.css']
})
export class TacHomeComponent implements OnInit {

  title = 'Home'
  constructor(private route: Router, private auth: AuthenticationService) { }

  ngOnInit(): void {
  }

}
