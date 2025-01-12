# NullReferenceException in C# Example

This repository demonstrates a common C# error: `NullReferenceException`.  The code attempts to access a member of a class without ensuring it has been initialized.

## Bug
The `Bug.cs` file contains a simple class `ExampleClass` that has a property `MyProperty`. The `MyMethod` attempts to access the property and call its `ToString` method without checking for null. If `MyProperty` is null, this will throw a `NullReferenceException`.

## Solution
The `BugSolution.cs` file shows a corrected version of the class, which handles the potential null values using the null-conditional operator (`?.`) or a null check before accessing the member.

This example highlights the importance of defensive programming and checking for null values before accessing members that might be uninitialized or null.