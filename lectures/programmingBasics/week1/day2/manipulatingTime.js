// Strings


// 1. Pull the current date and time
const today = new Date()
console.log(today)

// 3. console.log the time only
// const theTime = today.getTime()
// const theTime = today.getHours() + ':' + today.getMinutes()
// const theTime = today.toTimeString()
const theTime = today.toLocaleTimeString()
console.log(theTime)
// 4. console.log the date only
const  theDate = today.toDateString()
console.log(theDate)
// 5a. What time zone is displaying?
const central = today.toLocaleTimeString('en-US', {timeZone: 'America/Chicago'})
console.log(central)

// 5b. Change to the different time zones (ET, CT, MT, PT)

// Using the provided HTML file create functions to display things on the page (you can not edit the html document) and have a console.log for each

function est() {
    est = new Date(new Date().getTime() + -4*60*60*1000).toUTCString('en-GB')
    console.log('EST: ', est)
    adjust = est.slice(-12)
    console.log(adjust)
    cut = adjust.substr(0,10)
    console.log(cut)
    zone = 'EST'
    final = cut + zone
    console.log(final)
}
est()
function supercala() {
    word = "supercalafragalisticexpicalidoscious"
    console.log(word)
    // adjust = word.slice(-8)
    // adjust = word.substr(0,5)
    adjust = word.substr(9,11)
    console.log(adjust)
}
supercala()