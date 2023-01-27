let farmFive = [
    {
      id: 1,
      farmName: 'Beech Ranch',
      farm_id: 1,
      animal_id: 1,
      count: 6,
      animalType: 'pig'
    },
    {
      id: 2,
      farmName: 'Beech Ranch',
      farm_id: 1,
      animal_id: 2,
      count: 10,
      animalType: 'chickens'
    },
    {
      id: 3,
      farmName: 'Beech Ranch',
      farm_id: 1,
      animal_id: 3,
      count: 3,
      animalType: 'goat'
    },
    {
      id: 4,
      farmName: 'Morton Farms',
      farm_id: 2,
      animal_id: 4,
      count: 4,
      animalType: 'horses'
    },
    {
      id: 4,
      farmName: 'Beech Ranch',
      farm_id: 3,
      animal_id: 4,
      count: 7,
      animalType: 'horses'
    }
  ]

function horseFarms(arr) {
    for(let i = 0; i < arr.length; i++) {
        if(arr[i].animalType == 'horses') {
            console.log(arr[i].farmName)
        }
    }
}
horseFarms(farmFive)


// JS version of the DB schema
class Farm {
    constructor(id, farmName){
        this.id = id
        this.farmName = farmName
    }
}

class Animal {
    constructor(id, animalType) {
        this.id = id
        this.animalType = animalType
    }
}

class FarmHasAnimal {
    constructor(id, farm_id, animal_id, count) {
        this.id = id
        this.farm_id = farm_id
        this.animal_id = animal_id
        this.count = count
    }
}

// Js version of inserting
let beech = new Farm(1, 'Beech Ranch')
let pig = new Animal(1, 'pig')
let connect01 = new FarmHasAnimal(1, beech, pig, 6)

// js version of select
console.log('Farm:', beech, 'Animal:', pig, 'Connection:', connect01)