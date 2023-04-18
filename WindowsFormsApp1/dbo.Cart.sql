CREATE TABLE [dbo].[Cart] (
    [ProductId]    INT           NOT NULL,
    [ProductName]  NVARCHAR (50) NOT NULL,
    [ProductPrice] MONEY         NOT NULL,
    [ProductImage] NVARCHAR(200)         NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

