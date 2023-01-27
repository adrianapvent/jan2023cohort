// Class - Developer vs Website

// Class names
// Constructor Function
// Attributes = describe variables/key of an objects
// Methods = do the functions
// Create Instances/objects and use them

class Developer {
    constructor(name, email) {
        this.name = name
        this.skill = []
        this.email = email
        this.sites = []
    } 
    printNewDev() {
        console.log(`Our Newest Developer is: ${this.name} and their email is: ${this.email}`)
                                            // dev[0].name                      dev[0].email
        return this
    }
    addSkill(s) {
        this.skill.push(s)
        // this.skill - the skill array in constructor .push(s) = add what ever we declared s as to the skill array
        console.log(`${this.name} has just learned the skill of: ${s}`)
        for(let i = 0; i < this.skill.length; i++) {
            console.log(`${this.name}'s #${i+1} skill: ${this.skill[i]}`)
        }
        return this
        // return whole developer object
    }
    printSkills() {
        console.log(this.skill)
    }
    newSite(site) {
        this.sites.push(site)
        console.log(this.name)
    }
}

class Website {
    constructor(siteName, dev) {
        this.siteName = siteName
        this.dev = dev
        this.url = ''
        this.front = ''
        this.back = ''
    }
    printSite() {
        console.log(this.siteName, this.dev.name)
    }
}

class Users{
    constructor(firstName, lastName) {
        this.firstName = firstName
        this.lastName = lastName
    }

}
let theUsers = []
let jane = new Users("Jane", "Doe")
let bob = new Users("Bob", "Ross")
theUsers.push(jane)
theUsers.push(bob)
console.log(theUsers)
for(let i=0; i<theUsers.length;i++){
    console.log(theUsers[i])
}


// Creating Developers
let kaitlynn = new Developer('Kaitlynn', 'kaitlynn@email.com')
// kaitlynn = a Developer Class object
let helper = new Website("Helper Site", kaitlynn)
// helper = siteName all of kaitlynn's info
// dev[0]
// kaitlynn.printSkills()
// kaitlynn.printNewDev()
// // function printNewDev(kaitlynn)
// kaitlynn.addSkill('JavaScript').addSkill('MySQL')
// kaitlynn.printSkills()
// kaitlynn.newSite("Helper Site", kaitlynn)
helper.printSite()
