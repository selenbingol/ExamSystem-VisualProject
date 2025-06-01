# LGS Student Tracking Application

This is a Windows Forms Application developed in C# for managing students, exams, and their academic results. The application uses a SQL Server database and features role-based access for admins and students.

##  Features

-  Student registration and user management  
-  Exam creation and result entry  
-  Automatic net score calculation  
-  Subject-specific limits (e.g., 20 Math, 10 History questions)  
-  View student performance graphs  
-  Export exam results as formatted PDF reports  
-  Secure login system with role distinction (Admin vs Student)  
-  Add, edit, and delete functionality for student data and exams  
-  SQL database integration with foreign key structure

## Technologies Used

- C# (.NET Framework, WinForms)
- SQL Server
- iTextSharp (PDF generation)
- ADO.NET (for database interaction)

## Project Structure

- DatabaseConnection.cs – Manages SQL connection  
- AddMyTestForm.cs – Lets students add their own test scores  
- AdminHomeForm.cs – Admin dashboard screen  
- GraphicsForm.cs – Visual graphs for result analysis  
- GraphicsStudent.cs – Student-based graph viewer  
- LoginForm.cs – Login interface for admin and student  
- ManageStudentForm.cs – Add/edit/delete student profiles  
- ManageTestsForm.cs – List and manage test entries  
- ResultsForm.cs – View, update, delete and export exam results  
- StudentHomeForm.cs – Student dashboard and access  
- App.config – Configuration file for database connection  
- Program.cs – Main entry point of the application  
- packages.config – NuGet package references (e.g., iTextSharp)
  

## Logic Highlights

- Trigger on Students table ensures newly added students are also recorded in Users
- Prevents duplicate usernames using pre-insert checks
- Calculates NET = Correct - (Wrong / 4) automatically
- Allows one result per student per exam name


## License

This project is for educational use.
