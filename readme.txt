# Kitchen Order Flow WebApi Challenge

This repository contains a solution for the **Kitchen Order Flow WebApi Challenge**, a code challenge designed to create a restaurant order routing system. The application is built using **C#** and implements a production-quality HTTP server to route restaurant orders to specific kitchen areas. The project has been designed with best practices in mind, including immutability, proper concurrency handling, separation of concerns, and error handling.

---

## Challenge Overview

The main task is to create a **Restaurant Order Routing System** that receives orders via an HTTP endpoint and routes them to a queue representing the destination kitchen area. The application supports the following kitchen areas:

- Fries
- Grill
- Salad
- Drink
- Dessert

### Key Requirements

1. The application must be executable on both Windows and Unix-based machines.
2. In-process, in-memory storage is used instead of a database.
3. The application is designed to meet production-quality standards:
   - Clear and readable code
   - Unit and integration tests
   - Proper API design
   - Dependency injection
   - Async and sync examples
   - Effective error handling

4. All assumptions and design choices are documented as comments in the source code.

---

## How to Run

### Prerequisites
1. Install the .NET SDK (version 7.0 or later).
2. Set up a text editor or IDE such as Visual Studio or Visual Studio Code.

### Steps
1. Clone this repository:
   `git clone https://github.com/your-repo-name/kitchen-order-flow-webapi-challenge.git`

2. Navigate to the project directory:
   `cd kitchen-order-flow-webapi-challenge`

3. Build the project:
   `dotnet build`

4. Run the application:
   `dotnet run`

---

## API Usage

- **Endpoint**: `POST /orders`
- **Request Body (JSON)**:
  `{ "item": "Burger", "quantity": 2, "kitchenArea": "grill" }`
- **Response**:
  - `202 Accepted`: Order successfully routed to the specified kitchen area.
  - `400 Bad Request`: Invalid kitchen area or malformed request payload.

---

## Tests

### Run Tests
To execute the unit and integration tests, use the following command:
`dotnet test`

---

## Installation Instructions

To install dependencies and run the project, ensure you have the following installed:
- .NET SDK (Version 7.0 or later)

No additional installation steps are required as the project uses in-memory storage.

---

## Future Enhancements

This solution is designed for extensibility and can be extended in the following ways:
- Adding authentication and authorization.
- Enhancing concurrency for distributed systems.
- Incorporating a persistent database for order storage.
- Expanding the system to handle real-time kitchen updates.

---

## Notes

- This solution was anonymized to comply with the challenge guidelines.
- The design and implementation will be further extended with an RDI developer/architect as part of the challenge process.

---

**Good luck and happy coding!**
