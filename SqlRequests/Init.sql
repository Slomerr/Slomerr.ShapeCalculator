create table product(
  product_id SERIAL PRIMARY KEY,
  name_product TEXT NOT NULL
  );
  
 Create TAble category(
   category_id SERIAL PRIMARY KEY,
   name_category TEXT NoT NULL
   );
   
  Create TABLE product_category(
    product_id INTEGER REFERENCES product,
    category_id INTEGER REFERENCES category
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
  