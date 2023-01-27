SELECT * FROM farm;
insert into farm (farmName, annRev) values ('Beech Ranch', 65000);
insert into farm (farmName, annRev) values ('Morton Farms', 45000);
insert into farm (farmName, annRev) values ('Beech Ranch', 75000);


SELECT * FROM animals;
insert into animals (animal, farm_id) values ('pig', 1);
insert into animals (animal, farm_id) values ('chickens', 1);
insert into animals (animal, farm_id) values ('goat', 1);
insert into animals (animal, farm_id) values ('horses', 2);
insert into animals (animal, farm_id) values ('horses', 3);


select * from animals left join farm on animals.farm_id = farm.id where animals.animal = 'horses';
select * from farm where annRev=65000;
select * from farm where annRev=45000;