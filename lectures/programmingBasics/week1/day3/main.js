// Objects
/*
let obj01 = {'color': 'red'}
console.log(obj01)
console.log(obj01['color'])
console.log(obj01.color)
*/

let meals = [
    {'meal': 'spaghetti', 'ingredients': {'grains': ['pasta'], 'fruits': ['olives'], 'vegetables': ['tomato sauce'], 'proteins': ['meataballs'], 'dairy': ['cheese']}},
    {'meal': 'french toast', 'ingredients': {'grains': ['bread'], 'fruits': [], 'vegetables': [], 'proteins': ['eggs'], 'dairy': ['milk']}},
    {'meal': 'salad', 'ingredients': {'grains': ['croutons', 'corn'], 'fruits': [], 'vegetables': ['lettuce', 'carrots', 'cucumber', 'peppers', 'onions'], 'proteins': ['ham', 'bacon'], 'dairy': ['cheese', 'blue cheese dressing']}}
]
/*
// #1 print array meals
console.log(meals)

// #2 print the french toast object
console.log(meals[1])

// #2 print the word french toast
console.log(meals[1].meal)
console.log(meals[1]['meal'])

//  #2a print ingredients
console.log(meals[1].ingredients)

// #3a print grains
console.log(meals[1].ingredients.grains)

// #4a print bread
console.log(meals[1].ingredients.grains[0])
*/
// Print all the meal names

// for loop - start end increments
for(let i = 0; i < meals.length; i++) {
    let m = meals[i]
    // console.log(m.meal)
}

// print all the grains for all meals
for(let i = 0; i < meals.length; i++) {
    let m = meals[i].ingredients
    // console.log(m.grains)
    // if(m.grains.length > 1){
        for(let g = 0; g < m.grains.length; g++){
            let newM = m.grains[g]
            // console.log(newM)
        }
    // } else {
    //     console.log(m.grains[0])
    // }
}
// dairy
for(let i = 0; i < meals.length; i++) {
    let m = meals[i].ingredients
    // console.log(m.grains)
    if(m.dairy.length > 1){
        for(let g = 0; g < m.dairy.length; g++){
            let newM = m.dairy[g]
            console.log(newM)
        }
    } else {
        console.log(m.dairy[0])
    }
}

//  line 1 - for loop going through the meal array
// line 2 - creating a var m setting it to be the objects that are the values of ingredients
// line 3 - loop through the grains array
// line 4 - creating var for the individual index
// line 5 - printing


// print all the fruits for all meals

// let arr = []
// for(let i = 0; i < meals.length; i++) {
//     let m = meals[i].ingredients
//     console.log(m)
//     arr.push(m)
//     console.log(arr)
//     // for(let x = 0; x < arr.length; x++) {
//     //     console.log(arr[x])

//     // }
// }

// for(let i = 0; i < meals.length; i++) { // opening and pulling out each individual box containing 1 meal 
//     let m = meals[i].ingredients // m is opening the meal box and pulling out each ingredient box
//         for(let g = 0; g < m.grains.length; g++){ // going through each box that says grains
//             console.log(m.grains) // looking at the label on the box of grains
//             let newM = m.grains[g] // opening each box of grains and pulling out contents
//             // console.log(newM) // listing the contents
//         }
// }
// for(let i = 0; i < meals.length; i++) {
//     let m = meals[i].ingredients
//         for(let g = 0; g < m.fruits.length; g++){
//             console.log(m.fruits)
//             let newM = m.fruits[g]
//             console.log(newM)
//         }
// }


var someToons02 = ["http://images.thehive-services.com/looneyToonsApi/porky.jpg", "http://images.thehive-services.com/looneyToonsApi/marvin.jpg", "http://images.thehive-services.com/looneyToonsApi/tweety.png", "http://images.thehive-services.com/looneyToonsApi/foghorn.jpg", "http://images.thehive-services.com/looneyToonsApi/elmer.jpg", "http://images.thehive-services.com/looneyToonsApi/sylvester.jpg", "http://images.thehive-services.com/looneyToonsApi/yosemite.jpeg", "http://images.thehive-services.com/looneyToonsApi/taz.jpg", "http://images.thehive-services.com/looneyToonsApi/pepe.jpg"]
// someToons02 = Array of strings


var toons = [
    {"id":5,"name":"Porky Pig","birthDay":"March 2, 1935","spouse":"Petunia Pig","voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/porky.jpg"},
    {"id":9,"name":"Marvin the Martian","birthDay":"July 24, 1948","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/marvin.jpg"},
    {"id":3,"name":"Tweey","birthDay":"November 22, 1941","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/tweety.png"},
    {"id":4,"name":"Foghorn Leghorn","birthDay":"August 31, 1946","spouse":"Miss Prissy","voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/foghorn.jpg"},
    {"id":6,"name":"Elmer Fudd","birthDay":"1940","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/elmer.jpg"},
    {"id":7,"name":"Sylvester","birthDay":"March 24, 1945","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/sylvester.jpg"},
    {"id":8,"name":"Yosemite Sam","birthDay":"May 5, 1945","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/yosemite.jpeg"},
    {"id":10,"name":"Tasmanian Devil","birthDay":"1954","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/taz.jpg"},
    {"id":11,"name":"Pepe Le Pew","birthDay":"1945","spouse":"Penelope Pussycat","voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/pepe.jpg"},
    {"id":12,"name":"Speedy Gonzales","birthDay":"1953","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/speedy.jpg"},
    {"id":13,"name":"Granny","birthDay":"November 6, 1937","spouse":null,"voice":"Bea Benaderet","img":"http://images.thehive-services.com/looneyToonsApi/granny.png"},
    {"id":14,"name":"Witch Hazel","birthDay":"1954","spouse":null,"voice":"Bea Benaderet","img":"http://images.thehive-services.com/looneyToonsApi/witchHazel.jpg"},
    {"id":15,"name":"Henery Hawk","birthDay":"1942","spouse":null,"voice":"Ben Falcone","img":"http://images.thehive-services.com/looneyToonsApi/heneryHawk.jpg"},
    {"id":1,"name":"Bugs Bunny","birthDay":"April 30, 1938","spouse":"Lola Bunny","voice":"Mel Blanc","img":"https://images.thehive-services.com/looneyToonsApi/bugs.jpeg"},
    {"id":2,"name":"Daffy Duck","birthDay":"April 17, 1937","spouse":"Melissa Duck","voice":"Mel Blanc","img":"https://images.thehive-services.com/looneyToonsApi/daffy.jpg"},
    {"id":16,"name":"Michigan J. Frog","birthDay":"December 31, 1955","spouse":null,"voice":"Bill Roberts","img":"http://images.thehive-services.com/looneyToonsApi/michiganFrog.png"},
    {"id":17,"name":"Cecil Turtle","birthDay":"March 15, 1941","spouse":null,"voice":"Jim Rash","img":"http://images.thehive-services.com/looneyToonsApi/cecil.png"},
    {"id":18,"name":"Road Runner","birthDay":"September 17, 1949","spouse":null,"voice":"Mel Blanc","img":"http://images.thehive-services.com/looneyToonsApi/roadRunner.png"}]
    //  toons - array of objects

    // loop through the toons array
    // print toons[i].spouse

    // Print the spouse for each object
    // for(let i = 0; i < toons.length; i++) {
    //     console.log(toons[i].spouse)
    // }
    // // Print every other objects spouse
    // for(let i = 0; i < toons.length; i+=2) {
    //     console.log(toons[i].spouse)
    // }
    // // Start at the last object going to the first one printing the name
    // for(let i = toons.length-1; i >=0; i--) {
    //     console.log(toons[i].name)
    // }
    // // Start at the last object going to the first one printing every other name
    // for(let i = toons.length-1; i >=0; i-=2) {
    //     console.log(toons[i].name)
    // }

    // console.log(toons.length)