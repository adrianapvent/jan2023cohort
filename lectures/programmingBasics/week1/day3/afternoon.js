var dinos = [
    { id: 0, name: "tyrannosaurus", diet: "carnivorous", weight: "7000kg", height: "12m", period: "Late Cretaceous" },
    {id: 1, name: "stegosaurus", diet: "herbivorous", weight: "2000kg", height: "9m", period: "Late Jurassic"},
    {id: 2, name: "velociraptor", diet: "carnivorous", weight: "15kg", height: "1.8m", period: "Late Cretaceous"},
    {id: 3, name: "stegosaurus", diet: "carnivorous", weight: "2000kg", height: "9m", period: "Late Jurassic"}
]
// print the names of the dinos that were part of the Late Jurassic period

// for loop = looping the array of objects - start, stop, and how to proceed - start = 0 stop = dinos.length, proceed i++




for(let i = 0; i < dinos.length; i++) {
    // console logging now will print will print the whole array of objects
    // console.log(dinos[i].period)
    let id = dinos[i].id
    let period = dinos[i].period 
    if(period == "Late Jurassic") { // basically removed all dinos that were not born in late jurassic from the room
        // console.log(id, dinos[i].name)
    } 
    if(dinos[i].diet == "carnivorous") { // removed all dino that are not carnivorous
        // console.log(id, dinos[i].weight)
    }
}

let house = [
    {
        'floor': 'main level', 'rooms': [
            {
                'roomName': 'livingRoom', 'contents': [
                    'couch', 'tv', 'bookcase'
                ]
            },
            {
                'roomName': 'kitchen', 'contents': [
                    'table', 'chairs', 'dishes'
                ]
            },
            {
                'roomName': '1/2 Bathroom', 'contents': [
                    'sink', 'toilet', 'mirror'
                ]
            }
        ]
    },
    {
        'floor': '2nd Level', 'rooms': [
            {
                'roomName': 'masterBedroom', 'contents': [
                    'bed', 'dresser', 'chair', 'bathroom'
                ]
            },
            {
                'roomName': 'gameRoom', 'contents': [
                    'tv', 'games', 'chairs', 'billiards table'
                ]
            },
            {
                'roomName': 'Office', 'contents': [

                ]
            }
        ]
    },
    {
        'floor': 'attic', 'rooms': [
            {
                'roomName': 'attic', 'contents': [
                    'holiday decor', 'old paintings', 'trunks'
                ]
            }
        ]
    }
]
// print array
console.log('whole array',house)

// print 1 floor
console.log('a floor', house[1])

// print the name of the above floor
console.log('floor name', house[1].floor)

// print rooms on 1 floor
console.log('the rooms on the floor', house[1].rooms)

// print 1 room on 1 floor
console.log('a room on the floor', house[1].rooms[0])

// print name of above room
console.log('room name', house[1].rooms[0].roomName)
// print contents of 1 room on 1 floor
console.log('contents of room', house[1].rooms[0].contents)

// print 1 item in the room
console.log('contents of room', house[1].rooms[0].contents[2])

// print last item in the room contents
// list length = 4  index go from 0-3
console.log('contents of room', house[1].rooms[0].contents[house[1].rooms[0].contents.length-1])


console.log('**********************************************************')

// print all the floor names
// let floor 
for(let i = 0; i < house.length; i++) {
    let floor = house[i].floor
    // console.log('all the floors', floor)
}
console.log('**********************************************************')
//  print all the room names
for(let i = 0; i < house.length; i++) {
    // console.log(house[i].rooms.roomName)
    let theRooms = house[i].rooms
    // console.log(theRooms)
    for(let r = 0; r < theRooms.length; r++) {
        let theRoom = theRooms[r].roomName
        // console.log(theRoom)
    }
}
console.log('**********************************************************')
// print all the rooms on the main floor
for(let i = 0; i < house.length; i++) { //same for loop to go through all the floors
    let floor = house[i].floor // creating a easy var for the floors
    let theRooms = house[i].rooms // creating a easy var for the room objects
    // console.log('all the floors', floor)
    if(floor == "main level") { // checking each floor name against the provided "string" (this is all that would need to change to get room on different floor)
        for(let r = 0; r < theRooms.length; r++) { // same loop to print all rooms
            let theRoom = theRooms[r].roomName //create a easy var for the room names
            console.log(theRoom) // printing just the room names of the floor selected in the if statement
        }
    }
}
console.log('**********************************************************')
// print all the contents in all the rooms on the 2nd floor
for(let i = 0; i < house.length; i++) {
    let floor = house[i].floor
    let theRooms = house[i].rooms
    if(floor == "2nd Level") {
        for(let r = 0; r < theRooms.length; r++) {
            let stuff = theRooms[r].contents
            for(let s = 0; s < stuff.length; s++) {
                let item = stuff[s]
                console.log(item)
            }
        }
    }
}
console.log('**********************************************************')
// print all the contents in the house

for(let i = 0; i < house.length; i++) { // go through whole house
    let theRooms = house[i].rooms // easy var for the rooms
    for(let r = 0; r < theRooms.length; r++) { // go through every room
        let stuff = theRooms[r].contents // easy var for the items
            for(let s = 0; s < stuff.length; s++) { // list all items
                let item = stuff[s]
                console.log(item)
            }
    }
}