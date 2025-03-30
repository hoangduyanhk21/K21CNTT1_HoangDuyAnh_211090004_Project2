USE NeoDurianDB_HoangDuyAnh;
GO
IF OBJECT_ID('dbo.NeoDurianItems_HoangDuyAnh', 'U') IS NOT NULL
    DROP TABLE dbo.NeoDurianItems_HoangDuyAnh;
GO
CREATE TABLE NeoDurianItems_HoangDuyAnh (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Description NVARCHAR(250) NULL
);
GO
