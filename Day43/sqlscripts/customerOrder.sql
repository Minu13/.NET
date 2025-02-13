create table Customer(
id int primary key identity (1,1),
name varchar (20) not null,
location varchar(50)
)

create table [order](
id int primary key identity(1,1),
title varchar (20) not null,
cost money not null,
customer_id int references Customer(id)
)