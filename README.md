# 🛒 Supermarket ERP System (MVP)

After more than **four months of continuous work**, this project represents the **MVP version of a full ERP system for a supermarket**.  
The system was built by leveraging my academic background in **Management Information Systems (MIS)**, combining **administrative, financial, and technical perspectives** into one integrated solution.

The current version focuses on **MIS (Management Information System)** functionalities.  
The **AIS (Accounting Information System)** layer is planned for future iterations.

---

## 🎯 Project Overview

This ERP system aims to **automate all supermarket operations** by integrating multiple business units into a single centralized system, backed by a unified database.  
The primary goal is to **support management decision-making** through accurate, real-time, and reliable data.

---

## 🛠️ Technologies & Tools

- **Programming Language:** C#
- **Framework:** WinForms
- **Database:** SQL Server
- **Query Language:** T-SQL
- **Data Access:** ADO.NET
- **Architecture:** Three-Tier Architecture + DTO Layer
- **Reporting:** RDLC

---

## 🧠 Technical Highlights

- **Codebase Size:**  
  More than **45,000 lines of code** (C# & T-SQL), written with best practices and clean code principles.

- **Database Design:**  
  - ~50 tables (MVP actively uses 35+ tables)
  - 130+ Stored Procedures
  - 13 Views
  - Multiple Functions and User-Defined Types

- **User Interface:**  
  - Interactive WinForms UI  
  - Focus on usability (UX) and data-entry efficiency  
  - Master–Detail UI pattern for list-based screens

- **Software Engineering Principles:**  
  - SRP (Single Responsibility Principle)  
  - DRY (Don’t Repeat Yourself)  
  - Separation of Concerns (SoC)

- **Design Patterns Applied:**  
  - Observer  
  - Factory  
  - Singleton  
  - Service Layer Pattern  
  - Rich Domain Model  
  - Dependency Inversion

- **Validation System:**  
  - Custom validation framework  
  - Validation enforced at:
    - UI Layer
    - Business Logic Layer
    - Database Layer (Stored Procedures & Triggers)

- **Additional Technical Features:**  
  - Eager & Lazy Loading (context-based)
  - Immutable Data Types for critical entities
  - Windows Registry usage for application-level settings
  - Centralized Event Viewer for logging runtime exceptions

---

## 🚧 Key Challenges

### 1️⃣ Handling Edge Cases
One of the biggest challenges was dealing with **complex edge cases**, where solving one scenario often revealed multiple new ones.  
Through careful analysis and iterative refinement, all critical scenarios were handled, making the system **robust and production-ready**, not just a demo project.

### 2️⃣ Generic Base Form Architecture
To unify the behavior of all list-based screens:
- A **Generic Base Form** was implemented
- Transitioned from **Active Record** to **Service Layer Pattern**
- Applied **Generics & Interfaces** to enable manual Dependency Injection (DI)

This resulted in:
- Centralized handling of search, filtering, deletion, and activation logic
- Easy addition of new list screens
- Event-based updates for real-time UI refresh (Loose Coupling)
- A consistent user experience across the system

---
## 📦 System Scope & Core Modules

### 🤝 Suppliers Management
- Full management of suppliers and all related operations  
- Supplier product lists to track supplied items  
- Detailed tracking of purchase transactions and purchase returns  

---

### 🧩 Products Management
- Management of products and product categories  
- Support for **alternative units** per product  
- Centralized handling of all product-related operations  

---

### 🏷️ Dynamic Discounts & Tax System (Sales-Oriented)
- Discount system linked to **Product + Unit** level  
- Tax system linked to the **Product level**, applying to all its units  
- Ensures accurate pricing and consistent sales calculations  

---

### 📦 Warehouses & Inventory Management (Core Module)
- Management of multiple warehouse types:
  - **Store Warehouse** (system-defined, fixed, non-editable)
  - **Main Warehouse** (single instance)
  - **Sub-Warehouses** (unlimited)
- Advanced inventory system where each stock item represents:  
  **(Product + Unit + Warehouse)**
- Enables precise tracking of available quantities for each product unit in each warehouse
- Complete handling of all inventory-related operations (inventory is a core system concept)
- Internal stock transfer operations between warehouses
- Dedicated screens for:
  - Inventory movement tracking
  - Stock transfer operations with extended details
- Stock Movement module logs **every inbound and outbound transaction**
- Database design prepared for future operations such as:
  - Inventory adjustments
  - Unit conversions
  - Additional inventory workflows  
- This module represents the **most complex and time-intensive part of the system**, functioning as a standalone **Inventory Management System** within the ERP  

---

### 🧾 Invoicing Module
- Purchase invoices and purchase returns  
- Sales invoices and sales returns  
- Comprehensive invoice lifecycle handling, including:
  - Fully paid invoices
  - Partially paid invoices
  - Unpaid invoices
- Issuing payment vouchers for unpaid or partially paid invoices  

---

### 💰 Payments & Receipts Module
- Tracks cash flow through:
  - Cash payments
  - Bank transfers
- Represents the current **financial component** of the system  
- Designed as part of an **MIS (Management Information System)**  
- Prepared for future integration with a full **AIS (Accounting Information System)**, where:
  - AIS will handle accounting logic
  - Payments/Receipts will focus purely on cash flow tracking  

---

### 📊 Reporting Module
- The most critical module and the ultimate output of the entire system  
- Represents the analytical value of the centralized database  
- Designed to support management decision-making  
- Currently includes:
  - **Comprehensive Sales Report**
  - **Comprehensive Purchases Report**
- Database structure allows generating dozens of additional analytical reports in the future; however, the MVP focuses on the two most essential reports for efficiency
  
---

## 🖼️ Screenshots (Placeholders)

### Dashboard / Quick Overview
![Dashboard](screenshots/dashboard.png)

### Products Management
![Products](screenshots/products.png)

### Suppliers Management
![Suppliers](screenshots/suppliers.png)

### Inventory Overview
![Inventory](screenshots/inventory.png)

### Stock Movements
![Stock Movements](screenshots/stock-movements.png)

### Stock Transfers
![Transfers](screenshots/transfers.png)

### Purchase Invoices
![Purchases](screenshots/purchase-invoices.png)

### Sales Invoices
![Sales](screenshots/sales-invoices.png)

### Payments & Receipts
![Payments](screenshots/payments.png)

### Sales Report (Comprehensive)
![Sales Report](screenshots/sales-report.png)

### Purchases Report (Comprehensive)
![Purchases Report](screenshots/purchase-report.png)

### Database Schema
![Database Schema](screenshots/database-schema.png)

---

## 📌 Notes

- This project was built **entirely solo**, covering analysis, design, development, testing, and refinement.
- The MVP focuses on **operational integrity and data accuracy**.
- Future iterations may include:
  - Full AIS implementation
  - Role-based security & permissions
  - Web-based interface

---

## 🔖 Tags
`#ERP` `#MIS` `#CSharp` `#WinForms` `#SQLServer` `#ADO.NET` `#SoftwareArchitecture` `#ProgrammingAdvices`
