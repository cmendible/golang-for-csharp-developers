package main

import "fmt"

func main() {
	fmt.Println("Variables in Go")

	// Declaring Variables
	var i, j, k int
	var c, ch string
	var total float32

	// Declaring and Initializing Variables
	var n = 1 // You can ommit the type! It will be infered
	var name = "cmendibl3"
	var average float32 = 23.5

	// note that you can ommit the var statement and infer the type
	z := 0
	username := "cmendibl3"
	pi := 3.14

	// Priting variables so the app compiles.
	fmt.Println(string(i+j+k) + c + ch + fmt.Sprintf("%f", total) + string(n) + name + fmt.Sprintf("%f", average) + string(z) + username + fmt.Sprintf("%f", pi))
}
