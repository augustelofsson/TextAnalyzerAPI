# Simple text-analyze REST API built on .NET

An API that takes a textinput and returns the top 10 words that occurs in the text and how many times the word occurs.
## Prerequisites

In order to build this project you'll need .NET 5.0 SDK installed:
https://dotnet.microsoft.com/download

### Install & setup

```bash
npm install
F5 to build the project
```
#### NOTE: 
Locally: </br>
The project won't open up your browser after being built. To use the API either use the built in Swagger UI by heading to https://localhost:5001/swagger/index.html or use an API platform like Postman

Or use the hosted URL: http://textanalyzer.northeurope.azurecontainer.io/ 

## Endpoints


* **URL**
/api/Analyze/?text=

* **Method:**

  `GET`
  
 *  **URL Params**

   **Required:**
 
   `text=[string]`
   
  * **Success Response:**

    * **Code:** 200 <br />
    
  ```
  {
  "analyzedWords": [
    {
      "name": "test",
      "count": 1
    },
    {
      "name": "testing",
      "count": 1
    }
  ]
}
```

* **Error Response:**
* **Code:** 404 NOT FOUND <br />

* **Sample Call:** <br />
curl -X GET "https://localhost:5001/api/Analyze?text=test%20testing" -H  "accept: text/plain" <br />
https://localhost:5001/api/Analyze?text=test%20testing
