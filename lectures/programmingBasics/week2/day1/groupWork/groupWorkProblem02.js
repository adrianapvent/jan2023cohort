// Create a function that takes an array of Arrays that prints the Max, Min, and Avg of each small array, and the avg of all the arrays combined

let arr02 = [[90,80,85,90], [50,70,80,90], [100,90,95,87],[40,80,70,76]]

console.log('\n========= Problem 2 Version 1 =========')
function max(arr){
    let max = arr[0]
    for(let i=1; i<arr.length; i++)
        if(arr[i] > max)
            max = arr[i]
    return max
}

function min(arr){
    let min = arr[0]
    for(let i=1; i<arr.length; i++)
        if(arr[i] < min)
            min = arr[i]
    return min
}

function avg(arr){
    let sum = arr[0]
    for(let i=1; i<arr.length; i++)
        sum += arr[i]
    return sum/arr.length
}

function mMA_2D(arr){
    let results = []
    for(let i=0; i<arr.length; i++){
        // {min: , max: , avg: }
        let mma = {min: min(arr[i]), max: max(arr[i]), avg: avg(arr[i])}
        results.push(mma)
    }

    let sumAvgs = results[0].avg
    for(let i=1; i<results.length; i++)
        sumAvgs += results[i].avg
    console.log("Total Average:", sumAvgs/results.length)
    
    return results
}
// console.log(mMA_2D(arr02))

console.log('\n========= Problem 2 Version 2 =========')

function innerArrays(arr) {
    let totalSum = 0
    let totalCount = 0
    for (let i = 0; i < arr.length; i++) {
        let inner = arr[i]
        let max = 0
        let min = inner[0]
        let sum = 0
        for (let j = 0; j < inner.length; j++) {
            totalCount++
            sum += inner[j]
            if (inner[j] > max) {
                max = inner[j]
            } else if (inner[j] < min) {
                min = inner[j]
            }
        }
        console.log(`max: ${max}, min: ${min}, average: ${(sum / inner.length)}`)
        totalSum += sum

    }
    console.log(`total average: ${totalSum / totalCount}`)
}

// innerArrays(arr02)


console.log('\n========= Problem 2 Version 3 =========')

function maxMinAvg(arr){
    var avgCombined = 0;
    for(let i = 0; i < arr.length; i++){
        console.group("Array at index ", i)
        console.log(`Max is ${max(arr[i])}`)
        console.log(`Min is ${min(arr[i])}`)
        console.log(`Avg is ${avg(arr[i])}`)
        console.groupEnd()
        avgCombined += avg(arr[i])
    }
    console.log("Averages of averages" ,avgCombined/arr.length)
}
//maxMinAvg(arr02)

function max(arr){
    var max = arr[0]
    for(let i = 0; i < arr.length; i++){
        if(arr[i] > max){
            max = arr[i]
        }
    }
    return max
}

function min(arr){
    var min = arr[0]
    for(let i = 0; i < arr.length; i++){
        if(arr[i] < min){
            min = arr[i]
        }
    }
    return min
}

function avg(arr){
    var sum = 0;
    for(let i = 0; i < arr.length; i++){
        sum += arr[i]
    }
    return sum/arr.length
}

function MaxMinAvg(arr){
    //console.log(arr02); //the array of arrays
    //console.log('The first array?', arr[0]); //the first array in the arrays.
    //nextArray = arr[0].length; //gets length of the first internal array
    //console.log('length of the first internal array:', nextArray);
    countOfArrays = arr.length;  //the number of internal arrays
    //console.log(`length of the array?: ${countOfArrays}`);
    //loop through each internal array
    var max = 0;
    var min = 0;
    var avg = 0;
    var storageArray = [];
    //console.log(arr[0][0]);  //first [] is the array position, second [] is the index of that array
    for(let i = 0; i < countOfArrays; i++){
        //
            for(let j = 0; j < arr[i].length; j++){
                //console.log('This is the J loop', arr[j]);
                //console.log(arr[i][j]);
                if(arr[i][j] > max){
                    max = arr[i][j];
                    storageArray.push[max];
                    //console.log(max);
                }
         

            }
        
        console.log(storageArray);
        

    }

}
// console.log('the max, min and avg');
// MaxMinAvg(arr02);

console.log('\n========= Problem 2 Version 4 =========')

function classAvg(arr) {
    let theClass = []

    function theMax(arr) {
        let max = arr[0]
        for(let s = 0; s < arr.length; s++) {
            if(max < arr[s]) {
                max = arr[s]
            }
        }
        // console.log(`The Max: ${max}`)
        return max
    }

    function theMin(arr) {
        let min = arr[0]
        for(let s = 0; s < arr.length; s++) {
            if(arr[s] < min) {
                min = arr[s]
            }
        }
        // console.log(`The Min: ${min}`)
        return min
    }

    function theSum(arr) {
        let sum = 0
        for(let s = 0; s < arr.length; s++) {
            sum += arr[s]
        }
        // console.log(`The Sum: ${sum}`)
        return sum
    }

    function theAvg(arr) {
        let avg = 0
        let sum = theSum(arr)
        avg = sum / arr.length
        // console.log(`The Avg: ${avg}`)
        return avg
    }

    for(let i = 0; i < arr.length; i++) {
        let r = {student: i+1, max: theMax(arr[i]), min: theMin(arr[i]), sum: theSum(arr[i]), avg: theAvg(arr[i])}
        theClass.push(r)
        // console.log(theClass)
    }
    let finalSum = 0
    let finalAvg = 0
    for(let i = 0; i < theClass.length; i++) {
        finalSum += theClass[i].avg
        // console.log(`curr Sum: ${finalSum}`)
    }
    finalAvg = {classAvg: finalSum/theClass.length}
    // console.log(theClass.length)
    theClass.push(finalAvg)
    console.log('The final answer:', theClass)

}
classAvg(arr02)