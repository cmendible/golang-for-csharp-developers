package main

import "fmt"

func main() {
	fmt.Println("Data types in Go")

	// String
	s := "this is a string" // var s string = "this is a string"

	// Boolean
	b := true // var b bool = true

	// Integer
	i := 1 // var i int = 1

	// Float
	f := 1.222 // var f float64 = 1.222

	// Byte
	byteValue := 0x00C9 // var byteValue byte = 0x00C9

	// Printing variables so the app builds.
	if b {
		fmt.Println(s + fmt.Sprintf(" and a number %f", float64(i)+f) + string(byteValue))
	}
}
