# NullReferenceException in C# when accessing a property that might be null.

This repository demonstrates a common error in C#: a `NullReferenceException` that occurs when accessing a property of an object that might be null.  The code in `bug.cs` shows the faulty code, while `bugSolution.cs` provides a corrected version using the null-conditional operator and null-coalescing assignment.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs`.  You'll get a `NullReferenceException`.
3. Compile and run `bugSolution.cs`. This version will handle the null case gracefully.