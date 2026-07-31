<!-- HEADER BANNER -->
<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:000000,100:e50914&height=200&section=header&text=🎬%20Movie%20Manager&fontSize=55&fontColor=ffffff&desc=Cinema%20Ticket%20Booking%20%26%20Management%20System&descAlignY=75" width="100%" alt="Movie Manager Banner" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows" />
  <img src="https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Framework-WinForms-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt="WinForms" />
  <img src="https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Graphics-OpenTK-000000?style=for-the-badge&logo=opengl&logoColor=white" alt="OpenTK" />
</p>

---

## 🍿 Overview

**IT008_MovieManager** is a full-scale desktop application for managing an entire cinema's operations — not just a movie catalog. Developed as part of the software engineering curriculum (IT008), it covers the whole customer journey from account creation to seat selection, snack ordering, payment, and ticket issuance, alongside back-office tools for staff, inventory, vouchers, and revenue analytics.

The application is built on a layered **DAO / DTO** architecture on top of WinForms, backed by a normalized SQL Server database (with an included ER diagram), and ships with the team's full project report (`BaoCaoDoAn.docx`).

---

## ✨ Key Features

### 🔐 Authentication & Accounts
- **Sign Up / Sign In** with account profile display and avatar support.
- **Forgot Password flow** with OTP-style verification (`ForgetPassword` → `ForgetPassVerification` → `ResetPassConfirm`).

### 🎥 Movie & Cinema Management
- **Movie CRUD:** Add, edit, and browse movies with poster images (`MovieManage`, `Edit_MovieManage`, `MovieDisplay`, `SelectMovie`).
- **Cinema & Screen Layout:** Manage cinema rooms and interactive seat-map layouts for seat selection (`Cinema`, `ScreenLayout1/2/3`), rendered with OpenTK for custom graphics.
- **Showtime Scheduling:** Create and view showtimes per movie/screen (`ShowTimeManage`, `AddShowTime`, `Info_ShowTime`).

### 🎟️ Ticketing & Payment
- **Ticket Booking & Display:** Select seats/movies and generate tickets (`MovieTicket`, `TicketDisplay`).
- **Payment Processing:** Multiple payment methods with a dedicated checkout flow (`Payment`, `PaymentMethod`).
- **Vouchers & Discounts:** Apply and manage discount vouchers (`VoucherManage`, `VoucherInput`).

### 🍿 Concessions (Snacks)
- **Snack Catalog & Ordering:** Manage snack inventory, let customers select snacks, and browse the snack menu (`SnackManage`, `Edit_SnackManage`, `SnackDisplay`, `SelectSnack`).
- **Order History:** Track past snack orders (`History_SnackManage`).

### 👥 People Management
- **Customer Management:** Register, edit, and manage customer records (`CustomerManage`, `CustomerInput`, `Edit_CustomerManage`).
- **Staff Management:** Manage staff accounts and roles (`StaffManage`, `Edit_StaffManage`).

### 📊 Analytics
- **Revenue & Business Statistics:** Dedicated analytics and statistics dashboards for management (`Analyst`, `Statistics`).

### 🛠️ Engineering Practices
- **Layered Architecture:** Separate `DAO` (Data Access Object) and `DTO` (Data Transfer Object) layers decoupling the UI from raw SQL access.
- **Data Validation & Parameterized Queries:** Input validation on forms and parameterized SQL to prevent injection.
- **Documented Schema:** Included ER diagram (`Database/Diagram.png`) alongside the raw SQL setup script.

---

## 🏛️ System Architecture

The project follows a layered **3-Tier-style architecture**, implemented concretely through WinForms + DAO + DTO:

1. **Presentation Layer (WinForms):** ~40 dedicated forms covering authentication, movie/cinema/showtime management, ticketing, payments, snacks, customers, staff, and analytics — each with a paired `.Designer.cs` and `.resx` resource file.
2. **DTO Layer (`MovieManager/DTO`):** Plain data-transfer objects that carry structured data (movies, tickets, customers, etc.) between the UI and the data layer.
3. **DAO Layer (`MovieManager/DAO`):** Handles all direct communication with SQL Server — executing queries/stored procedures and mapping results back into DTOs.
4. **Database (SQL Server):** A normalized relational schema, provisioned via `Database/Data.sql`, with the full entity-relationship diagram provided in `Database/Diagram.png`.

---

## 🛠️ Technology Stack

| Component | Technology | Description |
| :--- | :--- | :--- |
| **Frontend / GUI** | `C#` / `WinForms` | ~40 forms covering every part of the cinema workflow. |
| **Graphics** | `OpenTK` | Used for rendering interactive screen/seat layouts. |
| **Backend Logic** | `C#` (DAO/DTO) | Data access and transfer object layers. |
| **Database** | `SQL Server` | Relational database management system. |
| **Query Language** | `T-SQL` | Schema, queries, and stored procedures (`Database/Data.sql`). |
| **IDE** | `Visual Studio` | Primary development environment (`MovieManager.sln`). |

---

## 🗄️ Database Schema Overview

The SQL Server database is normalized and covers the full cinema domain — movies, showtimes, screens/seats, customers, staff, tickets, payments, vouchers, and snacks. The complete schema is defined in `Database/Data.sql`, with a visual ER diagram provided at `Database/Diagram.png` for quick reference.

---

## 📂 Project Structure

Core folders in this repository:

*   **`MovieManager`**: Main WinForms application — all forms, `DAO/`, `DTO/`, and resource assets (`Avatars/`, `CustomerProfilePicture/`, `Posters/`, `Snacks/`, `Resources/`).
*   **`Database`**: SQL setup script (`Data.sql`) and the entity-relationship diagram (`Diagram.png`).
*   **`Data`**: Supplementary data files used by the application.
*   **`Report`**: The team's project report (`BaoCaoDoAn.docx`).
*   **`Symbol`**: Icons/symbols used across the UI.
*   **`MovieManager.sln`**: Visual Studio solution file.

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
   git clone https://github.com/miyxotkem/IT008_MovieManager.git
   ```

2. **Setup the Database:**
   - Open SQL Server Management Studio (SSMS).
   - Locate the `Data.sql` script inside the `/Database` folder of this repository.
   - Execute the script to automatically generate the tables, relationships, and insert sample data.
   - Refer to `Database/Diagram.png` for the full entity-relationship diagram.

3. **Configure the Connection String:**
   - Open the `MovieManager.sln` solution in Visual Studio.
   - Locate the `App.config` file inside the `MovieManager` project.
   - Update the SQL Server connection string to match your local server credentials:
   ```xml
   <connectionStrings>
       <add name="MovieManagerDB" 
            connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=MovieDB;Integrated Security=True" 
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Restore NuGet packages:**
   - Ensure NuGet packages listed in `packages.config` (including OpenTK) are restored before building.

5. **Build and Run:**
   - Set the `MovieManager` project as the **Startup Project**.
   - Press `F5` or click **Start** in Visual Studio to build and compile the application.

---

## 📄 Documentation

- **`Report/BaoCaoDoAn.docx`** — the full project report, covering requirements, design decisions, and implementation details.
- **`Database/Diagram.png`** — entity-relationship diagram of the database schema.

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

**Phạm Đan Trường*  
*Software Engineering Student @ UIT*
* **GitHub:** [@thichcodedao2006](https://github.com/thichcodedao2006)
* **Focus:** Full-Stack .NET, System Architecture & API Design
