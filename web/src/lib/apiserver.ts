import { dev } from '$app/environment';

export class ApiServer {
  static async get(endpoint: string): Promise<any> {
    const response = await fetch(this.uri(endpoint));
    const data = await response.json();
    
    if (response.ok) { return data; } 
    throw new Error(data);
  }
  
  static async post(endpoint: string, data: object): Promise<any> {
    return this.execute(endpoint, 'POST', data);
  }
  
  static async delete(endpoint: string): Promise<any> {
    return this.execute(endpoint, 'DELETE', undefined);
  }
  
  private static async execute(endpoint: string, method: string, data: object): Promise<any> {
    const response = await fetch(this.uri(endpoint), {
      method: method,
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(data)
    });
    const resdata = await response.json();
    
    if (response.ok) { return resdata; } 
    throw new Error(resdata);
  }
  
  static uri(endpoint: string): string {
    return dev ?  
      `http://localhost:53071/api/${endpoint}` :
      (document.querySelector('base')?.href || '') + `/api/${endpoint}`;
  } 
}