function shiftArr(arr) {
    for(let i = 0; i < arr.length; i++) {
        arr[i] = arr[i+1]
    }
    // arr[arr.length-1] = 0 // This is good
    // arr.push(0) // This would just add 0 after undefined
    arr.splice(arr.length-1, 1, 0) // This works

    console.log('after loop:', arr)
}
let arr = [1,2,3,4,5,6,7,8,9]
for(let i = 0; i < arr.length; i++) {
    if(i = arr.length -1) {
        arr[i] = 0
    } else {
        arr[i] = arr[i+1]
    }
}
function shiftArray(arr) {
  for (var i = 1; i < arr.length; i++) {
    arr[i-1] = arr[i]
    }
    arr[arr.length-1] = 0; 
    console.log(arr)
    return arr;
}
function shiftArray(arr){
    arr.shift()
    arr.push(0)
    return arr
}
console.log(shiftArray([1,2,3]))