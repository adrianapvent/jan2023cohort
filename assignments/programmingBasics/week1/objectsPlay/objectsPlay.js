var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];

//How would you print/log John's age?
console.log(users[1].age)


//How would you print/log the name of the first object?
console.log(users[0].name)


//How would you print/log the name and age of each user using a for loop? Your output should look something like this: Michael - 37, John - 30, David - 27
for (let i = 0; i < users.length; i++){
    let u = users[i]
    console.log(`${u.name} - ${u.age}`)
}

// only need a for loop if it was different objects
// because it was same object you are able to pull within same for loop