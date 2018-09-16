CREATE TABLE [dbo].[Friend] (
    [FriendId]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (100) NOT NULL,
    [Latitude]  INT           NOT NULL,
    [Longitude] INT           NOT NULL,
    CONSTRAINT [PK__Friend__3214EC070036B449] PRIMARY KEY CLUSTERED ([FriendId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [uq_FriendLocation]
    ON [dbo].[Friend]([Latitude] ASC, [Longitude] ASC);

