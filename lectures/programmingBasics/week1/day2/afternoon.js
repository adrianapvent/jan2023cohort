var arr = [1,3,8,-5,0,-2,4,-1];
var newArr = [];
for(var i = 0; i< arr.length; i++){
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
console.log(arr);
console.log(newArr);


// line 1: a variable called arr that is an array of numbers
// line 2: var called newarr with an empty array
// line 3: start for loop i starts at 0 go through length of the array increasing i by 1 each loop
// line 4: start if = value of i < 0 do lines 5 and 6
// line 5: add current value of i to the newArr
// line 6: current index will now equal current value times -1
// line 8: start else if = value of i == 0 do line 9
// line 9: current value of i becomes "Zero"
// line 11: start else = current index will now equal current value of i times it by -1 
// arr = [-1, -3, -8, 5, "Zero", 2, -4, 1]
// newArr = [-5, -2, -1]