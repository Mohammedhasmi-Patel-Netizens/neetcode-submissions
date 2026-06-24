-- Write your query below


SELECT name from customers where id not in (SELECT customers.id FROM customers
join orders ON customers.id = orders.customer_id);