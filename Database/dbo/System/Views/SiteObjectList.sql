/*
    View: SiteObjectList

    Description:
    This view retrieves information about site objects, including their ID, name, path, type name, and icon.

    Columns:
    - SiteObjectId: The ID of the site object.
    - SiteObjectName: The name of the site object.
    - Path: The path of the site object.
    - TypeName: The name of the site object type.
    - Icon: The icon of the site object type.

    Tables:
    - SiteObjects: The table containing site object information.
    - SiteObjectTypes: The table containing site object type information.
    - SiteObjectCategories: The table containing site object category information.

    Usage:
    SELECT * FROM [dbo].[SiteObjectList]
*/
CREATE VIEW [dbo].[SiteObjectList]
AS 
SELECT 
    so.[Id] AS SiteObjectId, 
    so.[Name] AS SiteObjectName,
    so.[Path], 
    sot.[Id] as TypeId,
    sot.[Name] AS TypeName, 
    sot.[Icon],
    soc.[Id] AS CategoryId,
    soc.[Name] AS CategoryName
FROM 
    [dbo].[SiteObjects] so
JOIN 
    [dbo].[SiteObjectTypes] sot ON so.[Type] = sot.[Id]
JOIN
    [dbo].[SiteObjectCategories] soc ON so.[Category] = soc.[Id]
