# Data types

Concepts you will learn

* Variable declaration
* go doesn't like unused variables!

## Variable declaration

As you can see in the example, go offers to types of variable declaration and initialisation:

Option 1: definition without var (the most common)

```go
username := "cmendibl3"
```

There is no equivalent in the C# world to this way of variable declaration/initialisation

Option 2: var-like initialisation, single with default value and multiple without default value

go

```go
var name = "cmendibl3" // variable declaration with default value. Type is inferred.
var i, j, k int // multiple variable declaration without default value. You should specify the variable type
```

C#

```csharp
var username = "cmendibl3"; // Type inference
string name = "cmendibl3"; // Explicit type defintion
int i, j, k; // Defining multiple variables with explicit type defition
```

Both options are equivalent

## Go don't like unused variables

If you comment the fmt.println statement and try to run or build the program, go will throw an error:

```bash
go run vars.go
# command-line-arguments
./vars.go:9:6: i declared but not used
./vars.go:9:9: j declared but not used
./vars.go:9:12: k declared but not used
./vars.go:10:6: c declared but not used
./vars.go:10:9: ch declared but not used
./vars.go:11:6: total declared but not used
./vars.go:14:6: n declared but not used
./vars.go:15:6: name declared but not used
./vars.go:16:6: average declared but not used
./vars.go:19:2: z declared but not used
./vars.go:19:2: too many errors
```

IMPORTANT: Go don't like unused variables. It won't allow you to run or build your program if you have any!
