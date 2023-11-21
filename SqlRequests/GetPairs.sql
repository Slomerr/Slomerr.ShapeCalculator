select name_product, 
    name_category 
    from product
left join product_category 
    on product.product_id = product_category.product_id
left join category 
    on product_category.category_id = category.category_id