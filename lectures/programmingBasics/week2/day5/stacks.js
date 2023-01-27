// Stack - LIFO (Last in first out)

let dishes = [] // putting the dishes in a stack after washing them
console.log("Empty Stack:",dishes)

let theDishes = "Grandmas Dishes" // This is the dishes before we stack them
console.log("The Dishes:", theDishes)
theDishes = "rats live on no evil star"  // creates a palindrome
theDishes = 'tacocat'
theDishes = 'taco cat'
theDishes = 'Sos'
// theDishes = 'sos'
theDishes = 24 + "42"

// wash the dishes and stack em up
for(let i = 0; i < theDishes.length; i++) {
    dishes.push(theDishes[i])
}
console.log("Grandmas dishes in the stack:", dishes)
let size = theDishes.length

// Grandma is having company and she wants us to set the table
let table = ''
console.log("the emtpy table", table)
console.log(dishes.length)
for(let i = 0; i < size; i++){
    table += dishes.pop()
}

console.log("the table is set", table)
console.log("empty stack job well done", dishes)

if (table === theDishes) {
    console.log(`${theDishes} is a palindrome`)
} else {
    console.log(`${theDishes} is not a palindrome`)
}