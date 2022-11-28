CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[DeletedOn] [datetime] NULL,
	[Email] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[LastLogin] [datetime] NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[PortalId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[Telephone] [varchar](50) NOT NULL,
	[UpdateOn] [datetime] NULL,
	[Username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
