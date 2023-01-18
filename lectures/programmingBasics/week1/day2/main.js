let arr = [] // This is an array. List of data
let obj = {"name": "Melissa"} // This is an object They contain key/value pairs

// Arrays can contain different data types

let mixedArr = ["Melissa", "is", "feeling", "old", "over", 40]
// console.log(mixedArr)

// push - adding to the end of the array
// pop - remove the last item of the array
// shift - removes the 1st item of the array
// unshift - adds to the beginning of the array
// splice - add/replaces at a specific index

/*
let animals = ["Dog", "Cat", "Bird"]
console.log("**1:", animals)

// Add new animal to the array using push
animals.push("Turtle")
animals.push("Fish")
console.log("**2:", animals)

// remove animal form the array using pop
animals.pop()
console.log("**3:", animals)

// remove animal from array using shift
animals.shift()
console.log("**4:", animals)


// add an animal using unshift
animals.unshift("Rabbit")
console.log("**5:", animals)

// replace animal at index 2 with a new one
// animals.splice(2, 1, "Lion") // goes to index 2, removes 1 item, adds Lion
// animals.splice(2,2, "Lion") // goes to index 2, removes 2 items, adds Lion
// animals.splice(2, 2, "Lion", "Tigers") // goes to index 2, removes 2 items, adds Lion and Tigers
animals.splice(2, 0, "Lions", "Tigers", "Bears") //Goes to index 2, removes 0 items, adds Lions, Tigers, and Bears
console.log("**6:", animals)

// remove the animal at index 1
animals.splice(1,1) // Goes to index 1, removes 1 item
console.log("**7:", animals)
// console.log("**7:" + animals)
console.log(`**7: ${animals}`)
*/

/*
let classMates = ["Sierra",
    "Brianna",
    "Muriel",
    "Dana",
    "Mar'Kebta",
    "Ubin",
    "Aquila",
    "Adriana",
    "Liannys",
    "Jacquelyn",
    "Joslyn",
    "Emily",
    "Lizette",
    "Ashunti",
    "Kaitlynn (Katie)"]

console.log(classMates.length)

for(let i = 0; i < classMates.length; i++) {
    // console.log(`Hello, and Good Morning ${classMates[i]}`)
}
// find a specific classmates name = Dana
for(let i = 0; i < classMates.length; i++) {
    if(classMates[i] == "Dana") {
        // console.log(`Hello ${classMates[i]}, glad you are here`)
    }
    else if (classMates[i] == "Melissa") {
      //  console.log(`What are you up to today ${classMates[i]}?`)
    } else {
        // console.log(`Hope you are having a good day ${classMates[i]}`)
    }
}

classMates.push("Melissa")
console.log(classMates.length)
for(let i = 0; i < classMates.length; i++) {
    if(classMates[i] == "Dana") {
     //   console.log(`Hello ${classMates[i]}, glad you are here`)
    }
    else if (classMates[i] == "Melissa") {
      ////////  console.log(`What are you up to today ${classMates[i]}?`)
    } else {
     /////////   console.log(`Hope you are having a good day ${classMates[i]}`)
    }
}

classMates.splice(3, 0, "Jarell")
console.log(classMates.length)
for(let i = 0; i < classMates.length; i++) {
    if(classMates[i] == "Dana") {
        console.log(`Hello ${classMates[i]}, glad you are here`, i)
    }
    else if (classMates[i] == "Melissa") {
        console.log(`What are you up to today ${classMates[i]}?`, i)
    } else {
        console.log(`Hope you are having a good day ${classMates[i]}`)
    }
}
// i is the index
// classMates[i] is the value at the index

//  Iterating through an array of data
// #1 - the whole data set
console.log(classMates)
// #2 - start narrowing down till you get the information you want
console.log(classMates[3])

*/
let newArr = ["Testing", "Testing123", ["Whats", "up", ["Good", "Questions", "Everyone"]], "Testing456"]
console.log(newArr) // Prints all of it
console.log(newArr[2]) // Prints just the array at index 2
console.log(newArr[2][1]) // Prints the word up located in the array in the array at index 1

console.log(newArr)
console.log(newArr[2])
console.log(newArr[2][2])
console.log(newArr[2][2][0])