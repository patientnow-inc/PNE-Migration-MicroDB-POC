# .NET Core Microservice API 🚀  

This microservice API is built using **.NET Core 8** and **Entity Framework Core**. It supports **CRUD operations** for customer data and real-time synchronization between **SQL Server and PostgreSQL**.

---

## **🛠️ Technologies Used**  
✅ **.NET Core 8** - Web API framework  
✅ **Entity Framework Core** - ORM for PostgreSQL and SQL Server  
✅ **Docker** - Containerization  
✅ **Swagger (OpenAPI)** - API documentation  

---

## **🚀 Getting Started**  

### **🔹 1. Clone the Repository**  
```sh
git clone https://github.com/patientnow-inc/PNE-Migration-MicroDB-POC/new/master.git
```
### **🔹 2. Configure Database Connections** 
Update appsettings.json:

### **🔹 3. Install Dependencies**
```sh dotnet restore```

### **🔹 4. Run Database Migrations**
```sh dotnet ef database update```

### **🔹 5. Start the API**
```sh dotnet run```
The API will be available at:
📍 http://localhost:5000 =>http://localhost:5000/swagger/index.html

---

# **🛠️ API Endpoints**
## **🔹 Customers API**

| Method	|    Endpoint         |  Description            |                                                                                                                                                                                                     
| GET	    | /api/customers	    | Get all customers       |

| GET	    | /api/customers/{id}	| Get a customer by ID    |

| POST	  | /api/customers      |	Create a new customer   |

| PUT	    |/api/customers/{id}	| Update customer details |

|DELETE	  |/api/customers/{id}	| Delete a customer       |

