# Hello world

This first tutorial demonstrates how a hello world looks like in the golang world.

Go concepts you will learn

* package
* import
* fmt
* run
* build

## Package is Namespace

The first concept you will learn is "package". We can compare a package with a C# namespace

```go
package main
```

```csharp
namespace HelloWorld
```

IMPORTANT: Why the namespace is go is main? go requires that a package "main" and a function "main" exists, in order to execute a program. Hence the difference between examples

## Import is Using

The second concept you will learn is "import". The equivalent for us C# developers is "using"

```go
import (
	"fmt"
)
```

```csharp
using System;
```

Check the golang [documentation](https://golang.org/pkg/) to learn about all the standard golang packages you can import and use out of the box.

## We can use fmt to print things to the console

Finally, we can see fmt like a util that is approxiamtely the same as the standard Console class in C# (As will learn, go don't have classes)

```go
fmt.Println("Hello C# Developers!!!")
```

```csharp
Console.WriteLine("Hello C# Developers!!!");
```

IMPORTANT: Remember that go requires a ```package main``` and ```func() main``` to find the entrypoint?

## Run the example

The ```go run``` command will help you running a go program.

IMPORTANT: go run requires you to pass all .go files required to run the go routine.

In this case there is only one file:

```bash
% go run hello-world.go
Hello C# Developers!!!
```

## Build and run the example

The command ```go build```will compile your project.

IMPORTANT: go run requires you to pass all .go files required to run the go routine.

```bash
% go build hello-world.go
% ./hello-world
Hello C# Developers!!!
```
