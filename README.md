# Avery Dennison Sales API

REST API project for getting sale informations using C# and .NET

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

```
.NET Core 3.1
Swashbuckle Swagger AspNet Core v.5.0.0-rc5
```

### Installing

* Download this repository and extract it to any folder.
* Build and run it using a .Net supported IDE such as Visual Studio Code.

### Allowed HTTPs requests:
| Request Type | Use                                 |
| ------------ |:----------------------------------- |
| ~~PUT~~      | ~~To create resource~~              |
| POST         | Update resource                     |
| GET          | Get a resource or list of resources |
| ~~DELETE~~   | ~~To delete resource~~              |

### Description Of Usual Server Responses:

* 200 OK - the request was successful.
* 201 Created - the request was successful and a resource was created.
* 204 No Content - the request was successful but there is no representation to return (i.e. the response is empty).
* 400 Bad Request - the request could not be understood or was missing required parameters.
* 401 Unauthorized - authentication failed or user doesn't have permissions for requested operation.
* 403 Forbidden - access denied.
* 404 Not Found - resource was not found.
* 405 Method Not Allowed - requested method is not supported for resource.

## Endpoints

| Request Type          | Endpoint                    | What it does                                       |
| -----------------     |:--------------------------- |:-------------------------------------------------- |
| ``GET``               | /api/Sales/All              | Returns list of sold article details.              |
| ``GET``               | /api/Sales/All/Revenue      | Returns list of revenues by article numbers.       |
| ``GET``               | /api/Sales/Daily            | Returns count of sold articles by day.             |
| ``GET``               | /api/Sales/Daily/Revenue    | Returns list of article revenues by day.           |
| ``POST``              | /api/Sales/Add/Sale         | Adds new sale into memory/database.                |


## Example API Fields

| Field Name | Description                                 | Data type |
| ------------------ |:----------------------------------- |:--------- |
| ``articleNumber``  | Alphanumeric article number         | string    |
| ``salesPrice``     | Price of the article                | double    |
| ``day``            | Short form of day name              | string    |
| ``revenue``        | Income from article/s               | double    |
| ``count``          | Count of article/s                  | integer   |


## Example API Calls

### curl -X GET "http://localhost:5500/api/Sales/All" -H "accept: text/plain"
Example output:
```
[
  {
    "articleNumber": "1AVFX4",
    "salesPrice": 8,
    "day": "Tue"
  },
  {
    "articleNumber": "5GBH631A",
    "salesPrice": 14,
    "day": "Sun"
  },
  {
    "articleNumber": "1AVFX4",
    "salesPrice": 8,
    "day": "Mon"
  },
  {
    "articleNumber": "5GBH631A",
    "salesPrice": 14,
    "day": "Tue"
  }
]
```

### curl -X GET "http://localhost:5500/api/Sales/All/Revenue" -H "accept: text/plain"
Example output:
```
[
  {
    "articleNumber": "1AVFX4",
    "revenue": 16
  },
  {
    "articleNumber": "5GBH631A",
    "revenue": 28
  }
]
```

### curl -X GET "http://localhost:5500/api/Sales/Daily" -H "accept: text/plain"
Example output:
```
[
  {
    "day": "Tue",
    "count": 2
  },
  {
    "day": "Sun",
    "count": 1
  },
  {
    "day": "Mon",
    "count": 1
  }
]
```

### curl -X GET "http://localhost:5500/api/Sales/Daily/Revenue" -H "accept: text/plain"
Example output:
```
[
  {
    "day": "Tue",
    "revenue": 22
  },
  {
    "day": "Sun",
    "revenue": 14
  },
  {
    "day": "Mon",
    "revenue": 8
  }
]
```

### curl -X POST "http://localhost:5500/api/Sales/Add/Sale" -H "accept: text/plain"


## Versioning

| Version       | Date            | Changes                                  |
| ------------- |:---------------:|:---------------------------------------- |
| v1.0.0        | 03/01/2020      | Initial development                      |
| v1.0.1        | 03/01/2020      | Added more comments and cleaned the code |


## Sources

* [c# groupby](https://csharp.net-tutorials.com/linq/grouping-data-the-groupby-method/)
* [c# append tuple to list](https://stackoverflow.com/questions/42785492/adding-an-item-to-a-tuple-in-c-sharp)
* [c# add tuples into list](https://stackoverflow.com/questions/23779824/c-sharp-adding-to-list-of-tuples-with-a-function)

