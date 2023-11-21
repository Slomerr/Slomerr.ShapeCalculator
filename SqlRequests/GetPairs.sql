SELECT name_product, name_category FROM product
LEFT JOIN product_category ON product.product_id = product_category.product_id
LEFT JOIN category ON product_category.category_id = category.category_id