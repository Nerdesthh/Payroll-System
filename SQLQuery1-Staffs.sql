CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY (1,1),
	staff_id VARCHAR(MAX) NULL,
	full_name VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NULL,
	department VARCHAR(MAX) null,
	gender VARCHAR(MAX) NULL,
	phone_number VARCHAR(MAX) NULL,
	insert_date DATE NULL,
	update_date DATE NULL,
	delete_date DATE NULL,
)

SELECT * FROM users

alter table users
ADD email VARCHAR(MAX) null

SELECT * FROM users WHERE delete_date IS NULL
DELETE FROM users