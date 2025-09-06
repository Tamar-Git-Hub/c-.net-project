# Store Management System - C# Project

## Project Description
This project implements a store management system that allows managing inventory, products, promotions, and customers. The system enables the store manager to process purchases, calculate the final order total, and apply promotions to reduce prices. The system is built with a modular architecture using common design patterns.

## Project Architecture
The project is divided into several layers, each serving a specific purpose:

- **DalTest:** Console project for manual testing of the data layer.
- **DalFacade:** Project defining interfaces for CRUD operations (Create, Read, Update, Delete) on data.
- **DalList:** In-memory data storage layer.
- **DalXml:** XML-based data storage layer for persistence between runs.
- **Tools:** Helper functions, including logging operations to log files.
- **BL:** Business logic layer, including calculations and data validation.
- **UI:** Graphical interface for user interaction.

## Key Features
- **Data Management:** Perform CRUD operations on data using DalList and DalXml layers.
- **Price Calculations:** Compute product prices including promotions and discounts.
- **Order Management:** Add products to orders and manage inventory.
- **Logging:** Record actions and exceptions in monthly log files.

## Prerequisites
- Visual Studio or another C# compatible IDE.
- .NET Framework or .NET Core installed.

## Installation & Running

### Step 1: Clone the Repository
```bash
git clone https://github.com/Tamar-Git-Hub/c-.net-project.git
```
### Step 2: Build the Project
1. Open the project in Visual Studio.
2. Click on **Build** to compile the solution.

### Step 3: Run the Project
1. Set the **UI** project as the startup project.
2. Click the **Start** button to run the system.

### Step 4: Using the System
Once the system is running, you can:
- Add products, customers, and promotions.
- Enter order data and calculate totals.
- Apply discounts and promotions to orders.
- Monitor logs for system actions and exceptions.
