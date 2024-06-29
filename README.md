# Inventory Management System

![Inventory Management System](https://i.ibb.co/WsdqtNt/Inventory-management-1.png)

## Overview
The Inventory Management System is a robust solution built with ASP.NET MVC to streamline the process of managing stock, tracking sales, and handling orders. This system is ideal for businesses of all sizes looking to optimize their inventory processes.

## Features
- **User Authentication**: Secure login system with username and password.
- **Inventory Tracking**: Keep real-time track of your stock levels.
- **Sales Management**: Record and manage sales transactions.
- **Order Handling**: Efficiently manage purchase orders.
- **Reporting**: Generate comprehensive reports on inventory status and sales performance.

## Installation
To get the Inventory Management System up and running on your local machine, follow these steps:

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (v5.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any other compatible database)
- [Git](https://git-scm.com/)

### Steps
1. **Clone the repository**
    ```bash
    git clone https://github.com/HossainRifat/inventory_management.git
    cd inventory-management-system
    ```

2. **Set up database**
   - Create a new database in SQL Server.
   - Update the connection string in `appsettings.json`:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
    }
    ```

3. **Run database migrations**
    ```bash
    dotnet ef database update
    ```

4. **Build the application**
    ```bash
    dotnet build
    ```

5. **Run the application**
    ```bash
    dotnet run
    ```

6. **Access the application**
    Open your browser and go to `http://localhost:5000`

## Usage
### Login
- **Username**: `admin`
- **Password**: `12345678`

Once logged in, you can start managing your inventory, recording sales, and handling orders.

## Contributing
Contributions are welcome! Please follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a Pull Request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or feedback, please reach out to us at [rh140025@gmail..com](mailto:rh140025@gmail.com).

---

**Follow me on [Facebook](https://www.facebook.com/rrriiifffaaattt) and [LinkedIn](https://www.linkedin.com/in/rh140025/) for updates!**
