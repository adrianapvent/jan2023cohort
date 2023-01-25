// Create a function that takes an array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays

let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]

console.log('\n========= Problem 1 Version 1 =========')
function seperateArray(arr){
    let evenArr = []
    let negArr = []
    let bool = false

    /* Creating 3 vars.  1st an empty array for the even numbers, 2nd an empty array for the negative numbers and 3rd a variable set to false */

    for(let i=0; i<arr.length; i++){
        if(arr[i]%2 == 0){
            evenArr.push(arr[i])
            bool = true
        }
        /* Inside the loop if the value of i is divisible by 2 with no remainder (even) push that number to the even array and set bool to true */

        if(arr[i] < 0){
            negArr.push(arr[i])
            bool = true
        }  
        /* Inside the same loop still if the value of I is less than 0 (negative) push that number to the negative array and set bool to treu */

        if(bool){
            arr[i] = 'pop'
            bool = false
        }
        /* If bool was set to true by any of the above if statements change the value of i in original array to 'pop */
    }
    console.log(`Array: ${arr}\nEvens: ${evenArr}\nNegative: ${negArr}`)
    /* Outside the loop print the 3 arrays */
}
seperateArray(arr01)

console.log('\n========= Problem 1 Version 2 =========')

function threeArrs(arr) {
    let even = []
    let negative = []

    /* Creating 2 empty arrays */
    
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] % 2 === 0) {
            even.push(arr[i])

            /* Inside teh loop if the value of i divided by 2 has no remainder push that number to even array */

            if (arr[i] < 0) {
                negative.push(arr[i])
            }

            /* Inside the loop if the value of i is less than 0 push that number to the negative array */
        } else if (arr[i] < 0) {
            negative.push(arr[i])
            arr[i] = "pop"
            
            /* If the value of i is less than 0 push the number to the negative array and change the original value to 'pop */
        }
    }
    console.log(arr)
    console.log(even)
    console.log(negative)

    /* Print the 3 arrays */
}

threeArrs(arr01)


console.log('\n========= Problem 1 Version 3 =========')

function evenNegPop(arr){
    var even = []
    var negative = []
    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 == 0 || arr[i] < 0){
            if(arr[i] % 2 == 0){
                even.push(arr[i])
            }
            if(arr[i] < 0){
                negative.push(arr[i])
            } 
            arr[i] = 'pop'
        }
        
    }
    console.log(`original array: ${arr} even array: ${even} negative array: ${negative}`)
}
evenNegPop(arr01)

console.log('\n========= Problem 1 Version 4 =========')

function evenNeg(arr) {
    let negArr = []
    let evenArr = []
    for(let i = 0; i < arr.length; i++) {
        if(arr[i] < 0 && arr[i] % 2 == 0) {
            negArr.push(arr[i])
            evenArr.push(arr[i])
            arr[i] = 'pop'
        }
        else if(arr[i] < 0) {
            negArr.push(arr[i])
            arr[i] = 'pop'
        }
        else if(arr[i] % 2 == 0) {
            evenArr.push(arr[i])
            arr[i] = 'pop'
        }
    }
    console.log(`Negative Array: ${negArr}, Even Array: ${evenArr}, Original Array: ${arr}`)
}
// evenNeg(arr01)