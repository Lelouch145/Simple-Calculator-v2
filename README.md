# Simple Calculator (C#)

A console-based calculator built in C# that supports multiple operations, history tracking, and file persistence.

---

## Description

This project is an improved version of a basic calculator. It allows the user to perform calculations with multiple numbers, view previous calculations, and save history to a file so it persists between program runs.

The main goal of this project was to practice writing structured, readable code while learning how to handle user input and file storage.

---

## Features

-  Addition with multiple numbers  
-  Subtraction with multiple numbers  
-  Multiplication with multiple numbers  
-  Division with multiple numbers  
-  Power (`^`)  
-  Square root  
-  Modulo (`%`)  
-  View calculation history  
-  Saves history to a file (`history.txt`)  
-  Loads history automatically when the program starts  

---

## How it works

### Menu system
The program displays a menu where the user can select which operation to perform.

### Input handling
To avoid repeating code and to ensure valid input, helper methods are used:

- `GetNumber()` → handles decimal numbers (`double`)
- `GetNumberInt()` → handles integers (`int`)
- `GetCount()` → ensures the user enters more than one number for calculations

### Calculation logic
All calculations are handled in:

Calculate(List<string> history, string operation, string filePath)

- Special operations (`^`, square root, `%`) are handled separately  
- Other operations (`+ - * /`) use loops and a list to handle multiple numbers  

### History system
Each calculation is stored in a readable format, for example:

2 + 3 + 5 = 10  
10 % 3 = 1  
roten ur 9 = 3  

### File handling
The program saves and loads history using file handling:

File.ReadAllLines(filePath);   // Load history  
File.WriteAllLines(filePath, history); // Save history  

This allows the calculator to remember previous calculations even after restarting.

---

## What I learned

- Structuring a larger console application  
- Writing reusable methods  
- Handling user input safely with TryParse  
- Working with lists (List<string>, List<double>)  
- Using loops to handle dynamic input  
- Understanding control flow (if, else, switch)  
- Basic file handling with System.IO  
- Implementing simple data persistence  

---

## Project Structure

- Program.cs → main application logic  
- history.txt → stores saved calculations  

---

## How to run

dotnet run

---

## Future improvements

- Add a graphical user interface (GUI)  
- Add more advanced math operations  
- Improve error handling  
- Add an option to clear history  
- Save data using JSON instead of plain text  

---

## Author

This project was created as part of a learning journey in C# and software development, with a focus on building a strong programming foundation and preparing for further studies.
