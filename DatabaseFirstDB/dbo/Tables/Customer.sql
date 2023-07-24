CREATE TABLE [dbo].[Customer] (
    [CustomerId]     INT          IDENTITY (1, 1) NOT NULL,
    [CustomerName]   VARCHAR (50) NULL,
    [CustomerAmount] FLOAT (53)   NULL,
    [City]           VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

