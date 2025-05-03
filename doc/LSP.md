## 🍪 L – Liskov Substitution Principle (LSP)

### 🔍 **Overview**

LSP states that **subtypes must be replaceable for their base types** without altering the correctness of the program.
If `A` is a subtype of `B`, then `B`'s consumers should not know the difference when `A` is used.

### 💥 **The Problem**

In our cookie shop, we mixed up a `DogCookie` with regular cookies for humans.
The `Cookie()` method throws an exception if it encounters a `DogCookie`, which violates LSP:

> The `DogCookie` *cannot safely substitute* the base behavior of human cookies.

This is risky and tightly couples behavior to type-checking, which breaks polymorphism.

### ✅ **The Solution**

Separate the behavior for human cookies and pet cookies:

* Create a shared interface: `ICookie`
* Implement `ChocolateChipCookie` and `OatmealRaisinCookie` as edible, human-friendly cookies.
* Create a specific interface `IPetCookie` for pet-only cookies like `DogCookie`.

This design keeps behavior clear and safe:

* Human-oriented systems work only with `ICookie`.
* Pet-related logic can use `IPetCookie` without interfering with human logic.

### 🧠 **Key Takeaways**

* Subtypes must honor the expectations set by the base type.
* Don't introduce exceptions or break normal flow in derived classes.
* Prefer creating **separate interfaces** when behavior diverges significantly.

