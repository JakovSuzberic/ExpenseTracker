
CREATE TABLE "Users" (

  user_id int not null primary key identity(1,1),
  name varchar(50) not null,
  password varchar(50) not  null,
  email varchar(50),
  created_at datetime

);

CREATE TABLE Categorys (

  category_id int not null primary key identity(1,1),
  name varchar(50) not null,
  description varchar(100)

);

CREATE TABLE Payment_methods (

  payment_method_id int not null primary key identity(1,1),
  name varchar(50)

);

CREATE TABLE Budgets (

  budget_id int not null primary key identity(1,1),
  amount float,
  start_date datetime,
  end_date datetime,
  user_id int not null, 
  category_id int not null,

  FOREIGN KEY (user_id) REFERENCES "Users"(user_id),
  FOREIGN KEY (category_id) REFERENCES Categorys(category_id)

);

--Jos jedan nacin kako dodati FOREIGN KEY-eve

--ALTER TABLE Budgets ADD FOREIGN KEY (user_id) REFERENCES "Users"(user_id);
--ALTER TABLE Budgets ADD FOREIGN KEY (category_id) REFERENCES Categorys(category_id);


CREATE TABLE Expenses (

  expense_id int  not null primary key identity(1,1),
  user_id int not null,
  category_id int not null,
  payment_method_id int not null,
  amount float,
  date datetime,
  description varchar(255),

  FOREIGN KEY (user_id) REFERENCES "Users"(user_id),
  FOREIGN KEY (category_id) REFERENCES Categorys(category_id),
  FOREIGN KEY (payment_method_id) REFERENCES Payment_methods(payment_method_id)

);


INSERT INTO Users(name,email,password,created_at) VALUES
('Jakov Šužberić', 'jakov.suzberic@gmail.com', 'sifrajedan', '2024-06-06 16:00'),
('Lovro Šužberić', 'loky747@gmail.com', 'sifradva', '2024-06-06 16:10'),
('Mato Matić', 'mato123@gmail.com', 'sifraxy', '2024-06-07 01:10');

INSERT INTO Categorys(name,description) VALUES
('Food','Monthly groceries expenses'),
('Gym','Monthly gym membership and supplements'),
('Rent','Monthly rent');

INSERT INTO Payment_methods(name) VALUES
('Card'),
('Cash'),
('Cupons');

INSERT INTO Budgets(amount,start_date,end_date,user_id,category_id) VALUES
(25.55, '2024-06-06 00:00','2024-07-06 00:00',1,1),
(39.99, '2024-06-06 00:00','2024-07-06 00:00',2,2),
(14.99, '2024-06-06 00:00','2024-07-06 00:00',3,3);

INSERT INTO Expenses(amount, date, description,user_id,category_id,payment_method_id) VALUES
(25.55, '2024-06-06 00:00','Gym',1,1,1),
(39.99, '2024-06-06 00:00','Starbucks',2,2,2),
(14.99, '2024-06-06 00:00','Groceries',3,3,3);

SELECT * FROM Users;
SELECT * FROM Payment_methods;
SELECT * FROM Expenses;
SELECT * FROM Categorys;
SELECT * FROM Budgets;

