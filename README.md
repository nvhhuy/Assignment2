# Assignment 2 - Hotel Management System

## Author

**Nguyễn Võ Hoàng Huy**  
PRN212 - Summer 2025

## Project Description

This is a WPF-based Hotel Management System built with .NET 8. The application provides functionality for managing hotel bookings, customers, rooms, and reservations.

## Features

- **Customer Management**: Add, edit, and manage customer information
- **Room Management**: Manage room information and availability
- **Booking System**: Create and manage hotel reservations
- **Admin Interface**: Administrative functions for hotel management
- **User Authentication**: Secure login system

## Technology Stack

- **.NET 8.0**
- **WPF (Windows Presentation Foundation)**
- **Entity Framework Core**
- **SQL Server**
- **MVVM Architecture Pattern**

## Project Structure

```
├── BusinessObjects/          # Data models and entities
├── DataAccessLayer/          # Database access layer
├── Repositories/             # Repository pattern implementation
├── Services/                 # Business logic services
└── NguyenVoHoangHuyWPF/     # WPF application (UI layer)
```

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 8.0 SDK
- SQL Server (LocalDB or full instance)

### Installation

1. Clone the repository

   ```bash
   git clone https://github.com/yourusername/assignment-2.git
   ```

2. Open the solution file `NguyenVoHoangHuy_PRN212_A02.sln` in Visual Studio

3. Update the connection string in `appsettings.json` to point to your SQL Server instance

4. Build and run the application

### Database Setup

1. Ensure SQL Server is running
2. Update the connection string in `appsettings.json`
3. The application will create the database schema on first run

## Usage

1. Launch the application
2. Login with appropriate credentials
3. Navigate through the different modules:
   - Customer Management
   - Room Management
   - Booking Management
   - Admin Functions

## Architecture

The application follows a layered architecture:

- **Presentation Layer**: WPF UI
- **Business Logic Layer**: Services
- **Data Access Layer**: Repositories and DAOs
- **Data Layer**: Entity Framework and SQL Server

## Contributing

This is an academic project for PRN212 course.

## License

This project is for educational purposes only.

## Contact

**Nguyễn Võ Hoàng Huy**  
Email: [your-email@example.com]  
Course: PRN212 - Summer 2025
