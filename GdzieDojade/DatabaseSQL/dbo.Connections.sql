CREATE TABLE [dbo].[Connections] (
    [Id]            INT      IDENTITY (0, 1) NOT NULL,
    [Source]        INT      NOT NULL,
    [Destination]   INT      NOT NULL,
    [Distance]      INT      NOT NULL,
    [Price]         INT      NOT NULL,
    [DepartureTime] DATETIME NOT NULL,
    [ArrivalTime]   DATETIME NOT NULL,
    [TransportType] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

