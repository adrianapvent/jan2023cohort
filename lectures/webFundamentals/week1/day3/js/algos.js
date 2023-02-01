console.log('js connected')

let gradeArr = []
let avgArr = []

function populateGrades() {
    let a = parseInt(document.grades.gradeA.value)
    let b = parseInt(document.grades.gradeB.value)
    let c = parseInt(document.grades.gradeC.value)
    let d = parseInt(document.grades.gradeD.value)
    console.log(typeof(a))
    gradeArr.push(a)
    gradeArr.push(b)
    gradeArr.push(c)
    gradeArr.push(d)
}

function calcGrades() {
    populateGrades()

}
