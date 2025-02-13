CREATE TABLE BankAccount (
    accountID INT PRIMARY KEY,
    accountHolderName VARCHAR(255),
    balance DECIMAL(10, 2)
);

CREATE TABLE BankTransaction (
    transactionID INT PRIMARY KEY,
    accountID INT, 
    transactionDate DATETIME,
    amount DECIMAL(10, 2),
    transactionType VARCHAR(50),
    FOREIGN KEY (accountID) REFERENCES BankAccount(accountID)
);
