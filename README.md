# Simple Calculator – C#

A console-based calculator built in C#.  
The application allows users to perform mathematical operations, handle multiple inputs, track calculation history, and persist data between sessions.

This project started as a basic calculator and was later **extended and improved** with additional functionality such as multi-number operations, history tracking, and file persistence — demonstrating iterative development and code improvement.

---

## ✨ Features

- Addition (multiple numbers)  
- Subtraction (multiple numbers)  
- Multiplication (multiple numbers)  
- Division (multiple numbers)  
- Power (`^`)  
- Square root  
- Modulo (`%`)  
- Menu-based user interface  
- Input validation using `TryParse`  
- Protection against division by zero  
- View calculation history  
- Save and load history from a file (`history.txt`)  

---

## ⚙️ Technologies Used

- C#  
- .NET Console Application  
- System.IO (file handling)  
- Collections (`List<T>`)  

---

## 🧠 How It Works

The program is structured using methods to separate logic and improve readability.

### Input handling
Reusable helper methods are used to ensure valid input:

- `GetNumber()` → handles decimal numbers (`double`)  
- `GetNumberInt()` → handles integers (`int`)  
- `GetCount()` → ensures multiple values are entered  

### Calculation logic
All operations are handled in a central method:

- Supports dynamic input using lists  
- Uses loops to process multiple numbers  
- Handles special operations (`^`, square root, `%`) separately  

### History system
Each calculation is stored in a readable format, for example:
- 2 + 3 + 5 = 10
- 10 % 3 = 1
- roten ur 9 = 3

### File persistence
- History is saved using `File.WriteAllLines()`  
- History is loaded using `File.ReadAllLines()`  

This ensures **data persistence between runs**.

---

## 📋 Example Menu
— SIMPLE CALCULATOR —
	1.	Addition
	2.	Subtraction
	3.	Multiplication
	4.	Division
	5.	Power
	6.	Square Root
	7.	Modulo
	8.	View History
	9.	Exit

---

## 📚 Concepts Demonstrated

This project demonstrates core C# and backend fundamentals:

- Methods and code structure  
- Loops (`while`, `for`)  
- Conditional logic (`if`, `switch`)  
- Input validation (`TryParse`)  
- Working with collections (`List<T>`)  
- File handling (`System.IO`)  
- Basic error handling  
- Program flow control  

---

## 📈 Project Evolution

This project was developed in stages:

- Initial version:
  - Basic operations (+, -, *, /)  
  - Simple menu system  
  - Input validation  

- Improved version:
  - Support for multiple numbers  
  - Added advanced operations (`^`, √, `%`)  
  - Implemented calculation history  
  - Added file persistence  
  - Improved structure and reusability  

This reflects a **real-world development approach**, where features are added and code is continuously improved.

---

## 🎯 What I Learned

While building this project I practiced:

- Structuring a larger console application  
- Writing reusable and modular methods  
- Handling user input safely  
- Working with collections and dynamic data  
- Implementing file persistence  
- Improving and refactoring existing code  

---

## 🚀 Future Improvements

- Add a graphical user interface (GUI)  
- Add more advanced mathematical operations  
- Improve error handling  
- Add option to clear history  
- Store data using JSON instead of plain text  
- Refactor logic using LINQ for cleaner data handling  

---

## 🎓 Purpose

The purpose of this project is to strengthen my understanding of C# and software development by building practical applications and continuously improving them.
