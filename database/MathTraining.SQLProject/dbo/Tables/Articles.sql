CREATE TABLE [dbo].[Articles] (
    [ArticleId]         UNIQUEIDENTIFIER NOT NULL,
    [BriefIntroduction] NVARCHAR (256)   NOT NULL,
    [ChineseTitle]      NVARCHAR (50)    NOT NULL,
    [Created]           DATETIME2 (7)    NOT NULL,
    [EnglishTitle]      NVARCHAR (50)    NOT NULL,
    [FileNameOfView]    NVARCHAR (50)    NOT NULL
);