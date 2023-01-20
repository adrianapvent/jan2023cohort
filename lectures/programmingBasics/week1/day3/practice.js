let desk = [
    {
        'location': 'shelf#1', 'items': [
            {
                'item': 'lego flower', 'count': 2, 'type': [
                    {
                        'name': 'tulip', 'colors': [
                            'red', 'green', 'white'
                        ]
                    },
                    {
                        'name': 'daisy', 'colors': [
                            'yellow', 'white', 'green'
                        ]
                    }
                ]
            },
            {
                'item': 'frog', 'count': 2, 'type': [
                    {
                        'name': 'toy', 'colors': [
                            'green'
                        ]
                    }
                ]
            }
        ]
    },
    {
        'location': 'undershelf#1', 'items': [
            {
                'item': 'beeSquishi', 'count': 1, 'type': [
                    {
                        'name': 'Squishi toy', 'colors': [
                            'yellow', 'black', 'white', 'pink'
                        ]
                    }
                ]
            }
        ]
    },
    {
        'location': 'main desk', 'items': [
            {
                'item': 'monitors', 'count': 2, 'type': [
                    {
                        'name': 'viotek', 'colors': [
                            'black'
                        ]
                    },
                    {
                        'name': 'imac', 'colors': [
                            'grey', 'mint green'
                        ]
                    }
                ]
            }
        ]
    }
]
// Print whole array
// console.log(desk)

// Print 1 location
// console.log(desk[2])

// Print 1 location name
// console.log(desk[2].location)

// Print 1 location items
// console.log(desk[0].items)

// Print item object
// console.log(desk[0].items[1])

// print the item object count
// console.log(desk[0].items[0].count)

// print the item object name
// console.log(desk[1].items[0].type[0].name)

// print the colors of the object
// console.log(desk[1].items[0].type[0].colors)

// print 1 color of the item
// console.log(desk[1].items[0].type[0].colors[0])

// console.log('**********************************************************')

// Print the names of all the locations
for(let i = 0; i < desk.length; i++) {
    console.log(desk[i].location)
}
console.log('**********************************************************')

// print the array of types for any item that has a count more than 1
for (let i = 0; i < desk.length; i++) {
    let arr1 = desk[i].items;
    // console.log(arr1)
    for (let j = 0; j < arr1.length; j++) {
        let obj3 = arr1[j].count;
        // console.log(arr1[j].type)
        if(obj3 > 1){
            console.log(arr1[j].type)
        }
    }
}

console.log('**********************************************************')

// Print all the item names if they have a color of white in the list of colors
// Liannys
for(let i = 0; i < desk.length; i++){
    for(let j = 0; j < desk[i].items.length; j++){
        for(let k = 0; k < desk[i].items[j].type.length; k++)
        {
            for(let l = 0; l < desk[i].items[j].type[k].colors.length; l++){
                if(desk[i].items[j].type[k].colors[l] == 'white')
                {
                    console.log(desk[i].items[j].type[k].name)
                }
            }
            
        }
    }
}
// Kaitlynn
for(let i = 0; i < desk.length; i++){
    for(let j = 0; j < desk[i].items.length; j++){
            for(let k = 0; k < desk[i].items[j].type.length; k++){
                    for (let m = 0; m < desk[i].items[j].type[k].colors.length; m++){
                            if(desk[i].items[j].type[k].colors[m] == 'white'){
                                    console.log(desk[i].items[j].type[k].name)
                                    break //HERE
                            }
                    }
            }
    }
}
// Brianna
for (let i = 0; i < desk.length; i++) {
    // console.log('lo1', desk[i])
    
        for (let z = 0; z < desk[i].items.length; z++){
        // console.log('lo2',desk[i].items[z])
    
        // console.log ('lo2.5', desk[i].items[z].type)
        
        for (let x = 0; x < desk[i].items[z].type.length; x++){
        // console.log ('lo 3',desk[i].items[z].type[x])
    
        for (let y = 0; y < desk[i].items[z].type[x].colors.length; y++){
        // console.log ('lo 4',desk[i].items[z].type[x].colors[y])
    
        if (desk[i].items[z].type[x].colors[y] == 'white') {
        console.log ('final ans',desk[i].items[z].type[x].name)
        }
        }
        }
        }
    }
    // Ubin
    for (let i = 0; i < desk.length; i++) {
        var items = desk[i].items
        for (let j = 0; j < items.length; j++) {
            var types = items[j].type
            for (let k = 0; k < types.length; k++) {
                var colors = types[k].colors
                for (let l = 0; l < colors.length; l++) {
                    if (colors[l] === 'white') {
                        console.log(types[k].name)
                    }
                }
            }
        }
    }