// Stack - LIFO (Last in first out)

let dishes = [] // putting the dishes in a stack after washing them
console.log("Empty Stack:",dishes)

let theDishes = "Grandmas Dishes" // This is the dishes before we stack them
console.log("The Dishes:", theDishes)
// theDishes = "rats live on no evil star"  // creates a palindrome
// theDishes = 'tacocat'
// theDishes = 'taco cat'
// theDishes = 'Sos'
// theDishes = 'sos'
// theDishes = 24 + "42"

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

// if (table === theDishes) {
//     console.log(`${theDishes} is a palindrome`)
// } else {
//     console.log(`${theDishes} is not a palindrome`)
// }

for(let i = 0; i < table.length; i++) {
    dishes.push(theDishes[i])
}
console.log("the table is cleaned up", table)
console.log("Dishes washed and in a stack", dishes)

// class Stack {
//     constructor() {

//     }
// }
let Stack = function() {
    this.count = 0
    this.storage = {}

    this.push = function(value) {
        this.storage[this.count] = value  //  pushing give value into theTrunk at value i = this.count
        this.count++
        console.log("Item added to trunk count is:", this.count)
        return this
    }
    this.peek = function() {
        console.log(this.storage[this.count-1]) // print to term the object at index i -1
        // return this.storage[this.count-1]
        return this
    }
    this.newPeek = function(num) {
        console.log(this.storage[num])
        return this
    }
    this.pop = function() {
        if (this.count === 0) {
            return undefined;
        }
        else {
        this.count--;
        var result = this.storage[this.count];
        delete this.storage[this.count];
        return result;
        }
    }
    this.size = function() {
        return this.count;
    }
}

let theTrunk = new Stack()
let kaitlynnsTrunk = new Stack()

theTrunk.push('Antique Dress').push('Coding Books').push([1,2,3,4])
// theTrunk.push('Coding Books')
// theTrunk.push([1,2,3,4])
theTrunk.peek().newPeek(1)

kaitlynnsTrunk.push("Coding Books")
kaitlynnsTrunk.peek()

