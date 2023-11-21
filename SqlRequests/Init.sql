CREATE TABLE product(
    product_id INT PRIMARY KEY IDENTITY(1,1),
    name_product VARCHAR(50) NOT NULL
);

CREATE TABLE category(
    category_id INT PRIMARY KEY IDENTITY(1,1),
    name_category VARCHAR(50) NOT NULL
);

CREATE TABLE product_category(
    product_id INT REFERENCES product,
    category_id INT REFERENCES category
);

INSERT INTO product (name_product) VALUES
    ('product_a'),
    ('product_b'),
    ('product_c'),
    ('product_d'),
    ('product_e');

INSERT INTO category (name_category) VALUES
    ('category_a'),
    ('category_b'),
    ('category_c'),
    ('category_d'),
    ('category_e');

INSERT INTO product_category (product_id, category_id) VALUES
    (1, 1),
    (1, 3),
    (1, 4),
    (2, 3),
    (2, 5),
    (3, 2),
    (5, 1),
    (5, 5);
