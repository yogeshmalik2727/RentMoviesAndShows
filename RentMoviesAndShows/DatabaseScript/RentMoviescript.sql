USE [master]

go
CREATE DATABASE [rentmovies]

go
USE [rentmovies]

GO
/****** Object:  User [ma]    Script Date: 25-09-2020 12.51.23 PM ******/
CREATE USER [ma] FOR LOGIN [ma] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ma]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[Mobile] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(101,1) NOT NULL,
	[MovieTitle] [varchar](500) NOT NULL,
	[Year] [varchar](25) NOT NULL,
	[RentCost] [int] NOT NULL,
	[Genre] [varchar](50) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK__Movies__4BD2943A1822B2E1] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoviesOnRent]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoviesOnRent](
	[RentId] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[RentDate] [varchar](150) NOT NULL,
	[ReturnDate] [varchar](150) NOT NULL,
	[RentAmount] [int] NOT NULL,
 CONSTRAINT [PK__MoviesOn__783D47F5EBAE83E2] PRIMARY KEY CLUSTERED 
(
	[RentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [Address], [Mobile]) VALUES (1, N'sukhpal', N'auckland', 98960)
INSERT [dbo].[Customer] ([CustomerID], [Name], [Address], [Mobile]) VALUES (2, N'mankirt', N'california', 458569)
INSERT [dbo].[Customer] ([CustomerID], [Name], [Address], [Mobile]) VALUES (3, N'Yogesh Malik', N'willington', 7847854)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [Year], [RentCost], [Genre], [Rating]) VALUES (101, N'Enola Holmes', N'2020', 5, N'mystery', 9)
INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [Year], [RentCost], [Genre], [Rating]) VALUES (102, N'love guranteed', N'2020', 5, N'romatic', 8)
INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [Year], [RentCost], [Genre], [Rating]) VALUES (103, N'harry potter', N'1996', 2, N'fiction', 8)
INSERT [dbo].[Movies] ([MovieID], [MovieTitle], [Year], [RentCost], [Genre], [Rating]) VALUES (104, N'Home alone', N'2002', 2, N'comedy', 6)
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[MoviesOnRent] ON 

INSERT [dbo].[MoviesOnRent] ([RentId], [MovieID], [CustomerID], [RentDate], [ReturnDate], [RentAmount]) VALUES (3, 101, 3, N'25-09-2020', N'27-09-2020', 10)
INSERT [dbo].[MoviesOnRent] ([RentId], [MovieID], [CustomerID], [RentDate], [ReturnDate], [RentAmount]) VALUES (4, 102, 3, N'25-09-2020', N'29-09-2020', 20)
INSERT [dbo].[MoviesOnRent] ([RentId], [MovieID], [CustomerID], [RentDate], [ReturnDate], [RentAmount]) VALUES (6, 102, 1, N'25-09-2020', N'30-09-2020', 25)
SET IDENTITY_INSERT [dbo].[MoviesOnRent] OFF
GO
/****** Object:  Index [UQ__Customer__6FAE0782A842D07F]    Script Date: 25-09-2020 12.51.23 PM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Mobile] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Movies__6757B639060A8F6D]    Script Date: 25-09-2020 12.51.23 PM ******/
ALTER TABLE [dbo].[Movies] ADD  CONSTRAINT [UQ__Movies__6757B639060A8F6D] UNIQUE NONCLUSTERED 
(
	[MovieTitle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MoviesOnRent]  WITH CHECK ADD  CONSTRAINT [FK__MoviesOnR__Custo__412EB0B6] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[MoviesOnRent] CHECK CONSTRAINT [FK__MoviesOnR__Custo__412EB0B6]
GO
ALTER TABLE [dbo].[MoviesOnRent]  WITH CHECK ADD  CONSTRAINT [FK__MoviesOnR__Movie__403A8C7D] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[MoviesOnRent] CHECK CONSTRAINT [FK__MoviesOnR__Movie__403A8C7D]
GO
/****** Object:  StoredProcedure [dbo].[sp_cUpdateMovieOrShow]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[sp_cUpdateMovieOrShow](@title varchar(500),@year varchar(25),@rating float,
  @genre varchar(50),@rentcost int,@movieId int)
  as
  update movies set MovieTitle=@title,year=@year,Rating=@rating,
  genre=@genre,RentCost=@rentcost where movieId=@movieId
GO
/****** Object:  StoredProcedure [dbo].[sp_CustomerBorrowMostMovies]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[sp_CustomerBorrowMostMovies]
	as
	SELECT 
    rm.CustomerID,
	name as CustomerName,
    COUNT(*) occurrences
FROM MoviesOnRent rm join customer cc on cc.CustomerID = rm.CustomerID
GROUP BY
    rm.CustomerID, name
  
HAVING 
    COUNT(*) >1;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCustomer]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[sp_InsertCustomer](@Name varchar(50),@Address varchar(max),@Mobile bigint)
  as  insert into customer(Name,Address,Mobile) values(@Name,@Address,@Mobile)
GO
/****** Object:  StoredProcedure [dbo].[sp_MostPopularMovies]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[sp_MostPopularMovies]
 as
SELECT 
    rm.MovieID,MovieTitle, COUNT(*) occurrences
FROM MoviesOnRent rm join movies m on m.movieid = rm.movieid
GROUP BY
    rm.MovieID, MovieTitle
  
HAVING 
    COUNT(*) >1;
GO
/****** Object:  StoredProcedure [dbo].[sp_RentMovieShows]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_RentMovieShows](@MovieID int,@CustID int,@RentDate varchar(100), @ReturnDate varchar(100),@TotalRent int)
  as
  insert into MoviesOnRent values(@MovieID,@CustID,@RentDate,@ReturnDate,@TotalRent)
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowRentedMovies]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ShowRentedMovies]
  as
  select RentId, name as CustomerName, Address, MovieTitle,
  RentDate,ReturnDate,RentAmount from MoviesOnRent rm 
  join Customer c on c.CustomerID = rm.CustomerID join Movies m on m.MovieID= rm.MovieID
  order by RentDate desc
GO
/****** Object:  StoredProcedure [dbo].[spInsertMovie]    Script Date: 25-09-2020 12.51.23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spInsertMovie](@title varchar(500),@year varchar(25),@rating float,
  @genre varchar(50),@rentcost int)
  as
  insert into movies values(@Title,@Year,@RentCost,@Genre,@Rating)
GO
USE [master]
GO
ALTER DATABASE [rentmovies] SET  READ_WRITE 
GO
