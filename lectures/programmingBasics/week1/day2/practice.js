// Like we do in class break this down line by line then predict the outcome, and then run it to see if you were right

/*
let arr01 = ["This is just a test", 2, 5, 7, "Just for practice"]
let arr02 = []
for(let i = 0; i < arr01.length; i++) {
    if(arr01[i] > 0) {
        arr02.push(arr01[i])
    } else {
        console.log("I seem to have failed the if check")
    }
}
console.log('updated arr01:', arr01)
console.log('updated arr02:', arr02)
*/

// Return Odds Array 1-255 Create an array with all the odd integers between 1 and 255 (inclusive).

// for loop - start@ 1 stop@ <=255 move through loop - i++
// conditional - i % 2 == 1 => if true empty array .push i
// empty array

let arr03 = []
for(let i = 0; i <= 255; i++) {
    if(i % 2 == 1) {
        arr03.push(i)
    }
}
// console.log(arr03)



// Given the following array print each value
var arr04 = ["Arrays and loops", "can be fun", "but they can also", "be hard"]

// for loop - i=0 i < arr04.length i++
// print arr04[i] in the loop

for(let i = 0; i < arr04.length; i++) {
    // console.log(arr04[i])
}

// Add the actual following array to the above array at the end
var arr05 = [2,4,6,24,8,10]

// Add the numbers from arr05 to the arr04

for(let i = 0; i < arr05.length; i++) {
    arr04.push(arr05[i])
}

// push arr05 to arr04

arr04.push(arr05)
// console.log(arr04)

// Print all of the value contained in the entire updated arr04 (hint you will need a conditional statement)

// for loop start @ 0 end @ .length i++
// if to check if curr index is an array
// if array new for loop to console each value
// if  not array console each value

for(let i = 0; i < arr04.length; i++) {
    if(Array.isArray(arr04[i])) {
        // console.log('you found the array')
        // console.log(arr04[i][0])
        // console.log(arr04[i].length)
        let arr06 = arr04[i]
        for(let x = 0; x < arr06.length; x++) {
            // console.log(arr06[x])
        }
    } else {
        // console.log(arr04[i])
    }
}


// Print the number 24 from the root of arr04 and then from the arr inside arr04

for(let i = 0; i < arr04.length; i++) {
    if(arr04[i] === 24) {
        console.log(arr04[i])
    }
}

for(let i = 0; i < arr04.length; i++) {
    if(Array.isArray(arr04[i])) {
        let arr06 = arr04[i]
        for(let x = 0; x < arr06.length; x++) {
            if(arr06[x] === 24) {
                console.log(arr06[x])
            }
        }
    }
}