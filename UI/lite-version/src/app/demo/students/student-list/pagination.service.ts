import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn:'root'
})
export class PaginateService {

    readonly baseurl = "http://localhost:64640/api/Students/Paging";

    constructor(private http: HttpClient) {

    }

    pagination(page: number, itemsPerPage: number) {
        const url = this.baseurl + "?page=" + page + "&itemsPerPage=" + itemsPerPage;
        return this.http.get(url);
    }
}