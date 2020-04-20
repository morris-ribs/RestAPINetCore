# RestAPINetCore

Musicstore API developed in .Net Core

## Install and start MongoDB

Install MongoDB and start it

Install MongoDB: https://docs.mongodb.com/manual/installation/

Start MongoDB Server: `mongod`

Start MongoDB client and create the collection:

```
mongo

> db.use('musicstore')
> db.createCollection('Albums')
```

## Start it


To get the dependencies, run the following command:

`dotnet restore`

Or install the depency packages:

- Newtonsoft Json

`dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.3`


- MongoDB Driver

`dotnet add Musicstore.csproj package MongoDB.Driver`

To start the program:

`dotnet run`

## Test it

List the albums:

`GET http://localhost:5000/api/musicstore`

Get the details of one album: 

`GET http://localhost:5000/api/musicstore/{album_ID}`

Add album to list:

`POST http://localhost:5000/api/musicstore`

and insert the contents of the album to be added in the body of the request (in JSON format)

```JSON
{
    "title": "Title N 1",
    "artist": "Artist N 1",
    "year": 2014
}
```

Update an album of the list:

`PUT http://localhost:5000/api/musicstore/{album_ID}`

and insert the modifications to be done to the album in the body of the request (in JSON format)


```JSON
{
    "title": "Title N 11",
    "artist": "Artist N 11",
    "year": 1999
}
```

Delete an album from the list:

`DELETE http://localhost:5000/api/musicstore/{album_ID}`