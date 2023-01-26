let petTrainingOwner = [
    {
        owners: [
            {
                id: 3, 
                firstName: 'Harry', 
                lastName: 'Potter', 
                pets: [
                    {
                        id: 1, 
                        name: 'Bear', 
                        enrolled: [
                            {
                                id: 1, 
                                startDate: 'Jan 30, 2023', 
                                cohorts: [
                                    {
                                        id: 1, 
                                        className: 'Agility', 
                                        trainer: [
                                            {
                                                id: 1, 
                                                firstName: 'Jane', 
                                                lastName: 'Doe'
                                            },
                                        ]
                                    },
                                ]
                            },
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', trainer: [
                                            {
                                                id: 2, 
                                                firstName: 'Bob', 
                                                lastName: 'Ross'
                                            },
                                        ]
                                    },
                                ]
                            },
                            {
                                id: 4, 
                                startDate: 'Feb 17, 2023', 
                                cohorts: [
                                    {
                                        id: 3, 
                                        className: 'Advanced Jumping', 
                                        trainer: [
                                            {
                                                id: 5, 
                                                firstName: 'Leonard', 
                                                lastName: 'McCoy'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                    {
                        id: 2, 
                        name: 'Abby', 
                        enrolled: [
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', 
                                        trainer: [
                                            {id: 2, firstName: 'Bob', lastName: 'Ross', cohorts: []}
                                        ]
                                    },
                                ]
                            },
                            {
                                id: 3, 
                                startDate: 'Feb 20, 2023', 
                                cohorts: [
                                    {
                                        id: 1, 
                                        className: 'Agility',
                                        trainer: [
                                            {
                                                id: 1, 
                                                firstName: 'Jane', 
                                                lastName: 'Doe'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                ]
            },
            {
                id: 4, 
                firstName: 'James', 
                lastName: 'Kirk', 
                pets: 
                [ 
                    {
                        id: 3, 
                        name: 'Lucy', 
                        enrolled: [
                            {
                                id: 4, 
                                startDate: 'Feb 17, 2023', 
                                cohorts: [
                                    {
                                        id: 3, 
                                        className: 'Advanced Jumping', 
                                        trainer: [
                                            {
                                                id: 5, 
                                                firstName: 'Leonard', 
                                                lastName: 'McCoy'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                    {
                        id: 4, 
                        name: 'Roxy', 
                        enrolled: [
                            {
                                id: 1, 
                                startDate: 'Jan 30, 2023', 
                                cohorts: [
                                    {
                                        id: 4, 
                                        className: 'Service Dog Training', 
                                        trainer: [

                                        ]
                                    },
                                ]
                            },
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', 
                                        trainer: [
                                            {id: 2, firstName: 'Bob', lastName: 'Ross', cohorts: []}
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                    {
                        id: 5, 
                        name: 'Copper', 
                        enrolled: [
                            {
                                id: 4, 
                                startDate: 'Feb 17, 2023', 
                                cohorts: [
                                    {
                                        id: 3,  className: 'Advanced Jumping', 
                                        trainer: [
                                            {id: 5, firstName: 'Leonard', lastName: 'McCoy', cohorts: []}
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                ]
            },
            {
                id: 7, 
                firstName: 'Spock', 
                lastName: '', 
                pets: [
                    {
                        id: 10, 
                        name: 'Bones', 
                        enrolled: [
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', 
                                        trainer: [
                                            {
                                                id: 2, 
                                                firstName: 'Bob', 
                                                lastName: 'Ross'
                                            },
                                        ]
                                    },
                                ]
                            },
                            {
                                id: 3, 
                                startDate: 'Feb 20, 2023', 
                                cohorts: [
                                    {
                                        id: 1, 
                                        className: 'Agility', 
                                        trainer: [
                                            {
                                                id: 1, 
                                                firstName: 'Jane', 
                                                lastName: 'Doe'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                ]
            },
            {
                id: 8, 
                firstName: 'Dumbledore', 
                lastName: '', 
                pets: [
                    {
                        id: 6, 
                        name: 'Lily', 
                        enrolled: [
                            {
                                id: 4, 
                                startDate: 'Feb 17, 2023', 
                                cohorts: [
                                    {
                                        id: 3, 
                                        className: 'Advanced Jumping',
                                        trainer: [
                                            {
                                                id: 5, 
                                                firstName: 'Leonard', 
                                                lastName: 'McCoy'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                    {
                        id: 7, 
                        name: 'BumbleBee', 
                        enrolled: [
                            {
                                id: 1, 
                                startDate: 'Jan 30, 2023', 
                                cohorts: [
                                    {
                                        id: 1, 
                                        className: 'Agility', 
                                        trainer: [
                                            {
                                                id: 1, 
                                                firstName: 'Jane', 
                                                lastName: 'Doe'
                                            },
                                        ]
                                    }
                                ]
                            },
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', 
                                        trainer: [
                                            {
                                                id: 2, 
                                                firstName: 'Bob', 
                                                lastName: 'Ross'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                    {
                        id: 8, 
                        name: 'Delta', 
                        enrolled: [
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', 
                                        trainer: [
                                            {
                                                id: 2, 
                                                firstName: 'Bob', 
                                                lastName: 'Ross'
                                            },
                                        ]
                                    },
                                ]
                            },
                            {
                                id: 3, 
                                startDate: 'Feb 20, 2023', 
                                cohorts: [
                                    {
                                        id: 4, 
                                        className: 'Service Dog Training', 
                                        trainer: [
                                            {
                                                id: 6, 
                                                firstName: 'Hagrid', 
                                                lastName: ''
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                    {
                        id: 9, 
                        name: 'Arty', 
                        enrolled: [
                            {
                                id: 1, 
                                startDate: 'Jan 30, 2023', 
                                cohorts: [
                                    {
                                        id: 1, 
                                        className: 'Agility', 
                                        trainer: [
                                            {
                                                id: 1, 
                                                firstName: 'Jane', 
                                                lastName: 'Doe'
                                            },
                                        ]
                                    },
                                ]
                            },
                            {
                                id: 2, 
                                startDate: 'Feb 5, 2023', 
                                cohorts: [
                                    {
                                        id: 2, 
                                        className: 'Behavior', 
                                        trainer: [
                                            {
                                                id: 2, 
                                                firstName: 'Bob', 
                                                lastName: 'Ross'
                                            },
                                        ]
                                    },
                                ]
                            },
                        ]
                    },
                ]
            },
        ]
    },
]


let users = [
    {id: 1, firstName: 'Jane', lastName: 'Doe'},
    {id: 2, firstName: 'Bob', lastName: 'Ross'},
    {id: 3, firstName: 'Harry', lastName: 'Potter'},
    {id: 4, firstName: 'James', lastName: 'Kirk'},
    {id: 5, firstName: 'Leonard', lastName: 'McCoy'},
    {id: 6, firstName: 'Hagrid', lastName: ''},
    {id: 7, firstName: 'Spock', lastName: ''},
    {id: 8, firstName: 'Dumbledore', lastName: ''}
]
let owners = [
    {id: 3, firstName: 'Harry', lastName: 'Potter', pets: []},
    {id: 4, firstName: 'James', lastName: 'Kirk', pets: []},
    {id: 7, firstName: 'Spock', lastName: '', pets: []},
    {id: 8, firstName: 'Dumbledore', lastName: '', pets: []}
]
let trainers = [
    {id: 1, firstName: 'Jane', lastName: 'Doe', cohorts: []},
    {id: 2, firstName: 'Bob', lastName: 'Ross', cohorts: []},
    {id: 5, firstName: 'Leonard', lastName: 'McCoy', cohorts: []},
    {id: 6, firstName: 'Hagrid', lastName: '', cohorts: []}
]
let pets = [
    {id: 1, name: 'Bear', enrolled: []},
    {id: 2, name: 'Abby', enrolled: []},
    {id: 3, name: 'Lucy', enrolled: []},
    {id: 4, name: 'Roxy', enrolled: []},
    {id: 5, name: 'Copper', enrolled: []},
    {id: 6, name: 'Lily', enrolled: []},
    {id: 7, name: 'BumbleBee', enrolled: []},
    {id: 8, name: 'Delta', enrolled: []},
    {id: 9, name: 'Arty', enrolled: []},
    {id: 10, name: 'Bones', enrolled: []}
]
let cohorts = [
    {id: 1, className: 'Agility', enrolled: []},
    {id: 2, className: 'Behavior', enrolled: []},
    {id: 3, className: 'Advanced Jumping', enrolled: []},
    {id: 4, className: 'Service Dog Training', enrolled: []}
]
let enrolled = [
    {id: 1, startDate: 'Jan 30, 2023'},
    {id: 2, startDate: 'Feb 5, 2023'},
    {id: 3, startDate: 'Feb 20, 2023'},
    {id: 4, startDate: 'Feb 17, 2023'}
]

module.exports = {petTrainingOwner, users, owners, trainers, pets, cohorts, enrolled}