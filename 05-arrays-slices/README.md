# "Arrays" of basic data types

Concepts you will learn

* go arrays are static
* go introduces slices as a more "traditional" way to deal with arrays
* go syntax to select values from a slice is very simple

## Arrays in go

Arrays in go are declared in the following way:

```go
var a [2]int // Declares an array of integers whose capacity is 2. The size can't be changed.
series := [4]int{1, 3, 5, 7} // Declares an array of integers whose capacity is 4. The size can't be changed
```

Unlike C# or Java (where arrays are object refence types), arrays in Go are values. If you assign an array to another value or you pass it to a function it is automatically copied (pass by value). Furthermore, a go array has a fixed length and it can't be changed.

## Slices to the rescue

On the other hand, go slices are like C# or Java, reference type structures on which we can append, delete by simply using append or delete functions.

Been a reference type also make slices much more memory efficient, as assigning the value to a new variable or passing the slice to a function won't create a new copy.

A go slice is defined as follows. Very similar to an array, but please note we don't specify the length:

```go
// Slice
numbers := []int{1, 3, 5, 7} // We have 4 items
```

And this is the slice equivalent in C#:

```csharp
var numbers = new int[4] { 1, 3, 5, 7 };
```

You can append elements to the slice in the following way:

```go
numbers := []int{1, 3, 5, 7} // We have 4 items
numbers = append(numbers, 9, 11) // we add 2 more items to the slice

```

```csharp
var numbers = new int[4] { 1, 3, 5, 7 };
numbers = numbers.Append(9).ToArray();
numbers = numbers.Append(11).ToArray();
```

## Selecting values

Selecting values from an array is very simple:

```go
numbers := []int{1, 3, 5, 7} // We have 4 items

// Get the first item
slice1 := numbers[0]
fmt.Println(slice1) // -> [1]

// Remove the first item
slice2 := numbers[1:]
fmt.Println(slice1) // -> [3 5 7]

// Get the first 2 items
slice3 := numbers[:2]
fmt.Println(slice2) // -> [1 3]
```

```csharp
var numbers = new int[4] { 1, 3, 5, 7 };

// Span<T> is the most similar type to Golang's []T.
var span = numbers.AsSpan();

// remove first item
var slice1 = span[0]; // -> [1]

// remove first item
var slice2 = span.Slice(1); // -> [3, 5, 7]

// Get first 2 items
var slice2 = span[0..2]; // -> [1, 3]
```
