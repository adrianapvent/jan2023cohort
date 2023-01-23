// 1. Print 1-255

// This would be a reusable version of the one below Mar'Kebta
function printNum(arr) {
    for(let i = 1; i < arr.length; i++) {
        console.log(arr[i])
    }
}
function print255() {
    for(let i = 1; i <= 255; i++) {
        console.log(i)
    }
}
// print255()

// 2. Print Odds 1-255 Sierra

// reusable - this won't work on negative numbers though
function odd(arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] % 2 == 1) {
            console.log(arr[i])
        }
    }
}
// you could do a  Math.abs(arr[I]%2) == 1

function odd255() {
    for(let i = 1; i <= 255; i++) {
        if(i % 2 == 1) {
            console.log(i)
        }
    }
}
// odd255()

// 3. Print ints and sum 0-255 Brianna
function is255() {
    let sum = 0
    for(let i = 0; i <= 255; i++) {
        sum = sum + i
        console.log(`Current Index Value: ${i}, Current Sum: ${sum}`)
    }
}
// is255()

// reusable
function intsSum(arr) {
    let sum = arr[0]
    for(let i = 1; i < arr.length; i++) {
        sum = sum + arr[i]
        console.log(`Current Index Value: ${arr[i]}, Current Sum: ${sum}`)
    }
    return sum
}


// 4. Iterate and Print Array Joslyn
function printArr(a) {
    for(let i = 0; i < a.length; i++) {
        console.log(a[i])
    }
}
// printArr([1,2,3,4,5,6,7,8,9])

// 5. Find and Print Max of an array Lizette
function printMax(arr) {
    let max = arr[0]
    for(let i = 1; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    console.log(max)
    return max
}
// printMax([1,2,3,4,5,6,7,8,9])

// 6. Get and Print Average Ubin
function printAvg(arr) {
    let sum = 0
    for(let i = 0; i < arr.length; i++) {
        sum += arr[i] // sum = sum + arr[i]
    }
    console.log(sum/arr.length)
    return sum/arr.length
}
// printAvg([1,2,3,4,5,6,7,8,9])

// 7. Array with odds 1-255  Emily
function arrOdds255() {
    let arr = []
    for(let i = 1; i <= 255; i++) {
        if(i % 2 == 1) {
            arr.push(i)
        }
    }
    console.log(arr)
}
// arrOdds255()

// reusable
function arrOdds(a) {
    let arr = []
    for(let i = 0; i <= a.length; i++) {
        if(a[i] % 2 == 1) {
            arr.push(a[i])
        }
    }
    console.log(arr)
}

// 8. Square the Values in arr  Aquila & Kaitlynn
function square(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] *= arr[i] // arr[i] = arr[i] * arr[i]
    }
    console.log(arr)
}
// square([1,2,3,4,5,6,7,8,9])

// you could also use Math.pow()
// arr[i] = Math.pow(arr[i], 2);
//I think that would work

// 9. Greater than Y   Liannys
function greaterThanY(arr, y) {
    var count = 0
    for(let i = 0; i < arr.length; i++) {
        if (arr[i] > y) {
            count++
        }
    }
    console.log(count)
}
// greaterThanY([1,2,3,4,5,6,7,8,9], 4)

// 10. Zero out negative numbers arr change any neg numbers to 0 print arr Muriel
function zeroNum(a) {
    for(let i = 0; i < a.length; i++) {
        if(a[i] < 0) {
            a[i] = 0
        }
    }
    console.log(a)
}
// zeroNum([1,5,-99,-2,0,3,-4,5,8,9])


// 11. Max, Min, Avg   Dana
function maxMinAvg(arr) {
    let max = printMax(arr)
    let avg = printAvg(arr)
    let min = arr[0]
    for(let i = 0; i < arr.length; i++) {
        if(arr[i]< min) {
            min = arr[i]
        }
    }
    let result = {max: max, min: min, avg: avg}
    console.log(`Max: ${max}, Min: ${min}, Avg: ${avg}`)
    return result
}

// maxMinAvg([1,5,-99,-2,0,3,-4,5,8,9])

// 12. Shift Array Values - move to left by 1 index loosing index 0 adding 0 to last  Ashunti & Jackie
function shiftArr(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] = arr[i+1]
    }
    // arr[arr.length-1] = 0 // This is good
    // arr.push(0) // This would just add 0 after undefined
    arr.splice(arr.length-1, 1, 0) // This works

    console.log('after loop:', arr)
}
// shiftArr([1,2,3,4,5,6,7,8,9])
// result should [2,3,4,5,6,7,8,9,0]

let arr = [1,2,3,4,5,6,7,8,9]
for(let i = 0; i < arr.length; i++) {
    if(i = arr.length -1) {
        arr[i] = 0
    } else {
        arr[i] = arr[i+1]
    }
}
// console.log(arr)

function shiftArray(arr) {
  for (var i = 1; i < arr.length; i++) {
    arr[i-1] = arr[i]
    }
    arr[arr.length-1] = 0; 
    console.log(arr)
    return arr;
}
// shiftArray([1,2,3])

function shiftArray(arr){
    arr.shift()
    arr.push(0)
    return arr
}
// console.log(shiftArray([1,2,3]))


// 13. Swap string for array Negative numbers ('Dojo')  Adriana
function swapDojo(arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < 0) {
            arr[i] = 'Dojo'
        }
    }
    console.log(arr)
}

swapDojo([1,5,-99,-2,0,3,-4,5,8,9])