
-- DO NOT USE THIS TO SEED YOUR DATA BASE AS THERE WERE EXTRA ENTRIES THAT WERE THEN DELETED THAT WILL NOT SHOW IN THIS FILE... IF THERE IS AN ENTRY BELOW WITH AN ID CHECK THE ID THAT IS IN YOUR DATA BASE AS THESE REFLECTED THE LIVE LECTURE

-- Our 1st table is user, so we added 4 users
SELECT * FROM user;
insert into user (firstName, lastName) values 
('Jane', 'Doe'),
('Bob', 'Ross'), 
('Frodo', 'Baggins'), 
('James', 'Kirk'); 

-- Next we chose whichs users were owners and while creating their owner objects connected it to their user object
SELECT * FROM owner;
insert into owner (firstName, lastName, user_id) values 
('Jane', 'Doe', 1),
('Frodo', 'Baggins', 3);

-- used 1st lightening bolt and ended up adding owners twice so needed to delete
delete from owner where id=3;
delete from owner where id=4;

-- Next we created our pet objects and connected them to their owners
SELECT * FROM pet;
insert into pet (petName, species, owner_id) values ('Cicilly', 'Dog', 2), ('Bill', 'Horse', 2), ('Zebra', 'Cat', 1), ('Clifford', 'Dog',2);

insert into owner (firstName, lastName, user_id) values ('James', 'Kirk', 4);

update pet set owner_id=5 where id=4;

SELECT * FROM trainer;
insert into trainer (firstName, lastName, user_id) values ('Bob', 'Ross', 2), ('James', 'Kirk', 4); 

SELECT * FROM cohort;
insert into cohort (className, skill, trainer_id) values ('Jumping', 'Jumping', 1), ('Rolling Over', 'Rolling Over', 2);

SELECT * FROM enrolled;
insert into enrolled (pet_id, cohort_id, startDate) values (2,1, 'Jan 30th, 2023'), (2,2,'Feb 17th, 2023'), (3,2,'Feb 17th, 2023'), (1,1,'Mar 5th, 2023');

insert into user (firstName, lastName) values ('John', 'Doe');
insert into user (firstName, lastName) values ('Jill', 'Smith');

insert into owner (firstName, lastName, user_id) values ('John', 'Doe', 5);
delete from owner where id=7;
insert into trainer (firstName, lastName, user_id) values ('Jill', 'Smith', 6);