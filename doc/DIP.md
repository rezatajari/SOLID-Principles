## DIP (Dependency Inversion Principle)

### **Concept Overview**

In real life, imagine you run a restaurant. Orders can go:

* To the kitchen directly.
* Or to a cloud system for delivery orders.

You don’t want your main restaurant system to care *where* the order goes — only that it is **sent**.
This is the essence of **Dependency Inversion**:

> High-level modules (business rules) should not depend on low-level modules (kitchen, cloud).
> Both should depend on **abstractions**.

---

### **What Was the Problem?**

Originally, my system used:

```csharp
class KitchenOrderService { void Order() { ... } }
class CloudOrderService { void CloudOrder() { ... } }
```

**Issues:**

* No shared interface.
* High-level code must know *which* concrete class to use.
* Changing or testing the system is hard — it's tightly coupled.

---

### **How I Solved It**

I created a shared abstraction:

```csharp
interface IOrderSender { void SendOrder(); }
```

Then both implementations followed the same contract:

```csharp
class KitchenOrderSender : IOrderSender { ... }
class CloudOrderSender : IOrderSender { ... }
```

Now, the main system can depend on `IOrderSender` instead of knowing the details of each service.

---

### **Benefits**

* Loose coupling: You can swap implementations easily.
* Testability: Mock `IOrderSender` in tests.
* Open to extension (e.g., SMS, third-party API), closed to modification of high-level logic.

