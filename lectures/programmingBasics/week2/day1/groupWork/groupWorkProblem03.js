// Create a function that takes an array of Objects and prints back the names of each pet and their age
let arr03 = [{name: 'Bear', 
            type: 'dog', 
            stats: [{age: 7, 
                    color: ['brown', 
                            'black']}]}, 

            {name: 'Copper', 
            type: 'dog', 
            stats: [{age: 2, 
                    color: ['White', 
                            'brown', 
                            'black']}]},

            {name: 'Lily', 
            type: 'Betta Fish', 
            stats: [{age: 1, 
                    color: ['blue', 
                            'off White']}]}
            ]

console.log('\n========= Problem 3 Version 1 =========')
function printPetNames(arr){
    for(let i=0; i<arr.length; i++){
        console.log(`Name: ${arr[i].name},\tAge: ${arr[i].stats[0].age}`)
    }
}
printPetNames(arr03)


console.log('\n========= Problem 3 Version 2 =========')

function petNameAge(arr){
    for(let i = 0; i < arr.length; i++){
        console.log(arr[i].name) 
        console.log(arr[i].stats[0].age)
    }
}

console.log('\n========= Problem 3 Version 3 =========')

function nameAgePets(arr) {
    for(let i = 0; i < arr.length; i++) {
        let name = arr[i].name
        let age = arr[i].stats[0].age
        let pet = i+1
        console.log(`Pet #${pet}: ${name} is ${age} years old`)
    }
}
nameAgePets(arr03)