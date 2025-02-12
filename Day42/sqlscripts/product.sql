
--This is a comment
/*
create product table

*/
/*DDL*/
create table Product(
id int primary key identity (1,1),
name varchar (100),
quantity int,
price money
)

/*DDL*/
select * from product

--DML
insert into Product(name,quantity,price)
           values('Mobile',10,1000);

insert into Product(name,quantity,price)
values('Laptop',5,50000);

--update

declare @newQuanity int
set @newQuanity=20

update product
set quantity = @newQuanity
where id =3


select * from Product 
where name='Tablet'

delete product where id=3

