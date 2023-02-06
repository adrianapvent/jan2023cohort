console.log('Wired up')

function changeImg(element) {
    // console.log('activated mouse event')
}
function changeBack(element) {
    // console.log('new event')
}
let count = 0;
function addToCart(element) {
    console.log('button clicked')
    // let count = 0;
    if (count === 0) {
        count++
        // console.log('if triggered', count)
    } else {
        count++
        // console.log('else triggered', count)
    }
    document.getElementById('cart').innerText = count
}

function salePrices(element) {
    // console.log('button click')
    document.getElementById('sale')

}