package main

import (
	"fmt"
	"strconv"
)

func main() {
	fmt.Println("loops in GO")

	// Normal for loop
	// Count form 0 to 9
	for i := 0; i < 10; i++ {
		fmt.Println(i)
	}

	// While like loop
	total := 1
	for total < 1000 {
		total += total
	}
	fmt.Println(total)

	// for each loop
	scores := map[string]int{"math": 5, "chemestry": 5}
	for k, v := range scores {
		fmt.Printf("%s: %s\n", k, strconv.Itoa(v))
	}

	// for each loop with index
	fruits := []string{"apples", "blueberries", "strawberries"}
	for idx, fruit := range fruits {
		fmt.Println(idx, fruit)
	}

	// Infinite loop
	for {
		// do something
	}
}
