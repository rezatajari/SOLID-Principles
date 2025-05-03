## **Single Responsibility Principle (SRP)**

### **Overview of Concept**

The Single Responsibility Principle states that each class or module should have one and only one reason to change — meaning it should handle a single part of the software’s functionality.
In simpler terms: **do one thing, and do it well**.

This principle improves the clarity, maintainability, and testability of code by ensuring that responsibilities are not mixed together in one place.

---

### **What Is the Problem?**

In a real-world analogy, imagine a single person in a restaurant who is expected to cook the food, serve customers, and handle payments. This creates confusion, overload, and inefficiency.
If one part of the task changes (like how payments are handled), the person has to relearn or adapt everything. The same issue applies in software when one class tries to handle too many responsibilities.

In code, this results in:

* Difficulty understanding what the class does
* Increased chance of breaking functionality when making changes
* Low reusability because unrelated tasks are mixed together

---

### **Your Design and Implementation: The Solution**

You separated the concerns into three different roles — cooking, serving, and payment handling — each represented by a class with a single focus.
This way:

* Each part of your program can evolve independently
* The code becomes easier to maintain and scale
* Changes in one area (e.g., how you take orders) do not affect other areas (e.g., cooking logic)

This structure reflects real-life department separation in a business, where roles are clearly defined and each department has its own responsibility.

---

### **Summary**

Your implementation demonstrates SRP by isolating unrelated behaviors into their own components. This aligns with good software architecture and real-world business practices where responsibilities are clearly divided for better efficiency and adaptability.

---

Would you like the same format for the OCP section next?
