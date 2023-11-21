WITH all_pairs AS (
    SELECT product_id, 0 AS category_id
    FROM product
    WHERE product_id NOT IN (SELECT product_id FROM product_category)
    UNION
    SELECT * FROM product_category
)
SELECT name_product, name_category FROM all_pairs
LEFT JOIN product ON all_pairs.product_id = product.product_id
LEFT JOIN category ON all_pairs.category_id = category.category_id