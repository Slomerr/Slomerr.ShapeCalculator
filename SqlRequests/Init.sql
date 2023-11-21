create table product(
    product_id int primary key  identity(1,1),
    name_product varchar(50) not null
);

create table category(
    category_id int primary key identity(1,1),
    name_category varchar(50) not null
);

create table product_category(
    product_id int references product,
    category_id int references category
);

insert into product (name_product) values
    ('product_a'),
    ('product_b'),
    ('product_c'),
    ('product_d'),
    ('product_e');

insert into category (name_category) values
    ('category_a'),
    ('category_b'),
    ('category_c'),
    ('category_d'),
    ('category_e');

insert into product_category (product_id, category_id) values
    (1, 1),
    (1, 3),
    (1, 4),
    (2, 3),
    (2, 5),
    (3, 2),
    (5, 1),
    (5, 5);
