// Assignament 1
#region part 1
#region Add both single-line and multi-line comments in the following code segmentexplaining its purpose:
using System.Drawing;
using System.IO.Pipes;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

int x = 10;
// declare x equale 10
int y = 20;
int sum = x + y;
Console.WriteLine(sum);
/*
 declare y equale 20 , sum equale x plus y and print Value of sum
 */
#endregion

#region What is the shortcut to comment and uncomment a selected block of code in VisualStudio ?
/*
 - Comment a block of code:
Ctrl + K, Ctrl + C
 - Uncomment a block of code:
Ctrl + K, Ctrl + U
 */
#endregion

#region Identify and fix the errors in this code snippet
// x declared integer so we can`t in " " and y not declared so we can`t print ( x + y )
/*
 correct code => int x = 10;
console.WriteLine(x);
 */
#endregion

#region What is the shortcut to comment and uncomment a selected block of code in VisualStudio ?
/*
 1. Runtime Error
Happens while the program is running.
Causes the program to crash or stop unexpectedly.
Example: Dividing by zero.
Example :
int a = 10;
int b = 0;
Console.WriteLine(a / b); => Error : Division by zero

2. Logical Error
Happens when the program runs but gives the wrong result.
The program doesn’t crash but behaves incorrectly due to a mistake in logic.
Example: Using the wrong formula.
Example Code:

csharp
Copy code
int length = 5, width = 3;
int area = length + width; => Logical Error: Should be length * width
Console.WriteLine("Area: " + area);
 */
#endregion

#region Declare variables using proper naming conventions to store:
string FullName = "Fady Emad";
int age = 19;
int MonthlySalary = 5000;
bool student_or_not = true;

#endregion

#region Why is it important to follow naming conventions such as PascalCase in C#?
// Your code becomes more clear and readable, shaping future teamwork debugging and maintenance
#endregion

#region Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object
// -> Point is a class <-
Point p1 = new Point();
p1.X = 20;
p1.Y = 10;
Point p2 = p1;
Console.WriteLine($" P2 => {p2}");
Console.WriteLine($" P1 => {p1}");
p1.X = 30;
Console.WriteLine("AFTER");
Console.WriteLine($" P2 => {p2}");
Console.WriteLine($" P1 => {p1}");
#endregion

#region 
/*
Value Types:
Location: Stored in the stack.
Behavior on Assignment: When copied, a new independent copy is created.
Examples: int, float, struct.
Effect of Change: Changing one variable does not affect others.

Reference Types:
Location: Stored in the heap.
Behavior on Assignment: Copies the reference (address), both variables point to the same object.
Examples: class, string, array.
Effect of Change: Changing the object through one reference affects all references pointing to it.
*/
#endregion

#region Create a program that calculates the following using variables x = 15 and y = 4:
int x = 15;
int y = 4;
Console.WriteLine($"Sum = {x + y}");
Console.WriteLine($"Difference = {x - y}");
Console.WriteLine($"Product = {x * y}");
Console.WriteLine($"Division result = {x / y}");
Console.WriteLine($"mod result = {x % y}");
#endregion

#region What will be the output of the following code? Explain why:
/* result = 2 because 2 % 7 don`t has Remainder */
#endregion

#region Write a program that checks if a given number is both: Greater than 10 , Even.
int x = 5;
bool check = false;
if (x % 2 == 0 || x > 10)
{
    check = true;
}
else
{
    check = false;
}
#endregion

#region Implement a program that takes a double input from the user and casts it to an int. Use both implicit and explicit casting, then print the results.
double input1 = Convert.ToDouble(Console.ReadLine());
double input2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine((int)input2);
Console.WriteLine((int)input1);
#endregion

#region Write a program that: (G01 Bonus, G02 mandatory)
string InputAge = "15";
int age = int.Parse(InputAge);
bool check = false;
if (x % 2 == 0 && x > 10)
{
    check = true;
}
else
{
    check = false;
}
#endregion

#region What exception might occur if the input is invalid and how can you handle it
/* if you stored integer value in string variable ,  so you can fix it by casting */
#endregion

#region MyRegion
int x = 5;
Console.WriteLine(x++);
Console.WriteLine(++x);
#endregion

#region Given the code below, what is the value of x after execution? Explain why
/* 
 y = 12 ( 6+6 )
 */
#endregion

#endregion
#region Part 2

#region 
/* Compiled Languages:
What it is: The source code is converted to machine code (binary) ahead of time by a compiler.
Example: C, C++
Pros: Faster performance, runs directly on the hardware.
Cons: Platform - specific, takes time to compile.
Interpreted Languages:
What it is: The source code is read and executed line by line by an interpreter at runtime.
Example: Python, JavaScript
Pros: More portable(works on different platforms), no need to compile.
Cons: Slower execution, no optimization.
What About C#?
C# is a hybrid:
Compilation: C# is first compiled to Intermediate Language (IL), which is not machine-specific.
JIT Compilation: When running, the .NET runtime (CLR) converts the IL code to machine code for the specific platform using JIT (Just - In - Time) compilation.
Summary:
Compiled languages are turned into machine code before running.
Interpreted languages are read and executed line by line at runtime.
C#: It is compiled to IL first, then JIT-compiles to machine code when running. */
#endregion
#endregion