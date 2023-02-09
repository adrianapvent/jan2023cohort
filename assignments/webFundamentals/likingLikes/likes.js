let count = 3;
function like(element) {
	console.log('this was clicked');
	if (count === 0) {
		count++;
	} else {
		count++;
	}
	document.getElementById('num').innerText = count;
}
