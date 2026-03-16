# MVC-ModelBinding-Demo

This project demonstrates **Model Binding in ASP.NET Core MVC**.  
It shows how ASP.NET MVC automatically maps HTTP request data such as **form values, query strings, route parameters, and JSON body data** to action method parameters and model objects.

The goal of this project is to help developers understand how **Model Binding works internally in ASP.NET Core MVC** through practical examples.

---

# 🚀 Technologies Used

- ASP.NET Core MVC
- .NET 8
- C#
- Razor Views
- jQuery
- Bootstrap
- Visual Studio 2022

---

# 📂 Project Structure

```
MVC-ModelBinding-Demo
│
├── Controllers
│   └── EmployeeController.cs
│
├── Models
│   └── Employee.cs
│
├── Views
│   ├── Employee
│   │   ├── Create.cshtml
│   │   ├── Details.cshtml
│   │   └── JsonExample.cshtml
│
├── wwwroot
│
├── Program.cs
└── appsettings.json
```

---

# 📌 What is Model Binding?

Model Binding is a feature in ASP.NET Core MVC that automatically **maps incoming HTTP request data to action method parameters or model objects**.

Instead of manually extracting values from the request, MVC automatically binds them.

Example request sources:

- Form Data
- Query String
- Route Data
- JSON Body
- Headers

---

# 🧩 Example Model

```csharp
public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Department { get; set; }

    public string Email { get; set; }
}
```

---

# 📌 Model Binding Example

Controller example:

```csharp
[HttpPost]
public IActionResult Create(Employee employee)
{
    return View("Details", employee);
}
```

When the form is submitted, ASP.NET automatically binds form values to the **Employee object**.

---

# 📊 Features Demonstrated

This project demonstrates different types of model binding:

### 1️⃣ Form Data Binding

Data submitted from an HTML form is automatically mapped to a model.

Example:

```
POST /Employee/Create
```

---

### 2️⃣ Query String Binding

Values from the URL query string are bound to parameters.

Example:

```
/Employee/Details?id=1
```

---

### 3️⃣ Route Data Binding

Values from route parameters are automatically mapped.

Example:

```
/Employee/Details/1
```

---

### 4️⃣ JSON Body Binding (AJAX)

JSON data sent via AJAX is automatically converted into model objects.

Example AJAX request:

```javascript
$.ajax({
    url: '/Employee/JsonExample',
    type: 'POST',
    contentType: 'application/json',
    data: JSON.stringify(employee)
});
```

---

# ⚙️ How to Run the Project

### 1 Clone the repository

```
git clone https://github.com/yourusername/MVC-ModelBinding-Demo.git
```

---

### 2 Open the solution

Open the project in **Visual Studio**

```
MVC-ModelBinding-Demo.sln
```

---

### 3 Run the application

Press:

```
F5
```

or run:

```
dotnet run
```

---

# 📷 Example Flow

1. User opens the Create Employee page
2. User enters employee details
3. Form is submitted
4. ASP.NET MVC binds form values to the Employee model
5. Controller processes the data and displays the result

---

# 📚 Learning Purpose

This project is designed to help developers understand:

- How **ASP.NET MVC Model Binding works**
- How request data is mapped to models
- Different types of model binding
- How to use model binding with forms and AJAX

---

# 👨‍💻 Author

**Praveen Anthati**  
.NET Full Stack Developer
