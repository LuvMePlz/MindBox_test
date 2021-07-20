create table Product (
id serial primary key, 
name varchar(50) );

create table Category(
id serial primary key,
name varchar(50));

create table ProductCategory(
productId int,  
categoryId int, 
constraint fkProductId foreign key(productId) references Product(id),
constraint fkCategoryId foreign key(categoryId) references Category(id),
primary key (productId, categoryId)
);			
			 
insert into Product(name)
values('product1'), ('product2'),('product3'),('product4'), ('product5'), ('product6'),('product7'),('product8');
insert into Category(name)
values('category1'), ('category2'),('category3'),('category4'), ('category5'), ('category6'),('category7'),('category8');
insert into ProductCategory(productId, categoryId)
values(1,1), (1,2), (2,3), (3,1), (5,1), (5,2), (6,3);

select p.name, c.name
from product p
left join productcategory pc ON pc.productid = p.id
left join category c ON c.id = pc.categoryid
order by p.id
