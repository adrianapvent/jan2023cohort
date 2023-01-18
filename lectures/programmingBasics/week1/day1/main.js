// Data Types
// String number undefined boolean null
// console.log is how will view our js before we have a front end

// Camel case = firstWordIsLowerRestAreUpper
// Pascal case = EveryWordIsUpper
// Snake case = you_have_these_annoying_underscores

var aString = 'Hello Everyone'
let aNumber = 2
const aBool = true
var aUndefined

// const = Can not change - immutable 
// var/let = can change = mutable

const aNewString = 'Whats up Doc?'

// console.log('line #9 aString, ML:',aString)
// console.log('line #16 const print:', aNewString)
// console.log('var aUndefined, ML:', aUndefined)

var a = 2
var b = 4
var c = a + b
console.log('var c, ML:', c)

a = 210
var c = a + b
console.log('var c, ML:', c)

const d = 2
const e = 4
const f = d + e
console.log('const f, ML:', f)

// This will throw errors
// d = 210
// f = d + e
// console.log('const f, ML:', f)

// Print all the values 1-10

// 1. create a for loop - i will start at 1 go to and include 10 increase by 1 each time
// 2. print each value of i


// for (start, stop, nextValue) { instructions }

for(var i = 1; i < 11; i++){
    console.log('1st for loop:',i)
}

// Print every other number 0-20

// 1. create a for loop - i starts at 0 goes to and include 20 increase by 2 each time
// 2. print each value of i

for(var i = 0; i <= 20; i+=2){
    console.log('2nd for loop:', i)
}


var cities = ["Birmingham", "Austin", "Seattle", "Orlando"]
// index          0,           1,       2,          3
// array cities length = 4
console.log('all cities', cities)

// Print each city on it's own line

//  1. create for loop
// 2. start at 0
//  3. end at end of array cities.length this will equal 4
// 4. increase by 1 each loop

for(var i = 0; i < cities.length; i++){
    console.log('3rd loop', cities[i]) // cities[i] will give us the value at index i vs just the index number
}

for(var i = 0; i < cities.length; i++) { // building loop through cities
    console.log('4th loop 1st conditional', cities[i]) // printing current city value in loop
    if(cities[i] == "Austin") { // start conditional if value is equal to Austin
        console.log("Welcome to Texas") // instructions print console.log
    } 
    // if (cities[i] == "Seattle"){ // running this with the if will keep the conditional going after the 1st if may have passed so if this fails else will run too
    //     console.log('Get ready for the rain')
    else if (cities[i] == "Seattle"){ // Changing the if to else if means if the if fails check this if this fails run else.  so its either if or else if or default of else
        console.log('Get ready for the rain')
    }else { // if check failed 
        console.log("You have left the great state of Texas") // instructions print console.log
    }
}

// Loop #1 - print Birmingham if - else
// Loop #2 = print Austin if - if
// Loop #3 = print Seattle if - else
// Loop #4 = print Orlando if - else

// === means match data type string for string int for int
// == means are they equal can cross data types
// booleans and case differences doesn't matter 2 or 3 if different will fail

var num = '2'

if (num == 2) {
    console.log('conditional 1: they are the same')
} else {
    console.log('not the same')
}

for(var i = 0; i < cities.length; i++) { 
    if(cities[i] == "Austin") {
        console.log('4th loop 1st conditional', cities[i],"Welcome to Texas")
    } 
    else if (cities[i] == "Seattle"){
        console.log('4th loop 1st conditional', cities[i],'Get ready for the rain')
    }else {
        console.log('4th loop 1st conditional', cities[i],"You have left the great state of Texas")
    }
}

var playing = true

while (playing) {
    console.log('hi')
    playing = false
}