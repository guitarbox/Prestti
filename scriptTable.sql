CREATE TABLE [dbo].[Request](
	[IdRequest] [int] IDENTITY(1,1) NOT NULL,
	[Numero1] [decimal](25, 0) NOT NULL,
	[Numero2] [decimal](25, 0) NOT NULL,
	[Resultado] [decimal](25, 0) NOT NULL,
	[EncontradoEnSecuencia] [bit] NOT NULL,
	[Usuario] [nvarchar](200) NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[IpOrigen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[IdRequest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
