**Warehouse Management System**

**Overview**

This project is a Warehouse Management System developed as a college project to learn Object-Oriented Programming (OOP) principles. The system allows managing customers, products, and orders while ensuring their interconnectivity. It follows a 3-Tier Architecture and is implemented in C#.

**Features**

Customer Management: Add, update, delete, and retrieve customer details.

Product Management: Manage inventory, add new products, update product details, and track stock levels.

Order Processing: Create, update, and manage orders linked to customers and products.

3-Tier Architecture: Separates concerns into Data Access Layer (DAL), Business Logic Layer (BL), and User Interface (UI) for maintainability and scalability.

**Technologies Used**

Programming Language: C#

Architecture: 3-Tier (DAL, BL, UI)

**3-Tier Architectured**

1. Data Access Layer (DAL)

Responsible for direct database interactions.

Contains methods to fetch, insert, update, and delete records.

Uses repository pattern for database abstraction.

2. Business Logic Layer (BL)

Contains core business rules and validations.

Acts as a bridge between the UI and DAL.

Ensures data integrity and proper application flow.

3. User Interface (UI)

Presents data to users and allows interactions.

Calls BL for processing requests.


**License**

This project was created for educational purposes and is not licensed for commercial use.

**Author**

Shyndee - Developed as a college project to learn Object-Oriented Programming.

