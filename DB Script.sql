CREATE DATABASE ExampleDB;

USE ExampleDB;

CREATE TABLE Products (
    id INT NOT NULL ,
    name VARCHAR(255) NOT NULL,
    description VARCHAR(255) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE Users (
    id INT NOT NULL ,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);



USE ExampleDB;

-- Insert dummy data into the Products table
USE ExampleDB;

-- Insert dummy data into the products table
INSERT INTO products (id, name, description, price) VALUES
    (1, 'Product A', 'This is product A', 19.99),
    (2, 'Product B', 'This is product B', 29.99),
    (3, 'Product C', 'This is product C', 39.99),
    (4, 'Product D', 'This is product D', 49.99),
    (5, 'Product E', 'This is product E', 59.99);

-- Insert dummy data into the users table
INSERT INTO users (id, username, password, email) VALUES
    (1, 'john_doe', 'password123', 'john.doe@example.com'),
    (2, 'jane_smith', 'password456', 'jane.smith@example.com'),
    (3, 'bob_jones', 'password789', 'bob.jones@example.com');

