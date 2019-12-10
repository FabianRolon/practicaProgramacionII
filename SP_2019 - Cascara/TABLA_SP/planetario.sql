USE [planetario]
GO
/****** Object:  Table [dbo].[Satelites]    Script Date: 19/11/2019 19:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Satelites](
	[nombre] [varchar](50) NOT NULL,
	[duracion_orbita] [int] NOT NULL,
	[duracion_rotacion] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
