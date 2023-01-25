// Group Work

// Create a function that takes and array and puts all even numbers into a new array and all negative numbers into another array , replacing those numbers with "pop". Print all 3 arrays
let arr01 = [2,5,7,8,-9,10,-99,50, 3, -88,0, -23, 24, 10]
function evenNeg (arr) {
    let evenArr = []
    let negArr = []
    for(let i = 0; i < arr.length; i++){
        if(arr[i] % 2 == 0)
        {evenArr.push(arr[i])}
        if(arr[i] < 0)
        {negArr.push(arr[i])
        arr[i] = 'pop';
    }
    
    }
    console.log('even numbers:', evenArr)
    console.log('negative number:', negArr)
    console.log('pop');

} 

// evenNeg(arr01)



// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined
let arr02 = [[90,80,85,90], [50,70,80,90], [100,90,95,87],[40,80,70,76]]

function printMax(arr02) {
    let max = arr02[0]
    for(let i = 0; i < arr02.length; i++) {
        if(arr[i] > max) {
            max = arr[i]
        }
    }
    console.log(max)
    return max
}

printMax(arr02)


// Create a function that takes an array of Objects and prints back the names of each pet and their age
let arr03 = [{name: 'Bear', type: 'dog', stats: [{age: 7, color: ['brown', 'black']}]}, {name: 'Copper', type: 'dog', stats: [{age: 2, color: ['White', 'brown', 'black']}]}, {name: 'Lily', type: 'Betta Fish', stats: [{age: 1, color: ['blue', 'off White']}]}]