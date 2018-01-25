CREATE TABLE dbo.Account
	(AccountID INT NOT NULL,
	 CustomerID int NOT NULL,
	 LastName varchar(25) NOT NULL, 
	 FirstName varchar(25) NOT NULL,  
	 PinNum int NOT NULL, 
	 AcctNum int NOT NULL,
	 AcctType text NOT NULL,
	 AcctBal int NOT NULL, 
	 DateOpened DATETIME NOT NULL,

	 CONSTRAINT [PK_dbo.Account] PRIMARY KEY CLUSTERED ([AccountID] ASC),
	 CONSTRAINT [FK_dbo.Account_dbo.Customer_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer]([CustomerID]) ON DELETE CASCADE
	 );

	 GO






	 



