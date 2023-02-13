console.log('wired up')

// The API URLs
const url = "https://geek-jokes.sameerkumar.website/api?format=json"
const newUrl = "https://v2.jokeapi.dev/joke/Any"
const squish = 'https://dojo.navyladyveteran.com/squishies/'

// async/await & fetch = fetch is our get request = giving our food order to the waitress to give to the kitchen (kitchen = backend/api) async/await is our js file to go ahead and move to the next function I have to wait for something to finish my instructions

async function getSquish() {  // async function so that the rest of the file can run while waiting on response from this
    let res = await fetch(`${squish}`) // sending our get request out to the server via the url in ()
    let data = await res.json() // changing the data / ensuring the data is presented to us in json format
    console.log(data[0].name)
    for(let i = 0 ; i < data.length; i++) { // looping through the returned data
        let node = document.createElement('div') // creating a div
        let h3 = document.createElement('h3') // creating a h3
        let img = new Image() // creating the image this way allows us to better add the image path and alt tags
        let name = document.createTextNode(data[i].name) // variable to hold the text to be added to the h3
        img.src = `${data[i].img}` // setting the value for the images src tag
        img.alt = `${data[i].name}` // setting the value for the images alt tag
        console.log(img.src)
        h3.appendChild(name) // adding the text to the h3
        node.appendChild(img) // adding the img to the div/node
        node.appendChild(h3) // adding the h3 to to the div/node
        document.getElementById('squishies').appendChild(node) // pushing the newly formed div to the  div  with id squishies
    }
}
async function getJoke() {
    let res = await fetch(`${url}`)
    console.log('theData', res)
    let data = await res.json()
    console.log("the real data", data)
    console.log("just the jokes ma'am", data.joke)
    var node = document.createElement('tr')
    var td = document.createElement('td')
    var text = data.joke // Because I didn't call createTextNode this will need to be appended using append not appendChild
    td.append(text)
    node.appendChild(td)
    document.getElementById('jokeTable').appendChild(node)
}

$(document).ready(function() { // start talking to the html doc
    $('#jqueryJoke').click(function() { // on button click with id jqueryJoke
        $.get(url, function(res) { // get the url return it in json and complete the instructions
            console.log(res.joke)
            $('#jokeTable').append("<tr><td>" + res.joke + "</td></tr>") // Here is where we are able to simply put the html in proper format onto the page.  res.joke MUST be outside of the "" due to it being something in the function not a general part of the html string.  If it was in the "" it would read res.joke
        }, 'json')
    })
    $('#squish').click(function() {
        $.get(squish, function(res) {
            console.log(res[0].name)
            for(let i = 0 ; i < res.length; i++) {
                console.log(res[i].name)
                $('#squishies').append(`<div class='row'>
                <h3>${res[i].name}</h3> 
                <img src="${res[i].img}" alt="${res[i].name}"}>
                </div>`) // This is doing the same as the above append just using the back ticks `` so it can flow better
            }
        }, 'json')
    })
})

