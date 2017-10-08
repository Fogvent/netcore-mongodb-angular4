import {Injectable} from "@angular/core";
import {AuthHttp} from "angular2-jwt";

@Injectable()
export class ApiService {
constructor(private _authHttp:AuthHttp){
}

get(url: string): Promise<any> {
    let myPromise = new Promise((resolve, reject) => {
      
      this._authHttp.get(url)
        .subscribe(
        data => {
          let body = JSON.parse(data['_body']);
          resolve(body);
        },
        err => { 
         reject(err) }
        );
    });

    return myPromise;
  }

  post(url: string,data: any): Promise<any> {
    let myPromise = new Promise((resolve, reject) => {
      
      this._authHttp.post(url,data)
        .subscribe(
        data => {
          let body = JSON.parse(data['_body']);
          resolve(body);
        },
        err => { 
         reject(err) }
        );
    });

    return myPromise;
  }

  put(url: string,data: any): Promise<any> {
    let myPromise = new Promise((resolve, reject) => {
      
      this._authHttp.put(url,data)
        .subscribe(
        data => {
          let body = JSON.parse(data['_body']);
          resolve(body);
        },
        err => { 
         reject(err) }
        );
    });

    return myPromise;
  }

  delete(url: string,data: any): Promise<any> {
    let myPromise = new Promise((resolve, reject) => {
      
      this._authHttp.delete(url,data)
        .subscribe(
        data => {
          let body = JSON.parse(data['_body']);
          resolve(body);
        },
        err => { 
         reject(err) }
        );
    });

    return myPromise;
  }

}