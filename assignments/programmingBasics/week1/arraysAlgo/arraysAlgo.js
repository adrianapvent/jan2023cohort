var testArr = [6, 3, 5, 1, 2, 4];
var sum = 0;
for (var i = 0; i < testArr.length; i++) {
	console.log('Value:', testArr[i]);

	sum = sum += testArr[i];
	console.log('Sum:', sum);
}
// Challenge 1 was to produce the value of each index number and then add to the sum to each index

var arrMulti = [6,3,5,1,2,4]
var sum = 0;
for(var i = 0; i < arrMulti.length; i++){
    sum = (i*arrMulti[i])
    console.log(sum)
}

// Challenge 2 was to produce an expected output that multiplied each number in the array by it's index number, 
// this 2nd part was very challenging and it required taking my knowledge learned in class and using online resources to piece together a for loop that produced the expected outcome. 
// I would like to further review this in class tomorrow to enhance my comprehension of the task. 