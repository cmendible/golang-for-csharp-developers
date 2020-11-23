package main

import "fmt"

func getGenerationName(yearOfBirth int) {
	switch {
	case yearOfBirth > 1997:
		fmt.Println("Post Millenials")
	case yearOfBirth > 1981 && yearOfBirth <= 1996:
		fmt.Println("Millenials")
	case yearOfBirth > 1965 && yearOfBirth <= 1980:
		fmt.Println("Generation X")
	case yearOfBirth > 1946 && yearOfBirth <= 1964:
		fmt.Println("Baby Boomers")
	default:
		fmt.Println("Silent generation")
	}
}

func main() {
	fmt.Println("Switch in Go")

	getGenerationName(1975)
}
