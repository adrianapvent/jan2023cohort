// Question 1
// Predict the result of the following code.

var answer = 3 + 4 * 2;
// console.log(answer);

/*
 * Your answer: ______11___________
 */

// Question 2
// Predict the result of the following code.

for(var i=0; i<13; i++) {
    // console.log(i);
    i += 2;
}

/*
 * Your answer: ___0, 3, 6, 9, 12_________
 */

// Question 3
// Predict the result of the following code.

var i = 3;
while(i < 8) {
    if(i % 2 == 0) {
        // console.log("even");
    } else {
        // console.log(i);
    }
    i++;
}

/*
 * Your answer: ___3, even, 5, even , 7______________
 */


// Question 4
// Complete the function in the code below to console log all numbers down from 68 to 9

function print68to9() {
    for(let i = 68; i >= 9; i--) {
        console.log(i)
    }
}
// print68to9();

// Question 5
// Complete the function in the code below to console log all odd numbers from 1 to 149

function printOdds1to149() {
    for(let i = 1; i <= 149; i++) {
        if(i % 2 != 0) {
            console.log(i)
        }
    }
}
// printOdds1to149();

// Question 6
// Complete the function in the code below to **return** the sum of an array
// Given: [3, 6, 4, 9, 2]
// Return: 24

function findSum(arr) {
    var sum = 0;
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i]
    }
    return sum;
}
// findSum([12, 21, 3.6, 9, 12, 8]);
// console.log(findSum([3, 6, 4, 9, 2]))

// Question 7
// Complete the function in the code below to **return** the largest value in an array
// Given: [3, 6, 4, 9, 2]
// Return: 9

function findLargest(arr) {
    let max = Math.max(...arr)
    console.log(max)
    return max
}
// findLargest([12, 21, 3.6, 9, 12, 8]);

function altFindLargest(arr) {
    let max = arr[0]
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    console.log(max)
    return max
}
// altFindLargest([12, 21, 3.6, 9, 12, 8])

// Question 8
// Complete the function in the code below to **return** an array of all even numbers from 1 to 166

function evensArray() {
    var result = [];
    for (let i = 1; i <= 166; i++) {
        if (i % 2 == 0) {
            result.push(i)
            
        }
    }
    console.log(result)
    return result;
}
// evensArray();

function altEvensArray() {
    var result = []
    for(let i = 2; i <=166; i+=2) {
        result.push(i)
    }
    console.log(result)
    return result
}
// altEvensArray()

// Question 9
// Complete the function in the code below to return a count of all values in the array larger than another number "y"
// Given: [3, 6, 4, 9, 2], 5
// Return: 2

function countGreaterThanY(arr, y) {
    var count = 0;
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > y) {
            count++ // just like in our loop i++ and count++ increase by 1 (count += 1 is also good)
        }
        console.log(`curr val i: ${arr[i]}, curr val count: ${count}`)
    }
    return count;
}
// countGreaterThanY([12, 21, 3.6, 9, 12, 8], 8);

// Question 10
// Complete the function in the code below to swap pairs of values in an array and return it
// Given: [1, 2, 3, 4, 5, 6, 7] 
// Return [2, 1, 4, 3, 6, 5, 7] 

function swapPairs(arr) {
    let temp = 0
    for(let i = 0; i < arr.length; i+=2) {
        temp = arr[i]
        console.log(`PRE SWAP: curr val i: ${arr[i]}, next val i: ${arr[i+1]}`)
        arr[i] = arr[i+1]
        arr[i+1] = temp
        console.log(`AFTER SWAP: curr val i: ${arr[i]}, next val i: ${arr[i+1]}`)
    }
    console.log(arr)
    return arr;
}
swapPairs([12, 21, 3.6, 9, 12, 8]);
// [21, 12, 9, 3.6, 8, 12]

// make a temp var to store i
// take i+1 = i temp = i+1

// a way without a temp variable, using XOR only int (whole numbers)
function altSwapPairs(arr){
    for(let i=1; i<arr.length; i+=2){
        arr[i] ^= arr[i-1]
        arr[i-1] ^= arr[i]
        arr[i] ^= arr[i-1]            
    }
    console.log(arr)
    return arr
}
// altSwapPairs([12, 21, 3.6, 9, 12, 8])