# SOLID Principles in C#

## S — Single Responsibility Principle (SRP)

### Concept Overview

The Single Responsibility Principle (SRP) is the first principle in SOLID. It says:

> "A class should have only one reason to change."

This means: each class should focus on a single responsibility or functionality.

---

### Problem (Before SRP)

In the `GenerateCook` class, we combined three responsibilities:

* Cooking
* Taking orders and serving
* Handling payments

 **Problem**:
The class violates SRP because it has multiple reasons to change. For example, if the cooking process changes, the same class must be modified, potentially affecting unrelated responsibilities.

---

### Solution (After SRP)

Split the `GenerateCook` class into three separate classes:

* `Cook` for cooking
* `Waiter` for taking orders and serving
* `Cashier` for handling payments

 **Result**:
Each class has a single responsibility, making the code easier to maintain, test, and extend.

---

### Key Takeaways

| Before SRP                  | After SRP                     |
| --------------------------- | ----------------------------- |
| One class does everything   | Each class has one role       |
| Hard to maintain and extend | Easier to manage and test     |
| Prone to bugs               | Cleaner and more modular code |

---

## O — Open/Closed Principle (OCP)

### Concept Overview

The Open/Closed Principle (OCP) is the second principle in SOLID. It says:

> "Software entities should be open for extension, but closed for modification."

This means: you should be able to add new functionality without changing existing code.

---

### Problem (Before OCP)

Imagine a `ReportGenerator` class that generates reports in multiple formats (e.g., PDF, Excel). To add a new format, you must modify the class, which violates OCP.

---

### Solution (After OCP)

Use abstraction and polymorphism:

* Create an interface `IReportFormat`.
* Implement specific classes like `PdfReport` and `ExcelReport`.
* The `ReportGenerator` class depends on the `IReportFormat` interface, not concrete implementations.

 **Result**:
Adding a new format (e.g., `HtmlReport`) requires no changes to the `ReportGenerator` class.

---

### Key Takeaways

| Before OCP                  | After OCP                     |
| --------------------------- | ----------------------------- |
| Modify existing code        | Add new code only             |
| Rigid and error-prone       | Flexible and extensible       |
| Violates abstraction        | Follows abstraction principles |

---

## L — Liskov Substitution Principle (LSP)

### Concept Overview

The Liskov Substitution Principle (LSP) is the third principle in SOLID. It says:

> "Derived classes must be substitutable for their base classes."

This means: a subclass should behave like its parent class without altering its expected behavior.

---

### Problem (Before LSP)

A `Rectangle` class has `Width` and `Height` properties. A `Square` class inherits from `Rectangle` but overrides these properties, breaking the expected behavior of `Rectangle`.

---

### Solution (After LSP)

Avoid inheritance when it violates substitutability. Instead:

* Use composition or separate classes for `Rectangle` and `Square`.

 **Result**:
The design adheres to LSP, ensuring consistent behavior across the hierarchy.

---

### Key Takeaways

| Before LSP                  | After LSP                     |
| --------------------------- | ----------------------------- |
| Violates substitutability   | Adheres to substitutability   |
| Unexpected behavior         | Predictable and consistent    |
| Fragile design              | Robust and maintainable       |

---

## I — Interface Segregation Principle (ISP)

### Concept Overview

The Interface Segregation Principle (ISP) is the fourth principle in SOLID. It says:

> "Clients should not be forced to depend on interfaces they do not use."

This means: large, all-in-one interfaces should be split into smaller, specific interfaces so classes only implement what they actually need.

---

### Problem (Before ISP)

In the `IWorker` interface, we defined four methods:

* `Cook()`
* `Serve()`
* `Clean()`
* `ManageInventory()`

 **Problem**:
Each class is burdened with irrelevant methods, making the code harder to read, maintain, and test.

---

### Solution (After ISP)

Split `IWorker` into specific, minimal interfaces:

* `ICook`
* `IServe`
* `IClean`
* `IManageInventory`

 **Result**:
Each class only knows and uses **exactly what it needs**.

---

### Key Takeaways

| Before ISP                  | After ISP                     |
| --------------------------- | ----------------------------- |
| One fat interface (`IWorker`) | Multiple small interfaces (`ICook`, `IServe`, etc.) |
| Unused methods everywhere   | No implementation overhead    |
| Rigid & hard to extend      | Flexible and role-based       |

---

## D — Dependency Inversion Principle (DIP)

### Concept Overview

The Dependency Inversion Principle (DIP) is the fifth principle in SOLID. It says:

> "High-level modules should not depend on low-level modules. Both should depend on abstractions."

This means: decouple high-level and low-level modules by introducing abstractions.

---

### Problem (Before DIP)

A `PaymentProcessor` class directly depends on a `CreditCardPayment` class. To add a new payment method (e.g., PayPal), you must modify the `PaymentProcessor` class.

---

### Solution (After DIP)

Introduce an abstraction:

* Create an interface `IPaymentMethod`.
* Implement specific classes like `CreditCardPayment` and `PayPalPayment`.
* The `PaymentProcessor` class depends on the `IPaymentMethod` interface, not concrete implementations.

 **Result**:
Adding a new payment method requires no changes to the `PaymentProcessor` class.

---

### Key Takeaways

| Before DIP                  | After DIP                     |
| --------------------------- | ----------------------------- |
| High-level depends on low-level | Both depend on abstractions |
| Hard to extend              | Flexible and modular          |
| Tightly coupled             | Loosely coupled               |
