select * from user left join owner on user.id = owner.user_id; 
-- left join all users those with matching info on other table will have that others will be empty
select * from user join owner on user.id = owner.user_id;
-- join will only return what matches 
select * from user join owner on user.id = owner.user_id join pet on owner.id = pet.owner_id where user.id = 3;

select * from user left join owner on user.id = owner.user_id left join pet on owner.id = pet.owner_id;

select * from user join trainer on user.id = trainer.user_id join cohort on trainer.id = cohort.trainer_id join enrolled on cohort.id = enrolled.cohort_id where trainer.id = 1;


select * from user 
join trainer on user.id = trainer.user_id 
join cohort on trainer.id = cohort.trainer_id 
join enrolled on cohort.id = enrolled.cohort_id 
join pet on enrolled.pet_id = pet.id 
join owner on pet.owner_id = owner.id 
where trainer.id = 1;

select * from user 
left join trainer on user.id = trainer.user_id 
left join cohort on trainer.id = cohort.trainer_id 
left join enrolled on cohort.id = enrolled.cohort_id 
left join pet on enrolled.pet_id = pet.id 
left join owner on pet.owner_id = owner.id;

select * from user
left join owner on user.id = owner.user_id
left join pet on owner.id = pet.owner_id
left join enrolled on pet.id = enrolled.pet_id
left join cohort on enrolled.cohort_id = cohort.id
left join trainer on cohort.trainer_id = trainer.id;

select * from user where lastName='Doe';