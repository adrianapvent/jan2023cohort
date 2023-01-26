SELECT * FROM user;
insert into user (firstName, lastName) values ('Jane', 'Doe'), ('Bob', 'Ross');

SELECT * FROM owner;
insert into owner (firstName, lastName, user_id) values ('Jane', 'Doe', 1);

SELECT * FROM info;
insert into info (phone, city, owner_id) values ('555-555-5555', 'NoWhere', 1);

SELECT * FROM pet;
insert into pet (petName, petSpecies, owner_id) values ('Sparky', 'Dog', 1), ('Purrl', 'Cat', 1);

SELECT * FROM blogpost;
insert into blogpost (post, owner_id) values ('Test', 1), ('Testing', 1);

SELECT * FROM replies;
insert into replies (reply, blogPost_id, user_id) values ('Hi',1, 2),('Hello there Bob', 1, 1),('How are you Jane?', 1, 2),('I am not sure about this', 2, 2);