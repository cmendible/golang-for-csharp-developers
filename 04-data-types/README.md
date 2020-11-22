# Basic data types in go

Concepts you will learn

* Basic data types in go
* Pass by reference

Go supports the common data types we would expect from a programming language

* bool
* string
* integer
* float
* byte

You have a full list [here](https://tour.golang.org/basics/11)

## How values are passed to function

We will introduce functions later, but note this: depending on the data type, go will pass the variable either by value or by reference.

Basic data types are all passed by value. Meaning a copy of the variable will be made and passed into the function. Any change performed to the variable made within the function won't be reflected outside unless it is returned and assigned again.

More to come!
