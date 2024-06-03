-- ################
-- Drop Tables
-- ################
DROP TABLE IF EXISTS Savings;
DROP TABLE IF EXISTS Investment;
DROP TABLE IF EXISTS Credit_Card;
DROP TABLE IF EXISTS Loan;
DROP TABLE IF EXISTS Accounts;

-- ################
-- Create Tables
-- ################
CREATE TABLE Accounts (
	account_id int UNIQUE NOT NULL AUTO_INCREMENT,
	name varchar(255) UNIQUE NOT NULL,
	value double(10, 2) NOT NULL,
	PRIMARY KEY (account_id)
);

CREATE TABLE Savings (
	savings_id int UNIQUE NOT NULL PRIMARY KEY,
	interest_rates double(4, 2) NOT NULL,
	FOREIGN KEY (savings_id) REFERENCES Accounts(account_id) ON DELETE CASCADE
);

CREATE TABLE Investment (
	investment_id int UNIQUE NOT NULL PRIMARY KEY,
	account_type varchar(255) UNIQUE NOT NULL,
	isRetirement bool NOT NULL,
	FOREIGN KEY (investment_id) REFERENCES Accounts(account_id) ON DELETE CASCADE
);

CREATE TABLE Credit_Card (
	credit_card_id int UNIQUE NOT NULL PRIMARY KEY,
	statement_balance double(10, 2) NOT NULL,
	due_date date NOT NULL,
	FOREIGN KEY (credit_card_id) REFERENCES Accounts(account_id) ON DELETE CASCADE
);

CREATE TABLE Loan (
	loan_id int UNIQUE NOT NULL PRIMARY KEY,
	interest_rates double(4, 2) NOT NULL,
	minimum_payment double(10, 2) NOT NULL,
	due_date date NOT NULL,
	FOREIGN KEY (loan_id) REFERENCES Accounts(account_id) ON DELETE CASCADE
);

-- ################
-- Insert Temp Data
-- ################

-- Insert Accounts Data
INSERT INTO Accounts (name, value)
VALUES ('Chase Checking', 4000),
('VIO HYSA', 6000);

-- Insert Savings Data
INSERT INTO Savings (savings_id, interest_rates)
VALUES (2, 5);