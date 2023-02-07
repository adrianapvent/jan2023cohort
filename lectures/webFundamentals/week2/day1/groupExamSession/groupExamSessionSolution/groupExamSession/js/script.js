console.log('Wired up')

function changeImg(element) {
    // console.log('activated mouse event')
    // console.log(element.alt)
    if(element.alt == "Breezee") {
        // console.log('if triggered')
        element.src = "./images/yankeeBoy.png"
        element.alt = "Yankee Boy"
    }
}
function changeBack(element) {
    // console.log('new event')
    // console.log(element.alt)
    if (element.alt == "Yankee Boy") {
        // console.log('new if triggered')
        element.src = "./images/breezee.png"
        element.alt = "Breezee"
    }
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
    document.getElementById('sale').style.display = 'none'
    let price = document.getElementsByClassName('price')
    for(let i = 0; i < price.length; i++) {
        let newPrice = parseInt(price[i].innerText)
        // console.log(newPrice, typeof(price))
        newPrice = newPrice * .8
        price[i].textContent = newPrice
    }
}