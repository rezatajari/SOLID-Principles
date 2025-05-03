## ISP — Interface Segregation Principle

### 📌 Concept Overview

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

Then, we created two worker roles:

* `Chef` only **cooks**, but is forced to implement and throw `NotImplementedException()` for the rest.
* `Waiter` only **serves and cleans**, but is forced to handle cooking and inventory, even though they don’t.

➡️ **Problem**:
Each class is burdened with irrelevant methods, making the code harder to read, maintain, and test. It violates separation of responsibilities and introduces fragility.

---

### Solution (After ISP)

Split `IWorker` into specific, minimal interfaces:

* `ICook`
* `IServe`
* `IClean`
* `IManageInventory`

Now:

* `NewChef` implements `ICook` and `IManageInventory`.
* `NewWaiter` implements `IServe` and `IClean`.

➡️ **Result**:
Each class only knows and uses **exactly what it needs**. The design is cleaner, more modular, and future-proof.

---

### Key Takeaways

| Before ISP                    | After ISP                                           |
| ----------------------------- | --------------------------------------------------- |
| One fat interface (`IWorker`) | Multiple small interfaces (`ICook`, `IServe`, etc.) |
| Unused methods everywhere     | No implementation overhead                          |
| Rigid & hard to extend        | Flexible and role-based                             |
| Prone to break/change         | Easier to maintain and test                         |

---

