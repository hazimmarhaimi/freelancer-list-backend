
# FreelancerWebService API Documentation

The `FreelancerWebService` API provides endpoints to manage and retrieve freelancer data. It serves as the backend for the Freelancer List application.

## Base URL

The base URL for accessing the API is: `http://localhost:55149/api/FreelancerData`

> Note: Replace `localhost:55149` with the actual hostname and port where your API is hosted.

## Endpoints

### Fetch All Freelancers

- **URL:** `/api/FreelancerData`
- **Method:** `GET`
- **Description:** Retrieve a list of all freelancers.

**Example Response:**

```json
[
  {
    "Id": 1,
    "Username": "john_doe",
    "Email": "john@example.com",
    "PhoneNumber": "1234567890",
    "Skillsets": "Web Development, UI/UX Design",
    "Hobby": "Reading"
  },
  {
    "Id": 2,
    "Username": "jane_smith",
    "Email": "jane@example.com",
    "PhoneNumber": "9876543210",
    "Skillsets": "Graphic Design, Video Editing",
    "Hobby": "Painting"
  },
  // More freelancer objects...
]
```

### Create a New Freelancer

- **URL:** `/api/FreelancerData`
- **Method:** `POST`
- **Description:** Create a new freelancer.

**Example Request Body:**

```json
{
  "Username": "new_user",
  "Email": "new_user@example.com",
  "PhoneNumber": "5555555555",
  "Skillsets": "Data Entry, Writing",
  "Hobby": "Cooking"
}
```

### Update an Existing Freelancer

- **URL:** `/api/FreelancerData/{id}`
- **Method:** `PUT`
- **Description:** Update an existing freelancer by providing the `id` in the URL.

**Example Request Body:**

```json
{
  "Id": 3,
  "Username": "updated_user",
  "Email": "updated_user@example.com",
  "PhoneNumber": "1111111111",
  "Skillsets": "Programming, Project Management",
  "Hobby": "Gardening"
}
```

### Delete a Freelancer

- **URL:** `/api/FreelancerData/{id}`
- **Method:** `DELETE`
- **Description:** Delete a freelancer by providing the `id` in the URL.

### Filter Freelancers

- **URL:** `/api/FreelancerData?criteria={criteria}&value={value}`
- **Method:** `GET`
- **Description:** Filter freelancers based on a specific criteria and value. Replace `{criteria}` with the field name you want to filter and `{value}` with the value you want to filter by.

**Example URL for filtering by skillsets:**

```
/api/FreelancerData?criteria=Skillsets&value=Web Development
```

## Error Handling

In case of any errors during API requests, the API will return appropriate HTTP status codes along with error messages in the response body.

## Status Codes

Here are some of the common HTTP status codes returned by the API:

- `200 OK`: The request was successful.
- `201 Created`: The resource was successfully created.
- `204 No Content`: The request was successful, but there is no response to return.
- `400 Bad Request`: The request could not be understood or was missing required parameters.
- `404 Not Found`: The requested resource could not be found.
- `500 Internal Server Error`: An unexpected condition was encountered.

## Rate Limiting

The API does not have rate limiting in place currently.

## Authentication

The `FreelancerWebService` API does not require authentication for now. However, you may want to implement authentication mechanisms if the application grows and requires user-specific data access.

## Security

Please ensure that the API is hosted securely using HTTPS to encrypt the data transmitted between the client and the server.

## Contributions

Contributions to the `FreelancerWebService` API are welcome. If you find any issues or have suggestions for improvements, feel free to create an issue or submit a pull request.

---

Please feel free to modify and add more details to this documentation as per your project's specific requirements. Make sure to keep it up-to-date with any changes or new features added to the API.
