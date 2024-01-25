# API Endpoints Documentation

## Summary

This document provides detailed information about the API endpoints defined in the Program.cs file of an ASP.NET Core application.

### Get /books

- **HTTP Method:** GET
- **Path:** `/books`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
[
	{
	'Id': 1,
	'Title': 'Sample Book Title',
	'Description': 'Sample Description',
	'Author': 'Sample Author',
	'CreatedDate': '2023-01-01',
	'Genre': 'Sample Genre'
	},
	{
	'Id': 2,
	'Title': 'Sample Book Title',
	'Description': 'Sample Description',
	'Author': 'Sample Author',
	'CreatedDate': '2023-01-01',
	'Genre': 'Sample Genre'
	}
]
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

### Get /book/<code style="color : Fuchsia">{id}</code>

- **HTTP Method:** GET
- **Path:** `/book/{id}`
- **Parameters:** `int id`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
{
'Id': 1,
'Title': 'Sample Book Title',
'Description': 'Sample Description',
'Author': 'Sample Author',
'CreatedDate': '2023-01-01',
'Genre': 'Sample Genre'
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.


### Get /book/random

- **HTTP Method:** GET
- **Path:** `/book/random`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
{
    'Id': 34,
	'Title': 'The Random Book Title',
	'Description': 'Sample Description',
	'Author': 'Sample Author',
	'CreatedDate': '2023-01-01',
	'Genre': 'Sample Genre'
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

### Post /book

- **HTTP Method:** POST
- **Path:** `/book`
- **Parameters:** `[FromBody] Book book`

#### Request Example

```yaml
{
    'Title': 'Example Book Title',
	'Description': 'Example Description',
	'Author': 'Example Author',
	'CreatedDate': '2024-01-19',
	'Genre': 'Example Genre'
}
```

#### Response

```yaml
{
    'Id': 5000,
	'Title': 'Sample Book Title',
	'Description': 'Sample Description',
	'Author': 'Sample Author',
	'CreatedDate': '2024-01-19',
	'Genre': 'Sample Genre'
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.

### Put /book/<code style="color : Fuchsia">{id}</code>

- **HTTP Method:** PUT
- **Path:** `/book/{id}`
- **Parameters:** `int id, [FromBody] Book book`

#### Request Example

```yaml
{
    'Title': 'Example Book Title',
	'Description': 'Example Description',
	'Author': 'Example Author',
	'CreatedDate': '2024-01-19',
	'Genre': 'Example Genre'
}
```

#### Response

```yaml
{
    'Id': 1,
	'Title': 'Sample Book Title',
	'Description': 'Sample Description',
	'Author': 'Sample Author',
	'CreatedDate': '2024-01-19',
	'Genre': 'Sample Genre'
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

### Delete /book/<code style="color : Fuchsia">{id}</code>

- **HTTP Method:** DELETE
- **Path:** `/book/{id}`
- **Parameters:** `int id`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
{
    'Id': 1,
	'Title': 'Sample Book Title',
	'Description': 'Sample Description',
	'Author': 'Sample Author',
	'CreatedDate': '2023-01-01',
	'Genre': 'Sample Genre'
}
```

#### Error Codes

- **204 No Content:** The request has succeeded and indicates that the resource has been removed but there is no message body to further describe the action or the status
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

### Get /dogs

- **HTTP Method:** GET
- **Path:** `/dogs`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
[
    {
        'Id': 1,
	    'Name': 'Sample Dog Name',
	    'Owner': 'Sample Owner',
	    'Breed': 'Sample Breed',
	    'Friends': [
            2,
            3
        ]
    },
    {
        'Id': 2,
	    'Name': 'Sample Dog Name 2',
	    'Owner': 'Sample Owner',
	    'Breed': 'Sample Breed',
	    'Friends': [
            1,
            3
        ]
    }
]
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.

### Get /dog/random

- **HTTP Method:** GET
- **Path:** `/dog/random`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
{
    'Id': 45,
	'Name': "The Random Sample Dog's Name",
	'Owner': 'Sample Owner',
	'Breed': 'Sample Breed',
	'Friends': [
        2,
	    3
    ]
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.

### Get /dog/<code style="color : Fuchsia">{id}</code>

- **HTTP Method:** GET
- **Path:** `/dog/{id}`
- **Parameters:** `int id`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
{
    'Id': 1,
	'Name': 'Sample Dog Name',
	'Owner': 'Sample Owner',
	'Breed': 'Sample Breed',
	'Friends': [
        2,
    	3
    ]
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

### Post /dog

- **HTTP Method:** POST
- **Path:** `/dog`
- **Parameters:** `[FromBody] Dog dog`

#### Request Example

```yaml
{
    'Name': 'Example Dog Name',
	'Owner': 'Example Owner',
	'Breed': 'Example Breed',
	'Friends': [
        2,
	    3,
    	4
    ]
}
```

#### Response

```yaml
{
	'Id': 5000,
    'Name': 'Example Dog Name',
	'Owner': 'Example Owner',
	'Breed': 'Example Breed',
	'Friends': [
        2,
	    3,
	    4
    ]
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.

### Put /dog/<code style="color : Fuchsia">{id}</code>

- **HTTP Method:** PUT
- **Path:** `/dog/{id}`
- **Parameters:** `int id, [FromBody] Dog dog`

#### Request Example

```yaml
{
    'Name': 'Example Dog Name',
	'Owner': 'Example Owner',
	'Breed': 'Example Breed',
	'Friends': [
        2,
	    3,
	    4
    ]
}
```

#### Response

```yaml
{
    'Name': 'Example Dog Name',
	'Owner': 'Example Owner',
	'Breed': 'Example Breed',
	'Friends': [
        2,
	    3,
	    4
    ]
}
```

#### Error Codes

- **200 OK:** The request has succeeded.
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

### Delete /dog/<code style="color : Fuchsia">{id}</code>

- **HTTP Method:** DELETE
- **Path:** `/dog/{id}`
- **Parameters:** `int id`

#### Request Example

_No request body required for this endpoint._

#### Response

```yaml
{
    'Id': 1,
	'Name': 'Sample Dog Name',
	'Owner': 'Sample Owner',
	'Breed': 'Sample Breed',
	'Friends': [
        2,
	    3
    ]   
}
```

#### Error Codes

- **204 No Content:** The request has succeeded and indicates that the resource has been removed but there is no message body to further describe the action or the status
- **400 Bad Request:** The server could not understand the request due to invalid syntax.
- **404 Not Found:** The server can not find the requested resource.

