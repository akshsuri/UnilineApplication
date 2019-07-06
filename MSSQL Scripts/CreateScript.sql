CREATE TABLE dbo.CAPACITY_PROVIDER (
	id              	INT				NOT NULL,
    name				NVARCHAR(100)	NULL,
    city				NVARCHAR(100)	NULL,
    phone				NVARCHAR(20)	NULL,
    email				NVARCHAR(50)	NULL,
    contract_number		NVARCHAR(20)	NULL,
	CONSTRAINT [PK_id] PRIMARY KEY ([id]),
)

CREATE TABLE dbo.BOOKING (
	id						INT				NOT NULL, 
    object_name				NVARCHAR(100)	NULL,
    capacity_provider_id	INT				NULL,
    date_from        		DATETIME		NULL,
    date_to  		      	DATETIME		NULL,
    is_active         		BIT				NULL,
    amount					FLOAT			NULL,
    currency          		NVARCHAR(10)	NULL,
    comment        			NVARCHAR(200)	NULL,
	CONSTRAINT [PK_Bid] PRIMARY KEY ([id]),
	CONSTRAINT [FK_cpid] FOREIGN KEY ([capacity_provider_id]) REFERENCES CAPACITY_PROVIDER([id])
)
