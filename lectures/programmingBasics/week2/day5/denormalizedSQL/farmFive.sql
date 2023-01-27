SELECT * FROM farm;
insert into farm (farmName) values ('Beech Ranch');
insert into farm (farmName) values ('Morton Farms');
insert into farm (farmName) values ('Beech Ranch');


SELECT * FROM animal;
insert into animal (animalType) values ('pig');
insert into animal (animalType) values ('chickens');
insert into animal (animalType) values ('goat');
insert into animal (animalType) values ('horses');



SELECT * FROM farm_has_animal;
insert into farm_has_animal (farm_id, animal_id, count) values (1,1, 6);
insert into farm_has_animal (farm_id, animal_id, count) values (1,2, 10);
insert into farm_has_animal (farm_id, animal_id, count) values (1,3, 3);
insert into farm_has_animal (farm_id, animal_id, count) values (2,4, 4);
insert into farm_has_animal (farm_id, animal_id, count) values (3,4, 7);
delete from farm_has_animal where id=2; -- added the pig twice


select * from farm 
left join farm_has_animal on farm.id=farm_has_animal.farm_id 
left join animal on farm_has_animal.animal_id=animal.id 
where farm.id=1;
select * from animal 
left join farm_has_animal on animal.id=farm_has_animal.animal_id
left join farm on farm_has_animal.farm_id=farm.id where animal.animalType='horses';
-- what is the one start with that join the many after (if more than one following table follow the lines
-- table1 join table2 on table1.id=table2._id
