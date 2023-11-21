WITH all_pairs as(
  SELECT product_id, 0 as category_id
  FROM product
  WHERE product_id NOT IN (select product_id from product_category)
  UNION
  SELECT * FROM product_category
)
select name_product, name_category FROM all_pairs
LEFT JOIN product USING (product_id)
LEFT JOIN category USING (category_id)