## Car Rental Agency Database System
- - -
### README Contents
* Project Description
* Components
* Team Members
* Relational Database Scheme
- - -

### Project Description
This project involves the design and implementation of a relational database system to support the operations of a hypothetical car rental agency. The program allows a customer to process rental reservations, during which they will check for available cars on specific dates and locations. Also, the admin portal allows an adminstrator to log in and add, remove or modify customer information, car information, employee information and pricing information. The admin portal also allows the admin to pull statistics about the most popular branch, employee, top customers and top cars based on filters like Branch, City, Province or Country.
- - -

### Components
* ER Diagram
* Schema Layout 
* Database development
* Graphical User Interface
* Below: Description of the relational database scheme of the system, with discussion regarding design decisions and efficiency. This includes integrity constraints.
- - -

### Team Members
* [Vasu](https://github.com/guptavasu1213)
* [Alex](https://github.com/awworthy)
* [Ahsan](https://github.com/ahshassan)
- - -

## Relational Database Scheme
The database consists of 6 main tables:
1. Branch
2. Car
3. Customer
4. Employee
5. Transaction
6. Type

The Branch table contains information regarding physical agency locations around the world, at which employees work. It is where cars can be rented and returned.

The Car table contains information regarding specific cars available for rent through the company. Identifying information like the VIN is included, as well as information for the customer such as transmission style and seating capacity.

The Customer and Employee tables contain information about the individuals and allows the system to relate them to specific rental transactions

Transactions are used to identify which cars are rented when, by whom, and from whom. They also specify where and when the car will be returned, and help provide a user history. This history can be used for a "Gold membership" upgrade as well as to customize the user experience in other ways.

The Type table relates car types with the various pricing for different rental increments. For example, an SUV may cost more to rent per week than a sedan.

In the Employee and Customer tables, the primary key is a unique ID number. We have also required that all email addresses be unique -- they are used to login and should not appear more than once.

In the source code, some integrity constraints are used to prevent unusual or invalid responses.
* Drop-down menus (combo-boxes) are used to constrain input to a specific set of values when appropriate
* Certain fields (Phone numbers, etc.) will only except numeric characters.
* Date pickers are used to select dates in a concise manner, and are assigned minimum and maximum date ranges as appropriate.
