USE [GestionAlumnos]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 17/09/2023 20:45:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[id] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[curso] [varchar](50) NULL,
	[edad] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Alumnos] ([id], [nombre], [apellido], [curso], [edad]) VALUES (1, N'Benciio', N'Bursz', N'4ic', 16)
INSERT [dbo].[Alumnos] ([id], [nombre], [apellido], [curso], [edad]) VALUES (2, N'uriel', N'vvv', N'3ic', 15)
INSERT [dbo].[Alumnos] ([id], [nombre], [apellido], [curso], [edad]) VALUES (3, N'juan', N'se', N'8ui', 20)
GO
