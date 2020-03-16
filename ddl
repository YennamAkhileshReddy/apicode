CREATE TABLE Azure_CILogsDetails (
    id INT PRIMARY KEY IDENTITY (1, 1),
    Meta VARCHAR (100) NOT NULL,
    Project VARCHAR (100) NOT NULL,
    Org  VARCHAR (100) NULL,
    EventType Varchar(50) Not Null,
    BuildNumber Varchar(50) Null,
    BuildId Varchar(50) Null,
    BuildRequester Varchar(150) Null,
    BuildRepoName Varchar(150) Null,
    BuildDefinitionName Varchar(150) Null,
    BuildBy Varchar(50) Null,
    BuildRepositoryId varchar(50) Null,
    BuildRepositoryName varchar(50) Null,
    DeplyStagename varchar(50) Null,
    DeplyEnvironmentName varchar(50) Null,
    DeplySubscriptionName varchar(150) Null,
    DeplyAppServiceName varchar(256) Null,
    DeplyAppSlotName varchar(50) Null,
    DeplyResourceGrpName varchar(50) Null,
    DeplyStartTime DATETIME null,
    DeplyEndTime Datetime Null,
    Status varchar(50) Null,
    Approver varchar(150) Null,
    ApprovedOn Datetime Null,
    ApproveRequestedOn Datetime Null,
    CreatedOn Datetime Null Default (getdate())
);


CREATE TABLE Azure_CIProjectDetails (
    id INT PRIMARY KEY IDENTITY (1, 1),
    Meta VARCHAR (100) NOT NULL,
    Project VARCHAR (100) NOT NULL,
    Org  VARCHAR (100) NOT NULL,
    Branch VARCHAR (100) NULL
    ProjectPath VARCHAR (512) NULL,
    BuildConfiguration VARCHAR (512) NULL,
    AppOwner VARCHAR (150) NULL,
    OnboardedOn Datetime NULL

);
