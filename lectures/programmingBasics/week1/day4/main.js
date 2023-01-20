// Functions

/*
function giveMeAName(giveMeInput) { // giving our job a name and something to call it's needed input
    giveMeInstructions = use(giveMeInput) // providing the job instructions using input if provided/needed
}
giveMeAName(ActivateMe) // Calling // activating // invoking the job
*/

let meals = [
    {'meal': 'spaghetti', 'ingredients': {'grains': ['pasta'], 'fruits': ['olives'], 'vegetables': ['tomato sauce'], 'proteins': ['meataballs'], 'dairy': ['cheese']}},
    {'meal': 'french toast', 'ingredients': {'grains': ['bread'], 'fruits': [], 'vegetables': [], 'proteins': ['eggs'], 'dairy': ['milk']}},
    {'meal': 'salad', 'ingredients': {'grains': ['croutons', 'corn'], 'fruits': [], 'vegetables': ['lettuce', 'carrots', 'cucumber', 'peppers', 'onions'], 'proteins': ['ham', 'bacon'], 'dairy': ['cheese', 'blue cheese dressing']}}
]



var hello = "Good Morning Jarell"
var crazy = "I am in a weird crazy mood today, cause I got sleep"

function sayHi(a) {
    console.log(a)
}
// sayHi(hello)
// sayHi(crazy)
// sayHi()

// if 2 parameters are in function 2 should be provided no more no less
// however some functions like above will still run with no parameter due to the contents of hte function.

// a = is a parameter or input that is needed for the function to finished it's job.  Makes the function reusable as the input can be anything you tell it

function printOdds10() {
    for(let i = 1; i <=10; i+=2) {
        console.log('odd numbers:', i)
    }
}
// This function needs no outside help or input to run so no parameters are needed it just needs to be called

// printOdds10()

let theMeal = meals[1].ingredients.grains

function printMealNames(arr) {
    for(let i = 0; i < arr.length; i++) {
        console.log(arr[i])
    }
}
// printMealNames(meals)
// printMealNames(theMeal)

function add(num1, num2) {
    let sum = num1 + num2
    // return sum // This return statement will not allow the console.log to run so make sure you have the return statement last
    console.log(sum)
    return sum
}
// add(4, 6)

// Print Max, Min, Average Array Values
// Given an array, print the max, min and average values for that array.
var grades = [90,80, 60, 30, 90,99,100,50,80,85]


function minMaxAvg(arr) {
    var min = 0
    var max = 0
    var avg = 0
    var sum = 0
    for(let i = 0; i < arr.length; i++) { // looping through array
        sum = sum + arr[i] // adding grades together
        if(max < arr[i]) { // checking if curr val of max is smaller than curr val i
            max = arr[i] // if max is small change to larger val i
        }
        if(i === 0) { // if index 0 (first loop)
            min = arr[i] // set min to curr val i
        }
        else if (min > arr[i]) { // check if curr min is greater than curr val i 
            min = arr[i] // if it is change  min to smaller val i
        }
    }
    avg = sum / arr.length
    console.log(`The lowest grade was ${min}.  The highest grade was ${max}. Melissa's final grade was ${avg}`)
}

/* Other option for starting min max and sum
min = arr[0]
max = arr[0]
sum = arr[0]

We can do this because the first loop will automatically be that number anyways so then we can start our loop with let i = 1;
*/


// minMaxAvg(grades)
// avg = sum/length
// in loop = sum = sum + arr[i]
// outside loop = sum/arr.length

// max = is arr[i] > max if yes max =  arr[i]

// min = if i = 0 min = arr[i] else if arr[i] < min min = arr[i]

// Refactoring
function betterMMA(arr) {
    let max = Math.max(...arr) // the 3 dots are a spread operator (The spread operator is a new addition to the set of operators in JavaScript ES6. It takes in an iterable (e.g an array) and expands it into individual elements. The spread operator is commonly used to make deep copies of JS objects)
    let min = Math.min(...arr)
    // console.log(max, min)
    let sum = 0
    for(let i = 0; i < arr.length; i++) {
        sum = sum + arr[i]
    }
    let avg = sum / arr.length
    console.log(max, min, avg)
}
// betterMMA(grades)

function add(random1, num2){
    console.log("Summing Numbers!");
    console.log("num1 is: " + random1);
    console.log("num2 is: " + num2);
    var sum = random1 + num2;
    console.log("This is where things get added", sum);
}
add(7,22);

function testing(a, b, c) {
    let x = a / c
    console.log(b,x) // b = the prase x = math problem answer

}

testing(2, 'The answer is:', 4)

let x = 10
let y = 20
let a = 0
let results = []
console.log('a',a)

// Create a function that adds, subtracts, multiplies and divides 2 numbers prints the results and pushes the results of each into the results array and prints that array and each answer
function asmd(num1, num2) {
    theAdd = num1 + num2
    results.push(theAdd)
    theSub = num1 - num2
    results.push(theSub)
    theMult = num1 * num2
    results.push(theMult)
    theDiv = num1 / num2
    results.push(theDiv)
    console.log(theAdd, theSub, theMult, theDiv, results)
    a = results
    // return a
}
asmd(x, y)
console.log('a',a)