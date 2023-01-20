function greeting() {
    return "Hello";
    console.log("World");
}
var word = greeting();
console.log(word);

// My prediction for this function is that is will state 
// Hello - because anything after the return statement will not get executed
// Prediction was correct

function add(num1, num2){
    console.log("Summing Numbers!");
    console.log("num1 is: " + num1);
    console.log("num2 is: " + num2);
    var sum = num1 + num2;
    return sum;
}

var result1 = add(3,5);
var result2 = add(4,7);
console.log(result1);
console.log(result2);

// My prediction is that is will return:
// "Summing Numbers! num 1 is: 3, num 2 is: 5, result1 = 8"
// "Summing Numbers! num 1 is: 4, num 2 is: 7, result2 = 11"

// My prediction was partially correct, only difference was that the result was displayed in the last 2 rows after the function completed it's portion. 

function highFive(num) {
    for(var i = 0; i < num; i++){
        if(i == 5){
            console.log("High Five!");
        }
        else{
            console.log(i);
        }
    }
}

// highFive(8)

// My prediction for function highFive is that is will search through an array of numbers and if the number is equal to 5 then the terminal will display "High Five!" if not it will console.log the index number.
// So My prediction was incorrect... I think it was because we did not call the function at the end i.e. highFive()

// I then added an example to test my theory, and it was able to correctly produce my initial expected output
// 0
// 1
// 2
// 3
// 4
// High Five!
// 6
// 7