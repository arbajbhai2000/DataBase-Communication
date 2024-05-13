 create database arbajadonetdb

use arbajadonetdb

create table trainer
(
id int primary key identity,
name varchar(50),
city varchar(50),
experience int
)

insert into trainer values('vikul','pune',14),('usha','pune',3)
go

select * from trainer


select * from trainer where id=1