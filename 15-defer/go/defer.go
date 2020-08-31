package main

import (
	"fmt"
	"os"
)

func main() {
	fmt.Println("defer in GO")

	// Create a File
	file, _ := os.Create("defer.txt")

	// Defer Closing the file until program exits main function (dispose resources)
	defer file.Close()

	// Write some data to the file
	fmt.Fprintln(file, "some data...")

	// But you can also defer anything
	// Defer printing the string until program exits main function
	defer fmt.Println("C# Developers!!!")

	// Print Hello
	fmt.Println("hello")
}
