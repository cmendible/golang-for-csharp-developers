package main

import "fmt"

func main() {
	fmt.Println("Maps in Go")

	// grades maps
	grades := map[string]int{"math": 5, "chemestry": 5}

	// Printing the math score.
	fmt.Println(grades["math"])

	// check if key is present
	chemestry, ok := grades["chemestry"]
	if ok {
		fmt.Println(chemestry)
	}
}
