// Basic Foundation I
// Please work on the following challenges and upload your work in a single file.

// 1. Get 1 to 255 - Write a function that returns an array with all the numbers from 1 to 255.
function print255() {
    for(let i = 1; i <= 255; i++){
    console.log(i)
    }
}
// print255()


// 2. Get even 1000 - Write a function that would get the sum of all the even numbers from 1 to 1000.  You may use a modulus operator for this exercise.
function even() {
    for(let i = 0; i <= 1000 ; i++) {
        if(i % 2 == 0) {
            console.log(i)
        }
    }
}
// even()

// 3. Sum odd 5000 - Write a function that returns the sum of all the odd numbers from 1 to 5000. (e.g. 1+3+5+...+4997+4999).

function sumOdd() {
    let sum = 0
    for(let i = 0; i <= 5000; i++) {
    sum = sum + i
    console.log(`Current index value: ${i}, Current Sum: ${sum}`)
    } 
}

// sumOdd()
 


// 4. Iterate an array - Write a function that returns the sum of all the values within an array. (e.g. [1,2,5] returns 8. [-5,2,5,12] returns 14).

function sumArr(arr) {
    let sum = 0
    for(let i = 0; i < arr.length; i ++) {
    sum += arr[i];
    } 
    // return sum
    // console.log(sum)
}
// sumArr([1,2,5]);

// 5. Find max - Given an array with multiple values, write a function that returns the maximum number in the array. (e.g. for [-3,3,5,7] max is 7)
function printMax(arr) {
    let max = arr[0]
    for(let i = 0; i < arr.length; i ++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    console.log(max)
}

// printMax([-3,3,5,7])

// 6. Find average - Given an array with multiple values, write a function that returns the average of the values in the array. (e.g. for [1,3,5,7,20] average is 7.2)

function printAvg(arr) {
    let sum = 0 
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i]
    }
    // console.log(sum/arr.length)
    // return sum/arr.length
}

printAvg([1,3,5,7,20])

// 7. Array odd - Write a function that would return an array of all the odd numbers between 1 to 50. (ex. [1,3,5, .... , 47,49]). Hint: Use 'push' method.
function arrOdds49() {
    let arr = []
    for(let i =0; i <= 49; i++) {
        if(i % 2 == 1) {
            arr.push(i)
        }
    }
    // console.log(arr)
}

// arrOdds49()


// 8. Greater than Y - Given value of Y, write a function that takes an array and returns the number of values that are greater than Y. For example if arr = [1, 3, 5, 7] and Y = 3, your function will return 2. (There are two values in the array greater than 3, which are 5, 7).

function greaterThanY(arr, y) {
    var count = 0
    for(let i = 0; i < arr.length; i++) {
        if (arr[i] > y) {
            count++
        }
    }
    // console.log(count)
}

// greaterThanY([1,3,5,7], 3)


// 9. Squares - Given an array with multiple values, write a function that replaces each value in the array with the value squared by itself. (e.g. [1,5,10,-2] will become [1,25,100,4])

function square(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] *= arr[i] // multiplies a value by itself i.e. 3 * 3, 5 * 5
    }
    // console.log(arr)
}

// square([1,5,10,-2])

// 10. Negatives - Given an array with multiple values, write a function that replaces any negative numbers within the array with the value of 0. When the program is done the array should contain no negative values. (e.g. [1,5,10,-2] will become [1,5,10,0])

function zeroNeg(a) {
    for(let i = 0; i < a.length; i++) { // begin at index 0, run through the give array, increment by 1 index # each time
        if(a[i] < 0) { // if the index # is less than Zero then...
            a[i] = 0 // change the index # to 0
        }
    }
    // console.log(a)
}

// zeroNeg([1,5,10,-2])


// 11. Max/Min/Avg - Given an array with multiple values, write a function that returns a new array that only contains the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])

function maxMinAvg(arr) {
    let max = arr[0]
    let sum = 0 
    let min = 0

    for(let i = 0; i < arr.length; i ++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    // console.log(max)

    for(let i = 0; i < arr.length; i++) {
        sum += arr[i] / arr.length;
    }
    // console.log(sum/arr.length)
    // return sum/arr.length

    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < min) {
            min = arr[i]
        }
        // console.log(min)
    }
    let result = {max: max, min: min, avg: sum}
    console.log(`Max: ${max}, Min ${min}, Avg: ${sum}`)
    return result
}

// maxMinAvg([1,5,10,-2])


// 12. Swap Values - Write a function that will swap the first and last values of any given array. The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).

function swap(arr) {
    let arrNew = arr.slice(); // we want a new array
    let temp = arrNew[0]; // temporary value holds value at index 0
    arrNew[0] = arrNew[arrNew.length - 1]; // new index 0 - replace value at index 0 with last value in the array
    arrNew[arrNew.length - 1] = temp; // use temporary value that was holding index 0 value for the last position in the array
    // console.log (arrNew) // console the new array with first and last values swapped.
    return arrNew
}

// swap([1,5,10,-2])


// 13. Number to String - Write a function that takes an array of numbers and replaces any negative values within the array with the string 'Dojo'. For example if array = [-1,-3,2], your function will return ['Dojo','Dojo',2].

function swapDojo (arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < 0) { // if index value is less than 0
        arr[i] = 'Dojo' // then replace it with Dojo
        }
    }
    console.log(arr) // console new array
}

// swapDojo ([-1,-2,3])

// console.log( 8 % 3 );

// console.log( 8 % 3 == 2 );

// for(var i=8; i > -2; i-=3) {
//     console.log(i);
// }

var x = 0;
for(var i=1; i<5; i++) {
    x += i;
}
console.log(x);

// var x = "0";
// for(var i=1; i<5; i++) {
//      x += i;
//  }
//  console.log(x);
