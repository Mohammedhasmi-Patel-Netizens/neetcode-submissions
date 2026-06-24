SELECT c.customer_id, c.customer_name
FROM customers c
JOIN orders o ON c.customer_id = o.customer_id
WHERE o.product_name IN ('A', 'B')
GROUP BY c.customer_id, c.customer_name
HAVING COUNT(DISTINCT o.product_name) = 2 -- Ensures they bought both A and B

-- Exclude any customer who has an order for product C
AND c.customer_id NOT IN (
    SELECT customer_id 
    FROM orders 
    WHERE product_name = 'C'
)
ORDER BY c.customer_name;