console.log('js connected')
function runAlert() {
    alert("Warning you are about to collect names and grades")
}
// runAlert()

// Global variables that can be used by any function on the file

let gradeArr = [] // empty array to temp store the grades for 1 student
let avgArr = [] // empty array to story all the calculated grades
let student = '' // empty string to hold our student object

// Creating a class for the student so it returns an object with the name and avg
class Student {
    // 1 parameter must be declared to create an instance or object of Student
    constructor(name) {
        this.name = name
        // this.name = '' // we could have set this.name equal to this so nothing was in the constructor() and thus nothing is required to create however then we would then need to have a method to update the name field
        this.avg = 0
    }
}


// populates the gradeArr array with the grades from the html form
function populateGrades() {
    // creating a var setting it equal to = (document = talk to the html, grades = find the element with a name called grades, gradeA = find the input or element with the name of gradeA and value = the value that is found at gradeA in this case the value entered into the form for the 1st grade) the grade entered at each Quarter input and making sure that it is an integer (parseInt)
    let a = parseInt(document.grades.gradeA.value)
    let b = parseInt(document.grades.gradeB.value)
    let c = parseInt(document.grades.gradeC.value)
    let d = parseInt(document.grades.gradeD.value)
    // same as above but talking to the input with the name of firstName
    let name = document.grades.firstName.value
    // below we are just making sure that the data type for the let a is an integer
    console.log(typeof(a))
    gradeArr.push(a)
    gradeArr.push(b)
    gradeArr.push(c)
    gradeArr.push(d)
    // above adds all the grades to the temp arr called gradesArr
    console.log(gradeArr)
    student = new Student(name)
    // above we are creating that student object and providing it the name given on the form
    console.log(student)
    // returning the student object
    return student
}

// This is the function that is actually initializing all of the grade related functions on this page it is activated by clicking the submit button on the html
function calcGrades(arr) {
    // calls the form inputs
    populateGrades()
    alert("Your form data was accepted")
    // creating a var for the divisor for average
    let divisor = arr.length
    // for loop to go through the gradesArr
    for(let i = 0; i < arr.length; i++) {
        // because we created a class we can use the defaulted avg here to figure out the sum and average here we are just adding each value in the array
        student.avg += arr[i]
        console.log('sum in loop:', student.avg, 'current grade added:', arr[i])
    }
    // here outside the loop we are taking the current value of the "object average" and dividing it by the divisor declared above
   student.avg = student.avg / divisor
    console.log('the avg is:', student.avg, 'theStudent:', student)
    avgArr.push(student)
    console.log('current class averages:', avgArr)
    // here we are again calling the html document saying find the element with an id of student (if just = it will replace every function call) and updating the html with the new values of the students name and average with a space at the end to allow for it to read right
    document.getElementById('student').innerHTML += student.name + ' Avg: ' + student.avg + '<br>'
    // resets the the temp back to empty for next calculations
    gradeArr = []
}
