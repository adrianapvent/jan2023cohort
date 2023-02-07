let playing = true;
let count = 4

while(playing) {
    if( count === 0) {
        console.log(count)
        console.log('Exiting code')
        playing = false
    }
    if( count > 0) {
        console.log(count)
        count--
        console.log('new count', count)
    }
}