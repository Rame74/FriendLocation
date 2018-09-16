CREATE TABLE [dbo].[WhosNear] (
    [FriendId_1_FK] INT NOT NULL,
    [FriendId_2_FK] INT NOT NULL,
    CONSTRAINT [FK_WhosNear_Friend] FOREIGN KEY ([FriendId_1_FK]) REFERENCES [dbo].[Friend] ([FriendId]),
    CONSTRAINT [FK_WhosNear_Friend1] FOREIGN KEY ([FriendId_2_FK]) REFERENCES [dbo].[Friend] ([FriendId])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [uq_FriendRelation]
    ON [dbo].[WhosNear]([FriendId_1_FK] ASC, [FriendId_2_FK] ASC);

