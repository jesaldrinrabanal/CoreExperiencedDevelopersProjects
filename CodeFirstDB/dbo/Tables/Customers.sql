CREATE TABLE [dbo].[Customers] (
    [CustomerId]     INT            IDENTITY (1, 1) NOT NULL,
    [CustomerName]   NVARCHAR (MAX) NOT NULL,
    [CustomerAmount] FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

