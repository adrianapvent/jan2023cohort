// npm install mysql

var mysql = require('mysql');

var con = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "HoneyBee#4",
  database: "farmFive"
});

// con.connect(function(err) {
//   if (err) throw err;
//   console.log("Connected!");
// });
let data = []

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
    // var sql = "select * from animal left join farm_has_animal on animal.id=farm_has_animal.animal_id left join farm on farm_has_animal.farm_id=farm.id;";
    var sql = "select * from farm left join farm_has_animal on farm.id=farm_has_animal.farm_id left join animal on farm_has_animal.animal_id=animal.id;"
    con.query(sql, function (err, result, fields) {
      if (err) throw err;
      console.log(result);
      data = result
      return data
    });
  });
  console.log('index 1:', data[0])