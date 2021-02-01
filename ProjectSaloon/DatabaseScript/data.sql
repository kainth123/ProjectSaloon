SET IDENTITY_INSERT [dbo].[Saloon] ON
INSERT INTO [dbo].[Saloon] ([SaloonID], [SaloonName], [SaloonAddress], [Contact_Number]) VALUES (1, N'Kess', N'centre place, Hamilton', 223435671)
INSERT INTO [dbo].[Saloon] ([SaloonID], [SaloonName], [SaloonAddress], [Contact_Number]) VALUES (2, N'Kess', N'Auckland', 223456787)
INSERT INTO [dbo].[Saloon] ([SaloonID], [SaloonName], [SaloonAddress], [Contact_Number]) VALUES (3, N'Kess', N'wellington', 223132145)
INSERT INTO [dbo].[Saloon] ([SaloonID], [SaloonName], [SaloonAddress], [Contact_Number]) VALUES (4, N'Kess', N'Tauranga', 277665434)
INSERT INTO [dbo].[Saloon] ([SaloonID], [SaloonName], [SaloonAddress], [Contact_Number]) VALUES (5, N'Kess', N'chartwell, Hamilton', 223454321)
SET IDENTITY_INSERT [dbo].[Saloon] OFF
SET IDENTITY_INSERT [dbo].[Beautician] ON
INSERT INTO [dbo].[Beautician] ([BeauticianID], [BeauticianName], [ContactNumber], [JoiningDate], [Salary], [SaloonID]) VALUES (1, N'Monika', 998787688, N'2014-11-02 00:00:00', 1200, 1)
INSERT INTO [dbo].[Beautician] ([BeauticianID], [BeauticianName], [ContactNumber], [JoiningDate], [Salary], [SaloonID]) VALUES (2, N'Aman Kaur', 992313434, N'2015-10-02 00:00:00', 1150, 1)
INSERT INTO [dbo].[Beautician] ([BeauticianID], [BeauticianName], [ContactNumber], [JoiningDate], [Salary], [SaloonID]) VALUES (3, N'Rabina', 223434231, N'2014-09-05 00:00:00', 1000, 2)
INSERT INTO [dbo].[Beautician] ([BeauticianID], [BeauticianName], [ContactNumber], [JoiningDate], [Salary], [SaloonID]) VALUES (4, N'vandhna', 221324545, N'2013-12-01 00:00:00', 950, 5)
INSERT INTO [dbo].[Beautician] ([BeauticianID], [BeauticianName], [ContactNumber], [JoiningDate], [Salary], [SaloonID]) VALUES (5, N'Heyam', 22312456, N'2016-09-19 00:00:00', 1200, 4)
SET IDENTITY_INSERT [dbo].[Beautician] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [ContactNumber], [Expenses], [BeauticianID]) VALUES (1, N'Bris', 2887967, 140, 1)
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [ContactNumber], [Expenses], [BeauticianID]) VALUES (2, N'Dey', 998786567, 120, 1)
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [ContactNumber], [Expenses], [BeauticianID]) VALUES (3, N'Ank', 99897865, 100, 1)
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [ContactNumber], [Expenses], [BeauticianID]) VALUES (4, N'Krit', 998982123, 90, 1)
INSERT INTO [dbo].[Customer] ([CustomerID], [CustomerName], [ContactNumber], [Expenses], [BeauticianID]) VALUES (5, N'Benny', 22343456, 70, 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [ExpiryDate], [SaloonID]) VALUES (1, N'Face Cream', N'2022-11-02 00:00:00', 1)
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [ExpiryDate], [SaloonID]) VALUES (2, N'Face Bleach', N'2023-11-01 00:00:00', 1)
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [ExpiryDate], [SaloonID]) VALUES (3, N'Hair Bleach ', N'2022-02-11 00:00:00', 1)
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [ExpiryDate], [SaloonID]) VALUES (4, N'Hair color ', N'2025-12-01 00:00:00', 1)
INSERT INTO [dbo].[Product] ([ProductID], [ProductName], [ExpiryDate], [SaloonID]) VALUES (5, N'Hair spray', N'2024-11-05 00:00:00', 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
