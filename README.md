<p align="center">
  <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" width="200" alt="C# Logo">
</p>

<p align="center">
  <a href="https://github.com/farrukh-08/Employee_Management_System">
    <img src="https://img.shields.io/github/stars/farrukh-08/Employee_Management_System" alt="Stars">
  </a>
  <a href="https://github.com/farrukh-08/Employee_Management_System">
    <img src="https://img.shields.io/github/license/farrukh-08/Employee_Management_System" alt="License">
  </a>
</p>

---

# 🧑‍💼 Employee Management System – C# + Oracle DB

A desktop-based **Employee Management System** built using **C# (WinForms)** and connected to an **Oracle database**. This system helps HR/admin staff to **manage employee records, positions, departments, attendance, and payroll** from a clean and functional UI.

---

## ✅ Features

- 🔐 Admin login authentication
- 🧑 Add / Update / Delete employee records
- 🏢 Department and position management
- 📅 Attendance tracking with holiday status
- 💰 Payroll calculation and record keeping
- 🔍 Search, filter, and view employee data
- 📦 Connected to Oracle DB via connection string

---

## 👥 Contributors & Responsibilities

### 🔹 Abdul Basit — Backend & UI Developer

**Backend:**
- Developed Oracle DB schema (tables, constraints, sample data)
- Wrote SQL queries for CRUD operations on all modules (employee, payroll, attendance, etc.)
- Implemented DB connection handling in `.cs` code

**Frontend:**
- Designed `Form1.cs`, `AttendanceForm.cs`, and other WinForms UI components
- Built dashboard layout and navigation structure
- Implemented validations, error messages, and input checks

---

### 🔹 Farrukh Zia — Backend & UI Developer

**Backend:**
- Developed stored procedures and integrated backend logic with UI
- Created models and business logic for employee and payroll modules
- Maintained database normalization and referential integrity

**Frontend:**
- Created reusable form elements and data grids
- Implemented attendance radio buttons (Yes/No) & date picker logic
- Polished UI/UX styling and added functional buttons (search, clear, exit)

---

## 🧰 Tech Stack

- **Language**: C# (.NET Framework, WinForms)
- **Database**: Oracle 11g / 12c
- **IDE**: Visual Studio
- **Others**: `.csproj`, `.sln`, `.sql` dump file

---

## 📂 Project Structure

<pre>
Employee_Management_System/
├── bin/
├── obj/
├── Database/
│   └── employee_mgmt_dump.sql
├── Forms/
│   ├── Form1.cs
│   ├── AttendanceForm.cs
│   ├── PayrollForm.cs
│   └── DepartmentForm.cs
├── Models/
│   ├── Employee.cs
│   ├── Attendance.cs
│   └── Payroll.cs
├── Employee_Management_System.csproj
├── Employee_Management_System.sln
└── README.md
</pre>

---

## ⚙️ Setup Instructions

1. **Clone the Repository**

```bash
git clone https://github.com/farrukh-08/Employee_Management_System.git
cd Employee_Management_System
```

2. **Database Setup**

- Use Oracle SQL Developer or any tool
- Run the SQL script:  
  `Database/employee_mgmt_dump.sql`  
  This will create all required tables: `Employee`, `Department`, `Position`, `Attendance`, `Payroll`, etc.

3. **Open the Project**

- Open `Employee_Management_System.sln` in Visual Studio
- Make sure the Oracle connection string in your `.cs` files (e.g., `Form1.cs`) matches your local DB credentials

4. **Build & Run**

- Hit `Ctrl + F5` or click **Start Without Debugging**
- Use the login form to access the dashboard

---

## 🔐 Default Admin Login (Hardcoded)

- **Username**: `admin`  
- **Password**: `admin123`

---

## 📝 License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

---
