package main

import "fmt"

func main() {
	fmt.Println("Arrays in Go")

	// Array of int
	// Array lenght must be set a declaration time.
	series := [4]int{1, 3, 5, 7}
	fmt.Println(series)

	fruits := [3]string{"banana", "apple", "pear"}
	fmt.Println(fruits)

	// Slice
	numbers := []int{1, 3, 5, 7} // We have 4 items
	fmt.Println(numbers)

	numbers = append(numbers, 9, 11) // we add 2 more items to the slice
	fmt.Println(numbers)

	// remove first item
	slice1 := numbers[1:]
	fmt.Println(slice1) // -> [3 5 7 9 11]

	// Get first 3 items
	slice2 := slice1[:3]
	fmt.Println(slice2) // -> [3 5 7]

	// Get second and third numbers
	slice3 := slice2[1:3]
	fmt.Println(slice3) // -> [5 7]

	// Copy just one item to a new slice. Determined by the length of target array
	slice4 := make([]int, 1)
	copy(slice4, slice3)
	fmt.Println(slice4) // -> [5]

	// Array to slice
	fruitsSlice := fruits[:]
	fmt.Println(fruitsSlice) // -> [banana apple pear]
}
