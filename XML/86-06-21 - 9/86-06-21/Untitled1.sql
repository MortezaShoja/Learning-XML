CREATE PROC INS_T @T NVARCHAR(50) AS
BEGIN
	DECLARE @ID INT
	SELECT @ID=MAX(id)
	FROM title
	INSERT INTO title
	VALUES(@ID+1,@T)
END

------------------------------
CREATE FUNCTION GetChanges(@ID INT)RETURNS INT AS
BEGIN
	DECLARE @MAXID INT
	SELECT @MAXID=MAX(id)
	FROM title
	DECLARE @R INT
	IF @MAXID=@ID
		SELECT @R=0
	ELSE
		SELECT @R=1
RETURN @R
END
------------------------------
CREATE FUNCTION GetRows(@ID INT) RETURNS @T TABLE(ID INT,Title NVARCHAR(50))AS
BEGIN
	INSERT INTO @T
	SELECT id,title
	FROM title
	WHERE id>@ID
RETURN
END

KILL 73
KILL 71