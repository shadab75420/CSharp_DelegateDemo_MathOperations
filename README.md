# C# Delegate Demo Application

## Problem Statement

This project demonstrates the concept of **delegates in C#** using a simple mathematical operations example.
A delegate is used to reference different methods (Add, Subtract, Multiply) dynamically at runtime.

The program shows how a single delegate can point to multiple methods and execute them based on assignment.

---

## Features

* Demonstrates delegate declaration and usage
* Dynamically switches between different methods
* Performs basic arithmetic operations:

  * Addition
  * Subtraction
  * Multiplication
* Shows runtime method binding using delegates

---

## Technologies Used

* C#
* .NET

---

## Functionality Overview

### Delegate

* `MathOperation` delegate is defined to take two integers and return an integer
* It can reference any method with the same signature

### Methods

* `Add(int a, int b)` → returns sum
* `Subtract(int a, int b)` → returns difference
* `Multiply(int a, int b)` → returns product

### Execution Flow

1. Delegate is assigned to `Add` method
2. Delegate is reassigned to `Subtract`
3. Delegate is reassigned to `Multiply`
4. Each time, the delegate executes the currently assigned method

---

## Code Structure

* `Program.cs` → Main execution
* `DelegateDemo` → Contains arithmetic methods
* `MathOperation` → Delegate definition

---

## Sample Output

Delegate ref is created and currently it is pointing to Add()
Since Delegate is pointing to Add() so the result of Addition is 15

Now the delegate ref is changed and currently it is pointing to Subtract()
Since Delegate is pointing to Subtract() so the result of Subtraction is 5

Now the delegate ref is changed and currently it is pointing to Multiply()
Since Delegate is pointing to Multiply() so the result of Multiplication is 50

---

## How to Run the Code

1. Open the project in Visual Studio
2. Build the solution
3. Run the program (Ctrl + F5 or F5)
4. Observe how delegate changes method execution

---

## Key Concepts

* Delegates in C#
* Method referencing
* Runtime method switching
* Loose coupling

---

