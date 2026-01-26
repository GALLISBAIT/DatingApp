import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../../core/services/account-service';
import { inject } from '@angular/core/primitives/di';

@Component({
  selector: 'app-nav',
  imports: [FormsModule],
  templateUrl: './nav.html',
  styleUrl: './nav.css',
})
export class Nav
{
  private accountService = inject(AccountService)
  protected creds: any = {}

  login(){
    this.accountService.login(this.creds).subscribe({
      next: result => console.log(result),
      error: error => alert(error.message)
    })
  }

}
