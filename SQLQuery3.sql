GRANT select,insert,update,delete ON dbo.Orders TO CEORole
GO

GRANT select,insert,update,delete ON dbo.Customers TO CEORole
GO

GRANT select,insert,update,delete ON dbo.Employees TO CEORole
GO

GRANT select,insert,update,delete ON dbo.Orders TO SalesRole
GO

GRANT select,insert,update,delete ON dbo.Customers TO SalesRole
GO

GRANT select,insert,update,delete ON dbo.Employees TO HRRole
GO