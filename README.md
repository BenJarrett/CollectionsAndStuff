# CollectionsAndStuff
# Collections

In Javascript you have arrays and objects. These are the tools you've been using so far to store data. In C# you have [Collections](https://github.com/nss-evening-cohort-8/bangazon-inc/blob/master/orientation/06_COLLECTIONS.md). You'll be learning about only a couple of the most common ones.

.NET has a lot of [different types of collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections). List and Dictionary are the most common ones.

# Language Integrated Query (aka LINQ)

[nashville-software-school/bangazon-inc](https://github.com/nashville-software-school/bangazon-inc/blob/master/book-1-orientation/chapters/LINQ_INTRO.md)

[Language-Integrated Query (LINQ) (C#)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/index)

### The setup

```csharp
public class Student
{	
	public string Name { get; set; }	public bool IsPayingAttention { get; set; }
}
// Just pretend like we constructed some students.
var students = new List<Student> { lwam, wayne, jeressia, andrew };
```

### Method Syntax vs. Query Syntax

There are two ways to use LINQ. They look very different, but accomplish the same goal.

The method syntax looks and acts just like any other method that you
would call on any other class. It has a name, parameters, and a return
value.

### Method syntax

```csharp
var studentsPayingAttention = students
		.Where(student => student.IsPayingAttention)
		.Select(student => student.Name);

// I put my method calls on their own line when using LINQ, but other times I might not
```

The query syntax mimics SQL syntax, which we'll be learning about in a couple weeks, but can be different so it's best not to make assumptions about their similarities.

### Query syntax

```csharp
var studentsPayingAttention =	
					from student in students 
					where student.IsPayingAttention
					select student.Name;
```

These two examples above accomplish the exact same thing. As you're
learning, it's worth doing everything twice. Use both types of syntax
and you'll eventually learn which one you like better. Which one you
prefer to use may depend on the situation and complexity of your task.

## IEnumerable

The return value of all LINQ operations is IEnumerable. Notice the "I" in the front of the word. That idiomatically means it's an interface.

[IEnumerable Interface (System.Collections.Generic)](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=netframework-4.8)
