package main

import (
	"encoding/json"
	"fmt"
)

func main() {
	fmt.Println("json in Go")

	// map with student grades
	grades := map[string]int{"math": 5, "chemestry": 5}

	// marshal the map type to json string
	jsonBytes, _ := json.Marshal(grades)

	// print the json string
	jsonString := string(jsonBytes)
	fmt.Println(jsonString)

	// create a map
	res := map[string]int{}

	// unmarshal the json string back to a map
	json.Unmarshal([]byte(jsonString), &res)

	// print the math score
	fmt.Println(res["math"])
}
