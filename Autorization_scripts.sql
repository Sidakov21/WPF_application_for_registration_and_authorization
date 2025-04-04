USE [Users]
GO
/****** Object:  Table [dbo].[User]    Script Date: 31.03.2025 2:19:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Role] [nvarchar](30) NOT NULL,
	[FIO] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Photo] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1, N'admin', N'P@ssw0rd123', N'Administrator', N'Иванов Иван Иванович', N'+7 (495) 123-45-67', N'Мужской', N'https://example.com/photos/admin.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (2, N'manager1', N'SecurePass1', N'Manager', N'Петров Петр Петрович', N'+7 (495) 234-56-78', N'Мужской', N'https://example.com/photos/manager1.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (3, N'manager2', N'Qwerty321!', N'Manager', N'Сидорова Анна Сергеевна', N'+7 (495) 345-67-89', N'Женский', N'https://example.com/photos/manager2.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (4, N'user1', N'UserPass123', N'User', N'Кузнецов Дмитрий Олегович', N'+7 (495) 456-78-90', N'Мужской', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (5, N'user2', N'Pass456User!', N'User', N'Васильева Мария Алексеевна', N'+7 (495) 567-89-01', N'Женский', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (6, N'admin2', N'AdminSecure789!', N'Administrator', N'Федоров Александр Дмитриевич', N'+7 (495) 678-90-12', N'Мужской', N'https://example.com/photos/admin2.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (7, N'manager3', N'MngPass555!', N'Manager', N'Тихомиров Василий Егорович', N'+7 (495) 789-01-23', N'Мужской', N'https://example.com/photos/manager3.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (8, N'analyst1', N'AnalystPass1!', N'Analyst', N'Козлова Елена Викторовна', N'+7 (495) 890-12-34', N'Женский', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (9, N'analyst2', N'AnalystPass2!', N'Analyst', N'Михайлов Павел Сергеевич', N'+7 (495) 901-23-45', N'Мужской', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (10, N'analyst3', N'AnalystPass3!', N'Analyst', N'Григорьева Анна Олеговна', N'+7 (495) 012-34-56', N'Женский', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (11, N'user3', N'UserSimple987!', N'User', N'Дмитриев Игорь Иванович', N'+7 (495) 111-22-33', N'Мужской', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (12, N'user4', N'UserSafe654!', N'User', N'Семенова Наталья Александровна', N'+7 (495) 222-33-44', N'Женский', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1002, N'alex1', N'alex123', N'User', N'Смирнов Алексей Петрович', N'Не указан', N'Не указан', N'')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1003, N'Павло1', N'123', N'User', N'Семенов Николай Павлович', N'8 923 555 22 55', N'Мужской', N'https://avatars.mds.yandex.net/i?id=ade0dc0d02a6be992c751d279913bb8a_l-5303121-images-thumbs&n=13')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1004, N'fin_analyst', N'Fin@Analysis1', N'Analyst', N'Николаев Артем Викторович', N'+7 (495) 333-44-55', N'Мужской', N'https://example.com/photos/fin_analyst.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1005, N'sales_mng', N'Sales2024!', N'Manager', N'Петров Денис Олегович', N'+7 (495) 777-88-99', N'Мужской', N'https://example.com/photos/sales_manager.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1006, N'hr_user1', N'HRuserPass1', N'User', N'Тихомирова Ольга Игоревна', N'+7 (495) 999-00-11', N'Женский', N'https://example.com/photos/hr_user.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1007, N'sales_mng2', N' ', N'Manager', N'Петров Денис Олегович', N'+7 (495) 777-88-99', N'Мужской', N'https://example.com/photos/sales_manager.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1008, N'fin_analyst2', N'Fin@Analysis1', N'Analyst', N'Николаев Артем Викторович', N'+7 (495) 333-44-55', N'Мужской', N'https://example.com/photos/fin_analyst.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1009, N'sales_mng5', N'Sales2024!', N'Manager', N'Петров Денис Олегович', N'+7 (495) 777-88-99', N'Мужской', N'https://example.com/photos/sales_manager.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1010, N'hr_use51', N'HRuserPass1', N'User', N'Тихомирова Ольга Игоревна', N'+7 (495) 999-00-11', N'Женский', N'https://example.com/photos/hr_user.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1012, N'NULL', N'NULL', N'NULL', N'NULL', N'NULL', N'NULL', N'NULL')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1013, N'very_long_username_1234567890', N'P@ssw0rdWithMaxLength32symbols!!', N'NULL', N'Оченьдлиннаяфамилия Оченьдлинноеимя Оченьдлинноеотчество', N'NULL', N'Женский', N'https://example.com/very/long/url/to/user/photo/which/exceeds/standard/length/limits/user_photo.jpg')
INSERT [dbo].[User] ([ID], [Login], [Password], [Role], [FIO], [Phone], [Gender], [Photo]) VALUES (1014, N' ', N' ', N' ', N' ', N' ', N' ', N' ')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__User__5E55825BB8D4E92A]    Script Date: 31.03.2025 2:19:18 ******/
ALTER TABLE [dbo].[User] ADD UNIQUE NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
