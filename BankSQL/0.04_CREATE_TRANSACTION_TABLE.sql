CREATE TABLE dbo.Transactions
	(TransactionID INT NOT NULL, 
	 AccountID INT NOT NULL,	  
	 AcctBal int NOT NULL,	 
	 WithdrawlAmt int NULL, 
	 DepositAmt int NULL,

	 CONSTRAINT [PK_dbo.Transactions] PRIMARY KEY CLUSTERED ([TransactionID] ASC),
	 CONSTRAINT [FK_dbo.Transactions_dbo.Account_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [dbo].[Account]([AccountID]) ON DELETE CASCADE
	 );

	 GO