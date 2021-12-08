CREATE TABLE [dbo].[feedback] (
    [Id]                      INT            IDENTITY (1, 1) NOT NULL,
    [Date]                    DATETIME2 (7)  NOT NULL,
    [UserName]                NVARCHAR (MAX) NULL,
    [Heading]                 NVARCHAR (MAX) NOT NULL,
    [CompanyOrganisationName] NVARCHAR (MAX) NULL,
    [Feedback]                NVARCHAR (MAX) NULL,
    [StarRating]              INT            DEFAULT ((0)) NOT NULL,
    [Agree]                   INT            DEFAULT ((0)) NOT NULL,
    [Disagree]                INT            DEFAULT ((0)) NOT NULL,
    [IncreaseAgree]           BIT            DEFAULT (CONVERT([bit],(0))) NOT NULL,
    [IncreaseDisagree]        BIT            DEFAULT (CONVERT([bit],(0))) NOT NULL,
    CONSTRAINT [PK_feedback] PRIMARY KEY CLUSTERED ([Id] ASC)
);

