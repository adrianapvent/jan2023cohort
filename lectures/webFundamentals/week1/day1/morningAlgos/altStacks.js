
class Stack{
    constructor(){
        this.count=0
        this.storage={}
    }

    push(value){
        this.storage[this.count] = value
        this.count++
    }
    peek(){
        return this.storage[this.count-1]
    }
    newPeek(num) {
        console.log(this.storage[num])
    }
    
}

let theTrunk = new Stack()
let kaitlynnsTrunk = new Stack()

theTrunk.push('Antique Dress')
theTrunk.push('Coding Books')
theTrunk.push([1,2,3,4])
theTrunk.peek()
theTrunk.newPeek(1)

kaitlynnsTrunk.push("Coding Books")
kaitlynnsTrunk.peek()