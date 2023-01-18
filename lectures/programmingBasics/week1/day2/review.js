// print odd numbers 1-255

for(let i = 1; i <=255; i+=2) {
    // console.log('odd numbers:', i)
}
for(let i =1; i <=255; i++){
    if(i % 2 != 0) {
        // console.log('odd numbers:', i)
    }
}

var hello = "Good Morning Jarell"

// Using the numbers 0-200 print the values and sum if the number is even add that to the sum if it is odd subtract 1 from the sum

let sum = 0 // Global variable usable by any other function, loop, or condition

for(let i = 0; i <= 200; i++) { 
    if(i % 2 == 0) {
        sum = sum + i // loop #3 i = 2 going in sum = -1 x = -1 + 2
    } else {
        sum = sum - 1
    }
    console.log('current value of i:', i, 'current sum:', sum)
}

// Line #16: start for loop, start at 0 end < 200 increase by 1
// Line #17: if i / 2 has no remainder
// Line #18: sum will now be equal to the current value of sum plus the value of i
// Line #19: If the if statement fails start these instructions
// Line #20: sum will be now equal to the current value of sum minus 1
// Line #22: Print the value of i and the current value of sum to terminal



// Sum and Print 1-5
// Sum numbers from 1 to 5, printing out the current number and sum so far at each step of the way
// The expected output will be: Num: 1, Sum: 1, Num: 2, Sum: 3, Num: 3, Sum: 6, Num: 4, Sum: 10, Num: 5, Sum: 15


// line 1: create var sum set it to 0 giving it a starting point
// line 2: create for loop i = 1; i <= 5; i++
// line 3: newSum will now equal current newSum plus i
// line 4: printing the results


let newSum = 0
for(let i = 0; i <= 5; i++) {
    newSum = newSum + i
    console.log("Num:", i, "Sum:", newSum)
}