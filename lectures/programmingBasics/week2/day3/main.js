const {meals} = require('../data/meals')
const {petTrainingOwner, users, owners, trainers, pets, cohorts, enrolled} = require('../data/petTraining')
// console.log('whole data set:',petTrainingOwner)
let oneOwner = petTrainingOwner[0].owners[0]
// console.log('one owner:', oneOwner)
let onePet = oneOwner.pets[0]
// console.log('one pet:', onePet)
let oneEnroll = onePet.enrolled[0]
// console.log('one enrollment:', oneEnroll)
let oneCohort = oneEnroll.cohorts[0]
console.log('one class instance:', oneCohort)
