package main

import (
	"fmt"
)

func main() {
	fmt.Println("if else in GO")

	value := 1
	if value < 0 {
		fmt.Println("value is negative")
	} else if value == 0 {
		fmt.Println("value is 0")
	} else {
		fmt.Println("value is positive")
	}
}
