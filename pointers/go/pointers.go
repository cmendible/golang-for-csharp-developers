package main

import (
	"fmt"
)

func main() {
	fmt.Println("pointers in GO")

	// declare a pointer
	var pointer *int
	count := 231418

	// point to the address of count
	pointer = &count

	// read the value of count through pointer
	fmt.Println(*pointer) // 231418

	// set value of count through pointer
	*pointer = 0
	fmt.Println(count) // 0
}
