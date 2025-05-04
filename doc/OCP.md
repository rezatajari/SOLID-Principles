## **Open/Closed Principle (OCP)**

### **Overview of Concept**

The Open/Closed Principle says that **software entities (classes, modules, functions, etc.) should be open for extension but closed for modification**.

This means you should be able to add new behavior to your code without changing the existing code. Instead of modifying a class to handle new logic, you should be able to extend it — typically through inheritance or interface implementation.

---

### **What Is the Problem?**

Imagine a restaurant where the chef must constantly open the recipe book and *rewrite* it every time a new dish is added. This is inefficient and risky — older recipes could break with each change.

In code, when logic is tightly coupled to conditions (e.g., using `if-else` or `switch` to decide behavior), every new case forces you to **change** existing code. This breaks OCP and increases the risk of bugs.

Problems include:

* Fragile code that breaks easily with updates
* Violations of modularity — all logic lives in one place
* Poor scalability when adding new types or features

---

### **My Design and Implementation: The Solution**

I solved this by creating an interface `IFood` with a `Cook()` method, and then implementing it for each food item: `Pizza`, `Burger`, `Salad`.

Now:

* Adding a new food type (e.g., `Pasta`) doesn't require touching existing classes — you just create a new one.
* Your system is *open* to new features (extensions) without modifying the old ones.
* This design supports modularity and safer evolution of code.

---

### **Summary**

My implementation reflects a clean separation of concerns and protects your code from unintended side effects. The `OCP` design allows you to scale functionality by extension, not modification — which is a core strength of flexible and maintainable systems.


