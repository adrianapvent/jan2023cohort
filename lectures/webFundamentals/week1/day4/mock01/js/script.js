console.log("JS file wired up")

let count = 10
function countUp() {
    // console.log("box 10 clicked")
    count++
    // console.log("the count", count)
    document.getElementById('num').innerHTML = count
//  hey html. find element with id(num). change html = value of count 
}

function hideMe(element) {
    console.log("Ha you found me")
    element.style.display = "none"
//  clickedElement.changeCSS.displayProperty = none
}
function alertMe(element) {
    // console.log("Ya found me again")
    if(element.style.color == "pink") {
        element.style.color = "black"
    } else {
        element.style.color = "pink"
        alert("You changes my font color to pink")
    }
    
}