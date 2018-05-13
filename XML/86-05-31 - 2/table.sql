CREATE TABLE [XRows] (
	[Row] [int] IDENTITY (1, 1) NOT NULL ,
	[XData] [nvarchar] (4000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	CONSTRAINT [PK_XRows] PRIMARY KEY  CLUSTERED 
	(
		[Row]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO


