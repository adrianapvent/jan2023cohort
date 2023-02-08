
var today = new Date(); // creating a variable called today and setting it equal to the current date (new Date() is a built in JS function/class that pulls the current date)
if(today.getDay() == 1) { // if statement = today.getDay() is equal to 1 (today (our var) getDay() built in function/ method in the Date class that pulls back the integer of the day of the week ) if Monday = int 1 and today is monday if statement triggered
    console.log("I hate Mondays!");
} else if(today.getDay() == 5) {
    console.log("Friday? More like Fri-yay!");
} else {
    console.log("Today is alright!");
}


// When ever you see new Capital() you know you are creating a new instance of the named (Capital) class
// when ever you later call the var that was used in front of the new Capital() you are talking to the instance created and if .function() is following the var you are talking to a method in the class