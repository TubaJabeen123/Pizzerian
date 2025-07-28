
# 🍕 Pizzerian - Desktop Pizza Ordering System

**Pizzerian** is a desktop-based pizza ordering application built using **C# Windows Forms**. It allows users to register, log in, browse a pizza menu, add items to a cart, and simulate the checkout process. Ideal for learning data handling and user interface design in .NET WinForms.

---

## 🖥️ Technologies Used

* **C#**
* **.NET Framework (WinForms)**
* **CSV Files** for data storage
* **Windows Forms Designer**
* **Visual Studio**

---

## ✨ Features

* User Registration & Login
* Pizza Menu with Add-to-Cart Functionality
* Checkout System
* Data saved using CSV files (e.g., menu, login info)
* Simple and clean UI
* Form-based navigation and validation

---


## Preview


---


## 📁 File Structure Overview

```
Pizzerian/
│
├── RegistrationForm.cs        # User registration form logic
├── loginForm.cs               # Login form logic
├── menu.cs                    # Pizza menu and ordering UI
├── cartItems.cs               # Handles cart item logic
├── checkOut.cs                # Checkout and billing functionality
├── data.cs                    # Data access logic
│
├── info_Login.csv             # Stores login information
├── menus.csv                  # Pizza menu data
├── loginDataSet.xsd           # Login-related dataset schema
│
├── Program.cs                 # Application entry point
├── App.config                 # App configuration file
├── packages.config            # NuGet packages config
└── .resx / .Designer.cs files # UI resources and designer files
```

---

## 🛠️ Getting Started

### Prerequisites

* Visual Studio 2019 or later
* .NET Framework (4.x)

### Steps to Run the Application

1. **Clone the repository:**

   ```bash
   git clone https://github.com/TubaJabeen123/Pizzerian.git
   ```

2. **Open in Visual Studio:**

   * Open the `.csproj` file (`loginForm.csproj`) in Visual Studio.

3. **Build and Run:**

   * Build the project using `Ctrl + Shift + B`.
   * Run the project using `F5`.

---

## 🧪 Test Users (Optional)

You can pre-fill the `info_Login.csv` with user credentials in the format:

```
Username,Password
admin,admin
```
---

## 👩‍💻 Author

**Tuba Jabeen**
📎 [GitHub Profile](https://github.com/TubaJabeen123)

---

## 📄 License

This project is licensed under the MIT License.

---

