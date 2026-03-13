# 🏛️ Low-Level Design (LLD) & Design Patterns

A curated collection of industry-standard design patterns implemented in **.NET 10**. This repository serves as a reference for building maintainable, scalable, and testable software using **SOLID principles**.

## 🚀 Patterns Implemented

### 1. Strategy Design Pattern (`/StrategyDP`)
**Problem:** A class has multiple ways to perform a task (e.g., different compression algorithms or payment methods), and using `if/else` or `switch` statements makes the code rigid and hard to maintain.

**Solution:** Define a family of algorithms, encapsulate each one, and make them interchangeable. This lets the algorithm vary independently from clients that use it.

**Key Benefits:**
- **Open/Closed Principle:** Add new strategies without modifying existing context code.
- **Clean Code:** Eliminates massive conditional blocks.
- **Testability:** Each strategy can be unit tested in isolation.

## 🛠️ Tech Stack
- **Language:** C# / .NET 10
- **IDE:** Visual Studio 2026
- **Principles:** SOLID, DRY (Don't Repeat Yourself)

## 📁 Project Structure
- `StrategyDP/`: Contains the interface definitions and concrete implementations for the Strategy pattern.
