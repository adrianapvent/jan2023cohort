
let petTrainingOwner = [
    {
        user: [
            {
                id: 1, firstName: 'Jane', lastName: 'Doe',  owner: [
                    {
                        id: 1, firstName: 'Jane', lastName: 'Doe', user_id: 1, pet: [
                            {
                                id: 1, petName: 'Zebra', species: 'Cat', owner_id: 1
                            }
                        ]
                    },
                    {
                        id: 3, firstName: 'Frodo', lastName: 'Baggins', user_id: 2, pet: [
                            {
                                id: 1, petName: 'Cicilly', species: 'Dog', owner_id: 2
                            },
                            {
                                id: 1, petName: 'Bill', species: 'Horse', owner_id: 2
                            }
                        ]
                    },
                ] 
            },
            {
                id: 2, firstName: 'Bob', lastName: 'Ross'
            },
            {
                id: 3, firstName: 'Frodo', lastName: 'Baggins'
            },
            {
                id: 4, firstName: 'James', lastName: 'Kirk', owner: [
                    {
                        id: 1, firstName: 'James', lastName: 'Kirk', user_id: 4, pet: [
                            {
                                id: 1, petName: 'Clifford', species: 'Dog', owner_id: 2
                            }
                        ]
                    },
                ]
            },
            {
                id: 5, firstName: 'John', lastName: 'Doe'
            },
            {
                id: 6, firstName: 'Jill', lastName: 'Smith'
            }
        ]
    }
]
console.log(petTrainingOwner[0])