var arr = [8, 6, 7, 5, 3, 0, 9];
for (var i = 0; i < arr.length; i++) {
	console.log("Predict1:", arr[i]);
}

// Prediction: the terminal will display each number in the array, one at a time beginning at index 0 (8) and ending with index 6 (9)
// Prediction was correct.

var arr = [7, 3, 8, 4, 2, 0, 1];
for (var i = 0; i < arr.length; i++) {
	if (arr[i] % 2 == 0) {
		console.log("Predict2:", arr[i]);
	} else {
		console.log("Predict2:", 'That is odd!');
	}
}

// Prediction: the for loop will begin at index 0 (7) and loop through each number in the array, if the answer is an even/divisible by 2 then the number will populate, if the number is an odd and NOT divisible by 2 then it will populate "That is odd!"
// Prediction was correct.

var arr = [1,3,8,-5,0,-2,4,-1];
var newArr = [];
for(var i = 0; i < arr.length; i++){
    if(arr[i] < 0){
        newArr.push(arr[i]);
        arr[i] = arr[i] * -1;
    }
    else if(arr[i] == 0){
        arr[i] = "Zero";
    }
    else{
        arr[i] = arr[i] * -1;
    }
}
console.log("Prediction3:", arr);
console.log("Prediction3: newArr", newArr);

// Prediction: the for loop will begin at index 0 (1) and increment by one for each loop.
// The newArr will populate based on the rules, if the index shows a number less than 0 then it will add(.push) that number to the array and multiply it by -1, else if it is a 0 then it will state "Zero", else it will take the index number and multiply by -1
// The number that should populate are: 1,-1, 3,-3, 8,-8, -5,5, 0,"Zero", -2,2, 4,-4, -1,1
// Prediction was partially correct: the arr was listed correctly, the newArr was partially there however, I was confused on which would be added and how they would be displayed. After seeing answer I better understood the logic.