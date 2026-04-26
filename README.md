# 📅  Event Scheduler & Calendar | ASP.NET MVC Project

A dynamic event scheduling and management system built with ASP.NET MVC and Entity Framework (Code First).

This application enables users to manage departments, create events, and schedule them through an interactive drag-and-drop calendar interface.

---

## 🚀 Overview

Event Scheduler MVC is designed to simulate a real-world event planning system.

Events are categorized by departments, each assigned a unique color for better visualization. Users can easily organize and manage events directly on the calendar with a smooth and responsive user experience.

---This project was developed as part of the M&Y Yazılım Eğitim Akademisi Danışmanlık program under the mentorship of Murat Yucedag.

## ✨ Features

- Full CRUD operations for departments
- Full CRUD operations for events
- Department-based event categorization
- Color-coded calendar visualization
- Drag-and-drop event scheduling
- Multi-day event support
- Event resizing and date updates
- Real-time operations using AJAX
- Data is persisted to the database without page reload using AJAX
- Interactive and responsive UI
- AdminLTE dashboard integration

---

## 🏗️ System Structure

The application is divided into three main modules:

### 🏢 Department Management
- Create, update, and delete departments
- Assign unique colors to departments
- Organize events based on departments

### 📌 Event Management
- Create and manage events
- Assign events to departments
- Display events in a draggable list

### 📅 Schedule (Calendar) Management
- Display events on calendar
- Drag and drop events to schedule
- Move events between dates
- Resize events for multi-day duration
- Update and delete scheduled events

---

## 🗄️ Database Design

The project follows the **Code First approach** using Entity Framework.

### Main Entities:
- Departments
- Events
- EventSchedules

### Relationships:
- One Department → Many Events
- One Event → One Department
- One Event → Many EventSchedules

The `EventSchedules` table stores the date range (start & end) of each scheduled event.

---

## 🔄 Data Flow

- Data is stored in SQL Server via Entity Framework
- Calendar operations are handled with AJAX
- Event data is transferred between backend and frontend using JSON format
- FullCalendar dynamically renders and updates events

---

## 🧩 Technologies Used

- ASP.NET MVC 5  
- .NET Framework 4.8.1  
- Entity Framework 6 (Code First)  
- SQL Server  
- AdminLTE 3  
- FullCalendar.js  
- Bootstrap  
- jQuery  
- AJAX  
- JSON (data transfer format)  
- HTML5 / CSS3  

---

## 🎯 Purpose of the Project

This project was developed to strengthen practical skills in:

- MVC architecture
- Entity Framework Code First
- Database relationship design
- CRUD operations
- AJAX-based dynamic updates
- Frontend-backend integration
- Interactive UI development

---
## Screenshots From the Project

<img width="1873" height="915" alt="image" src="https://github.com/user-attachments/assets/91cf6a79-3352-43dd-8ae1-5896faf9ffcf" />
<img width="1855" height="255" alt="image" src="https://github.com/user-attachments/assets/bd8076dd-d069-4426-988a-7976935ca95b" />
<img width="1892" height="917" alt="image" src="https://github.com/user-attachments/assets/c651d4b7-8c6f-466a-8095-a896fafb4b66" />
<img width="1875" height="918" alt="image" src="https://github.com/user-attachments/assets/a7ed8aa9-731e-47cc-a435-e0fb0c3779c8" />
<img width="1873" height="911" alt="image" src="https://github.com/user-attachments/assets/8e20d3fd-468c-4940-bc71-fab51181bc92" />
<img width="1876" height="910" alt="image" src="https://github.com/user-attachments/assets/5e7bc844-7fb3-4382-8619-743b51085a95" />
<img width="1149" height="887" alt="image" src="https://github.com/user-attachments/assets/9f14c6f3-053c-4cf3-a36b-00f682d4f47f" />
<img width="926" height="340" alt="image" src="https://github.com/user-attachments/assets/75d0a652-3c90-446c-8042-1090958ba961" />
<img width="932" height="313" alt="image" src="https://github.com/user-attachments/assets/ab7029cf-21ae-45d4-b9aa-75d211be8e66" />
<img width="1611" height="542" alt="image" src="https://github.com/user-attachments/assets/01f2b720-a061-4dad-afbb-c3ea939d87e0" />
<img width="1609" height="311" alt="image" src="https://github.com/user-attachments/assets/2075b5a8-cb51-460f-a568-7fc4ee6c3862" />
<img width="1610" height="311" alt="image" src="https://github.com/user-attachments/assets/7d131333-3d09-48e2-b345-ee066a86ea00" />
<img width="1611" height="604" alt="image" src="https://github.com/user-attachments/assets/0dc380b8-6ee9-460a-a983-490b781dd619" />
<img width="570" height="265" alt="image" src="https://github.com/user-attachments/assets/678ad94a-3c3a-42fa-8c3d-9393efa77677" />
