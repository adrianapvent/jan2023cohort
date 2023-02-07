console.log('wired up')

function hideMe() {
    document.getElementById('hide').style.display = 'none'
}
// when activated by the button/element calling my function name
// document = hey html doc
// getElementById('hide') = find the id that is called hide
// style = change the css for that id to....
// display = css attribute to change is the display property
// = 'none = this means change display: flex; to display: none;


function alertMe(element) {
    // console.log('clicked city', element)
    alert('Loading weather report...')
}

// change temps to f on change of select and back c if selected
// 24-75, 
// a = (0°C × 9/5) + 32 = 32°F
// b = (32°F − 32) × 5/9 = 0°C
// call the change class to target temps on change
// on change if value = c do formula a otherwise b

function changeTemp() {
    var x = document.getElementById('convert').value
    console.log("you chose", x)
    if(x == 'f') {
        console.log('f chosen')
        let a = document.getElementsByClassName('change')
        console.log(a)
        for(let i = 0; i < a.length; i++){
            console.log(a[i].innerText)
            let val = a[i].innerText
            val = val.substring(0, val.length-1)
            console.log(val)
            val = (val*(9/5)) + 32
            val = Math.round(val)
            console.log(val)
            a[i].textContent = val + '°'
        }

        // document.getElementsByClassName('change').innerHTML = a
    } else {
        console.log('c chosen')
        let a = document.getElementsByClassName('change')
        console.log(a)
        for(let i = 0; i < a.length; i++){
            console.log(a[i].innerText)
            let val = a[i].innerText
            val = val.substring(0, val.length-1)
            console.log(val)
            val = (val - 32) * (5/9)
            val = Math.round(val)
            console.log(val)
            a[i].textContent = val + '°'
        }
    }
}



// function myFunction() {
//   var x = document.getElementById("mySelect").value;
//   document.getElementById("demo").innerHTML = "You selected: " + x;
// }