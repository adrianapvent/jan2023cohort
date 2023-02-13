console.log('wire up')
var apodUrl = 'https://api.nasa.gov/planetary/apod'
// /RoverName/photos?camera=CameraName&api_key=KEY
var marsUrl = 'https://api.nasa.gov/mars-photos/api/v1/rovers/'
var nasaKey = keys.NASAKEY

console.log(keys.NASAKEY)

async function apod() {
    var res = await fetch(`${apodUrl}?api_key=${nasaKey}`)
    // console.log(res)
    var data = await res.json()
    console.log(data)
    var node = document.createElement('div')
    var img = new Image
    var h2 = document.createElement('h2')
    var p = document.createElement('p')
    if(data.media_type === 'image') {
        // console.log(data.media_type)
        p.append(data.explanation) // use append if appending the data directly / string
        h2.append(data.title)
        img.src=data.url
        img.alt = data.title
        node.appendChild(h2) // use appendChild if adding element / textNode
        node.appendChild(img)
        node.appendChild(p)
    } else {
        // console.log("not an image")
        h2.append("No image returned today, please come back tomoroww")
        node.appendChild(h2)
    }
    node.setAttribute('class', 'nasa')
    document.getElementById('apod').appendChild(node)
}

