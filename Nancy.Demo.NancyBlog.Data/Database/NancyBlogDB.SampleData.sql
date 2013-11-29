USE [NancyBlogDB]
GO

INSERT INTO [dbo].[Blogs]
           ([Name])
     VALUES
           ('Nosfheratu´s quotes')
GO

INSERT INTO [dbo].[Authors]
           ([FullName]
           ,[Email]
           ,[Bio])
     VALUES
           ('Fernando Serapio'
           ,'fhernandosc@gmail.com'
           ,'Under construccion...')
GO

INSERT INTO [dbo].[Posts]
           ([Title]
           ,[Body]
           ,[BlogId]
           ,[AuthorId])
     VALUES
           ('Hello World!'
           ,'Welcome to my new stupid blog...'
           ,1
           ,1)
GO

INSERT INTO [dbo].[Posts]
           ([Title]
           ,[Body]
           ,[BlogId]
           ,[AuthorId])
     VALUES
           ('Hello World!'
           ,'Welcome to my new stupid blog...'
           ,1
           ,1)
GO

INSERT INTO [dbo].[Comments]
           ([Body]
           ,[PostId]
           ,[Author])
     VALUES
           ('Awesome! This gonna be great!'
           ,1
           ,'Nosfheratu')
GO

INSERT INTO [dbo].[Comments]
           ([Body]
           ,[PostId]
           ,[Author])
     VALUES
           ('Awesome! This gonna be great!'
           ,1
           ,'Nosfheratu')
GO

INSERT INTO [dbo].[Comments]
           ([Body]
           ,[PostId]
           ,[Author])
     VALUES
           ('Awesome! This gonna be great!'
           ,2
           ,'Nosfheratu')
GO

INSERT INTO [dbo].[Comments]
           ([Body]
           ,[PostId]
           ,[Author])
     VALUES
           ('Awesome! This gonna be great!'
           ,2
           ,'Nosfheratu')
GO

SELECT * FROM [dbo].[Blogs]
GO
SELECT * FROM [dbo].[Authors]
GO
SELECT * FROM [dbo].[Posts]
GO
SELECT * FROM [dbo].[Comments]
GO