// Programming Languages and Frameworks

let tools = [
    "HTML",
    "JavaScript",
    "CSS",
    "C#",
    "Java",
    "Python",
    "Spring Boot",
    ".NET",
    "PHP",
    "Google Fu",
    "Git",
    "Github"
]
// console.log("The root Array:", tools)
// for(let i = 0; i < tools.length; i++){
//     console.log("looping through array:", tools[i])
//     // return tools[i]
// }
function siteTools(arr) {
    var node = document.createElement('div') // creating a html div and giving it the variable node 
    node.setAttribute('class', 'node')
    // var img = document.createElement('img')
    // img.src = 
    for(let i = 0; i  < arr.length; i++) {
        console.log(arr[i])
        var toolDiv = document.createElement('div')
        var h3 = document.createElement('h3')
        var tool = document.createTextNode(arr[i])
        h3.appendChild(tool)
        // h3.setAttribute('class', )
        toolDiv.setAttribute('class', "toolDiv btn btn-outline-info")
        toolDiv.appendChild(h3)
        node.appendChild(toolDiv)
    }
    document.getElementById('tools').appendChild(node)
}





// Clock

function getSecondsSinceStartOfDay() {
    // below returning new date / seconds + min + hours
    // return example 43590
    let hour = new Date().getHours()
    let min = new Date().getMinutes()
    let sec = new Date().getSeconds()
    console.log('hour', hour, 'min', min, 'sec', sec)
    let time = {hour: hour, min: min, sec: sec}

    return time;
}

setInterval( function() {
    // getting time
    var time = getSecondsSinceStartOfDay();
    // printing time
    console.log(time);
    console.log(time.hour)
    let hour = time.hour
    let hourHand  = document.getElementById('hour')
    // let h = time.hour
    // let h = 180
    // h *= 30
    // console.log(h)
    // let hourRotation = (target, val) => {
    //     target.style.transform = `rotate(${val}deg)`
    // } 
    // hourRotation()
    // let time[hour] *= 30; // 12 * 30 = 360deg
    // let time[min] *= 6;
    // let time[sec] *= 6; // 60 * 6 = 360deg
    // let hour = time/3600
    // console.log('hour',hour)
    // hour = parseInt(hour)
    // console.log('hour int',hour)
    // let min = (time/60)
    // console.log('min',min)
    // document.getElementById('hour').style.transform = `rotate(${h}deg)`


}, 15000);
// above is how often to run function

// hour hand moves 30 degrees / hour
// min hand moves 6degrees / min
// second moves 1/10 degree / second

