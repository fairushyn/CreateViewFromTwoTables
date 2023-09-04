CREATE VIEW v_EntitiesView AS
SELECT 'EntityA' as EntityType, CAST(Id AS BIGINT) AS Id, Name AS Info FROM EntityAs
UNION
SELECT 'EntityB', Id, Description FROM EntityBs