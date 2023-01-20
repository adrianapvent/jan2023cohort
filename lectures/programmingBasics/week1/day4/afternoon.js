var arr01 = [ -24, 8, 6, -100, 500, 0, -1, 3, 6,-6, 9]
var arr02 = [2,5,7,3,4,6,9]
var arr03 = [2,6,8,4]
var arr04 = [{name: "Bumbble Bee"},{name: "Delta"},{name: "Arty"},{name: "Bones"},{name: "Lily"}]



// Create a function that checks the length of an array and if it is less than 5 prints "array too small", if it is larger than 10 prints "array to large", and if it is neither prints "array just right"
function goldilocks(arr) {
    if(arr.length < 5) {
        console.log("Array too small")
    }
    else if(arr.length > 10) {
        console.log("Array too large")
    }
    else {
        console.log("Array just right")
    }
}
// goldilocks(arr04)
// goldilocks(arr03)
// goldilocks(arr02)
// goldilocks(arr01)
// console.log(arr01.length)

// Create a function that finds the largest number in an array and prints the result
function larNum(arr) {
    let max = arr[0]
    for(let i = 1; i < arr.length; i++) {
        console.log('before if',arr[i])
        if(arr[i] > max) {
            max = arr[i]
            console.log('in if', max)
        }
    }
    console.log('results',max)
    return max
}
// larNum(arr04)

// Create a function that finds the smallest number in an array and prints the result
function smNum(arr) {
    let min = arr[0]
    for(let i = 1; i < arr.length; i++) {
        console.log('before if',arr[i])
        if(arr[i] < min ) {
            min = arr[i]
            console.log('in if', min)
        }
    }
    console.log('results',min)
    return min
}
// smNum(arr01)

// Create a function that finds the sum of an array and prints the result
function sumNum(arr) {
    let sum = arr[0]
    for(let i = 1; i < arr.length; i++) {
        console.log('current sum:', sum, 'current i:', arr[i])
        sum += arr[i]
    }
    console.log('results', sum) // this give us a peak only and only via the console/terminal
    return sum // this gives us the answer in a usable format like for a function
}
// sumNum(arr01)

// Create a function that finds the average of an array and prints the result
function avgNum(arr) {
    let sum = sumNum(arr)
    console.log('the sum is:', sum)
    let avg = sum / arr.length
    console.log('the average is:', avg)
    return avg
}
// avgNum(arr01)

// Create a function that finds the min, max, sum, and average of an array and puts those results into a new array and prints the array
function mmsaNum(arr) {
    let results = []
    let max = larNum(arr)
    let min = smNum(arr)
    let sum = sumNum(arr)
    let avg = avgNum(arr)
    results.push(max)
    results.push(min)
    results.push(sum)
    results.push(avg)
    console.log('the results array:', results)
}

// mmsaNum(arr02)

let results = []
let a = 0
function newArr(arr) {
    a = larNum(arr)
    results.push(a)
    a = smNum(arr)
    results.push(a)
    a = sumNum(arr)
    results.push(a)
    a = avgNum(arr)
    results.push(a)
    console.log('the results array:', results)
}
// newArr(arr02)

function betterNum(arr){
    results.push(larNum(arr))
    results.push(smNum(arr))
    results.push(sumNum(arr))
    results.push(avgNum(arr))
    console.log('the results array:', results)
}
betterNum(arr03)

// Create a function that finds the min, max, sum, and average of an array and puts those results into a new array.  Takes any negative numbers and puts them in a new array, Then the positive odd numbers into an array and the positive even numbers into another array.  Print each array