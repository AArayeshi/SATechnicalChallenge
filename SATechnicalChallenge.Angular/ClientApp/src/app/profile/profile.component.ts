import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html'
})
export class ProfileComponent {
  baseUrl = 'https://localhost:44377/api/Profile/';
  profiles: Profile[] = [];

  dtOptions: DataTables.Settings = {};
  // We use this trigger because fetching the list of data can be quite long,
  // thus we ensure the data is fetched before rendering
  dtTrigger: Subject<any> = new Subject();

  constructor(private http: HttpClient) {
  }

  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 10
    };

    this.http.get<Profile[]>(`${this.baseUrl}`).subscribe(result => {
      this.profiles = result;

      // Calling the DT trigger to manually render the table
      this.dtTrigger.next();

    }, error => console.error(error));
  }

  ngOnDestroy(): void {
    this.dtTrigger.unsubscribe();
  }

}

interface Profile {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  gender: string;
  status: boolean;
}
