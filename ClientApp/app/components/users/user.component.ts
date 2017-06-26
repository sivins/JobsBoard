import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'user',
    templateUrl: './user.component.html'
})
export class userDataComponent {
    public users: User[];

    constructor(http: Http) {
        http.get('/api/UserData/getAllUsers').subscribe(result => {
            this.users = result.json() as User[];
        });
    }
}

interface User {
    first_name: string;
    last_name: string;
    email: string;
}
