# AlgorithmsWithCSharp

## About This Project
This project, **AlgorithmsWithCSharp**, is a personal learning and practice repository where I implement and experiment with various algorithms in C#. The algorithms and data structures implemented here are inspired by the [Algorithms, Part I](https://www.coursera.org/learn/algorithms-part1/) course on Coursera, taught by Professor Robert Sedgewick of Princeton University. The course is based on the renowned textbook "Algorithms, 4th Edition" by Robert Sedgewick and Kevin Wayne, which provides a comprehensive introduction to fundamental algorithms and data structures.

Although the course is designed for Java, I am converting my learning to C# and implementing the algorithms in my own style and project structure. This approach helps reinforce my understanding of both the algorithms and C# programming.

The goal of this project is to deepen my understanding of algorithmic concepts and improve my C# programming skills. Each algorithm is implemented in its own file, and the `MainRunningProgram` class serves as the entry point to run and test these algorithms.

### Project Structure
```
AlgorithmsWithCSharp/
├── AlgorithmsWithCSharp.csproj
├── AlgorithmsWithCSharp.sln
├── BinarySearch.cs
├── MainRunningProgram.cs
├── StackOfStringsfromLinkedList.cs
├── README.md
├── bin/
└── obj/
```
- `BinarySearch.cs`: Contains the implementation of the binary search algorithm.
- `StackOfStringsfromLinkedList.cs`: Implements a stack data structure for strings using a linked list.
- `MainRunningProgram.cs`: The main entry point to run and test algorithms.
- `AlgorithmsWithCSharp.csproj` and `AlgorithmsWithCSharp.sln`: Project and solution files for .NET.
- `bin/` and `obj/`: Build output and intermediate files.

## Algorithms

### What is an Algorithm?
An algorithm is a step-by-step procedure or a set of rules to solve a specific problem or perform a computation. Algorithms are fundamental to computer science and programming, as they provide a clear method for solving problems efficiently and effectively.

### Table of Contents
| Algorithm Name   | Description                        |
|------------------|------------------------------------|
| [Binary Search](#binary-search) | Efficiently searches a sorted list |
| [Stack (Linked List)](#stack-linked-list) | Stack implementation using a linked list |

### Binary Search
Binary search is an efficient algorithm for finding an item from a sorted list of items. It works by repeatedly dividing the search interval in half. If the value of the search key is less than the item in the middle of the interval, the algorithm continues on the lower half. Otherwise, it continues on the upper half. This process continues until the value is found or the interval is empty. Binary search has a time complexity of O(log n), making it much faster than linear search for large datasets.

### Stack (Linked List)
The stack implemented in `StackOfStringsfromLinkedList.cs` uses a linked list to store string elements. A stack is a linear data structure that follows the Last-In-First-Out (LIFO) principle, where the most recently added element is the first to be removed. Using a linked list allows for efficient push and pop operations without the need to resize arrays. This implementation is useful for scenarios where dynamic memory allocation and efficient element insertion/removal are required.

## How to Run the Project
1. **Ensure you have [.NET 9.0 SDK](https://dotnet.microsoft.com/download) or later installed.**
2. **Open a terminal in the project directory.**
3. **Build the project:**
   ```powershell
   dotnet build
   ```
4. **Run the project (the `MainRunningProgram` class will execute):**
   ```powershell
   dotnet run
   ```

This will execute the code in `MainRunningProgram.cs`, which you can modify to test different algorithms as you add them to the project.
