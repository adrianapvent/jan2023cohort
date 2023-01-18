var cities = ['Birmingham', 'Austin', 'Seattle', 'Orlando'];

for (var i = 0; i < cities.length; i++) {
	console.log('4th loop is 1st conditional', cities[i]);

	if (cities[i] == 'Austin') {
		console.log('Welcome to Texas');
	} else if (cities[i] == 'Seattle') {
		console.log('Get ready for the rain');
	} else {
		console.log('You have left the great state of Texas');
	}
}
