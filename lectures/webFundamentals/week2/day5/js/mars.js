console.log('wire up')
// /RoverName/photos?camera=CameraName&api_key=KEY
var marsUrl = 'https://api.nasa.gov/mars-photos/api/v1/rovers/'
var nasaKey = keys.NASAKEY

console.log(keys.NASAKEY)


let rover = ''
let camera = ''
function formData() {
    rover = document.marsForm.rover.value
    camera = document.marsForm.camera.value
    console.log(rover, camera)
}
// formData()
async function marsRovers() {
    // e.preventDefault();
    formData()
    console.log(rover, camera)
    var res = await fetch(`${marsUrl}${rover}/photos?sol=1000&camera=${camera}&api_key=${nasaKey}`)
    // var res = await fetch(`${marsUrl}`)
    // console.log(res)
    var data = await res.json()
    console.log(data)
    // console.log(data.photos[0])
    // console.log(data.photos[0].earth_date)
    data = data.photos
    for(let i =0; i < data.length; i++) {
        // console.log('test')
        var node = document.createElement('div')
        var img = new Image
        var roverName = document.createElement('h3')
        var cameraName = document.createElement('h3')
        var date = document.createElement('h3')
        cameraName.append(`Camera: ${data[i].camera.full_name}`)
        roverName.append(`Rover: ${data[i].rover.name}`)
        date.append(data[i].earth_date)
        img.src = data[i].img_src
        img.alt = "Rover Image"
        node.appendChild(img)
        node.appendChild(roverName)
        node.appendChild(cameraName)
        node.appendChild(date)
        node.setAttribute('class', 'nasa')
        document.getElementById('mars').appendChild(node)
    }
}


/*
{
    0: 
        {
            camera : full_name: "Navigation Camera"
            id: 26
            name: "NAVCAM"
            rover_id: 5
            earth_date: "2015-05-30"
            id: 103383
            img_src: "http://mars.jpl.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01000/opgs/edr/ncam/NLB_486272784EDR_F0481570NCAM00415M_.JPG"
            rover: 
                {
                    id: 5
                    landing_date: "2012-08-06"
                    launch_date: "2011-11-26"
                    name: "Curiosity"
                    status: "active"
                }
            sol: 1000
        }
}
 */