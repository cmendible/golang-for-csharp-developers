package main

import "fmt"

func main() {
	fmt.Println("Maps in Go")

	// grades maps
	grades := map[string]int{"math": 5, "chemistry": 5}

	// Printing the math score.
	fmt.Println(grades["math"])

	// check if key is present
	chemistry, ok := grades["chemistry"]
	if ok {
		fmt.Println(chemistry)
	}
}
