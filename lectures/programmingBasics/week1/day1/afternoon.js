// for(start; stop; nextValue){
    // instructions go here
// }

for(var i = 0; i < 20; i++) {
    // console.log('printing i', i)
}

// Line 5: Start a loop at 0 number stays less than 20 increases each time
// Line 6: start instructions - print the value of i to the terminal
// Line 7: End loop or end instructions of loop


// print all the even number 1-20

// for (var i = 1; i <=20; i++) {
//     if(i % 2 == 0) {
//         console.log('even num', i)
//     }
// }

//  1-100
// For each number that is a multiple of 3, print "Fizz"
// For each number that is a multiple of 5, print "Buzz"
// For numbers which are a multiple of both 3 and 5, print "FizzBuzz"
// All other numbers should just print normally

// for(var i = 1; i <=100; i++) {
//     if (i % 3 == 0 && i % 5 ==0) {
//         console.log("FizzBuzz")
//     }
//     else if(i % 3 == 0) {
//         console.log("Fizz")
//     }
//     else if (i % 5 == 0){
//         console.log("Buzz")
//     } else {
//         console.log(i)
//     }
// }


//  numbers 1-5 print current values and sum

// 1. for loop start at 1 end <=5 increase by 1
//  print current val of i
//  sum i

var sum  = 0
for(var i = 1; i <= 5; i++ ) {
    sum = sum + i
    // console.log('current value of i is:', i, 'current sum is:', sum)
}

var newSum  = 0
for(var i = 1; i <=20; i+=2) {
    newSum = newSum + i
    console.log('current value of i is:', i, 'current sum is:', newSum)
}

// newSum starts at 0
//  enter loop i - 1
// enter instructions 1 = 0 + 1
// print increase i by 2
// i = 3, 4=1+3