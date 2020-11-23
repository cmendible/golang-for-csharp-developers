package main

import "fmt"

type Student struct {
	// Uppercase is public
	Email string
	// Lowercase is private
	password string
}

// GetPassword is a Public function
func (u Student) GetPassword() string {
	return u.getPassword()
}

// getPassword is a Private function
func (u Student) getPassword() string {
	return u.password
}

func main() {
	fmt.Println("Access Modifiers in Go")

	student := Student{"username@student.io", "password"}
	fmt.Println("email: " + student.Email)
	fmt.Println("password: " + student.GetPassword())
}
