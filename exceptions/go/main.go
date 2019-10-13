package main

import (
	"errors"
	"fmt"
)

func main() {
	fmt.Println("err in GO")

	numbers := []int{-1, 5}

	for _ , num := range numbers {
		if inc, err := increment(num); err != nil {
			fmt.Printf("Failed Number: %v, error message: %v", num, err)
		} else {
			fmt.Printf("Incremented Number: %v", inc)
		}
	}
}

func increment(n int) (int, error) {
	if n < 0 {
		// return error object
		return n, errors.New("math: cannot process negative number")
	}
	return (n + 1), nil
}
