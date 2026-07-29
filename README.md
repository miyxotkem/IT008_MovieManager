<!-- HEADER BANNER -->
<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:000000,100:e50914&height=200&section=header&text=🎬%20Movie%20Manager&fontSize=60&fontColor=ffffff&desc=Robust%20Desktop%20Application%20for%20Cinematic%20Databases&descAlignY=75" width="100%" alt="Movie Manager Banner" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Framework-WinForms-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt="WinForms" />
  <img src="https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
</p>

---

## 🍿 Overview

**IT008_MovieManager** is a comprehensive desktop software solution engineered to streamline the management of cinematic databases. Developed as part of the software engineering curriculum (IT008), this application emphasizes **tight architectural design**, robust **CRUD operations**, and complex **relational database schemas**.

It provides a seamless, intuitive Graphical User Interface (GUI) for administrators to manage movies, genres, directors, and related metadata efficiently while maintaining strict data integrity.

---

## ✨ Key Features

- **Advanced CRUD Operations:** Seamlessly Create, Read, Update, and Delete movie records with real-time database synchronization.
- **Relational Data Management:** Complex queries and joins managed through T-SQL to handle interconnected data (e.g., mapping movies to multiple genres or actors).
- **Search & Filter Algorithms:** Fast and optimized searching capabilities to instantly locate specific titles, release years, or filter by specific criteria.
- **Data Validation:** Strict input validation on the frontend to prevent SQL execution errors and maintain database health.
- **Secure Database Connections:** Safe execution of parameterized SQL queries to prevent SQL injection attacks.

---

## 🏛️ System Architecture

This project is built using a strict **3-Tier Architecture** to ensure a clean separation of concerns, making the codebase highly scalable and easy to maintain.

1. **Presentation Layer (GUI):** Built with Windows Forms (WinForms). Handles all user interactions, input capturing, and data presentation.
2. **Business Logic Layer (BLL):** Acts as the bridge between the UI and the database. It processes the raw data, applies business rules, and handles computations.
3. **Data Access Layer (DAL):** Dedicated entirely to communicating with the SQL Server database. Executes stored procedures, handles connection strings, and maps SQL data to C# objects.

---

## 🛠️ Technology Stack

| Component | Technology | Description |
| :--- | :--- | :--- |
| **Frontend / GUI** | `C#` / `WinForms` | Event-driven user interface built with the .NET framework. |
| **Backend Logic** | `C#` | Core business logic and data processing. |
| **Database** | `SQL Server` | Relational database management system. |
| **Query Language** | `T-SQL` | Database queries, stored procedures, and schema definitions. |
| **IDE** | `Visual Studio` | Primary development environment. |

---

## 🗄️ Database Schema Overview

The underlying SQL Server database is normalized to ensure zero data redundancy. Core tables include:

*   **`Movies`**: Stores core metadata (`MovieID`, `Title`, `ReleaseDate`, `Duration`, `Rating`).
*   **`Genres`**: Master list of film genres (`GenreID`, `GenreName`).
*   **`Directors`**: Database of filmmakers (`DirectorID`, `FullName`, `DOB`).
*   **`Movie_Genres`**: Junction table resolving the Many-to-Many relationship between Movies and Genres.

---

## 🚀 Getting Started

Follow these instructions to set up the project on your local machine for development and testing.

### Prerequisites
*   **Visual Studio 2019/2022** (with .NET desktop development workload installed)
*   **Microsoft SQL Server** (Express or Developer edition)
*   **SQL Server Management Studio (SSMS)** (Optional, but recommended for DB management)

### Installation & Setup

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/miyxotkem/IT008_MovieManager.git](https://github.com/miyxotkem/IT008_MovieManager.git)
   ```

2. **Setup the Database:**
   - Open SQL Server Management Studio (SSMS).
   - Locate the `Database.sql` script inside the `/Database` folder of this repository.
   - Execute the script to automatically generate the tables, relationships, and insert sample data.

3. **Configure the Connection String:**
   - Open the `IT008_MovieManager.sln` solution in Visual Studio.
   - Locate the `App.config` file in the main startup project.
   - Update the SQL Server connection string to match your local server credentials:
   ```xml
   <connectionStrings>
       <add name="MovieManagerDB" 
            connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=MovieDB;Integrated Security=True" 
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Build and Run:**
   - Set the UI project as the **Startup Project**.
   - Press `F5` or click **Start** in Visual Studio to build and compile the application.

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! 
If you would like to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeatureName`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeatureName`).
5. Open a Pull Request.

---

## 👨‍💻 Team & Collaborators

**Thinh Phat Ho**  
*Software Engineering Student @ UIT*
* **GitHub:** [@miyxotkem](https://github.com/miyxotkem)
* **Focus:** Full-Stack .NET, System Architecture & API Design

**Pham Dan Truong**  
*Software Engineering Student @ UIT*
* **GitHub:** [@thichcodedao2006](https://github.com/thichcodedao2006)
* **Focus:** Full-Stack .NET, System Architecture & API Design
