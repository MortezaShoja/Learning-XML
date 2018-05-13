SELECT employeeid,lastname
FROM employees
WHERE employeeid=7
FOR XML AUTO,ELEMENTS
--------------------------------------------------------------------
DECLARE @I INT
EXEC SP_XML_PREPAREDOCUMENT @I OUTPUT,
'<ROOT><employees employeeid="7" lastname="King"/>
<employees employeeid="8" lastname="Ramezani"/></ROOT>'

SELECT *
FROM OPENXML (@I,'/ROOT/employees',1)
WITH(employeeid INT,lastname VARCHAR(50))

EXEC SP_XML_REMOVEDOCUMENT @I
--------------------------------------------------------------------
CREATE FUNCTION GetXMLFROMRecord(@EID INT)RETURNS NVARCHAR(4000)AS
BEGIN
	DECLARE @RESULT NVARCHAR(4000)
	SELECT @RESULT='<ROOT><employees employeeid="'+
	CAST(employeeid AS VARCHAR(20))+'" lastname="'+lastname+'"/></ROOT>'
	FROM employees
	WHERE employeeid=@EID
RETURN @RESULT
END

SELECT dbo.GetXMLFROMRecord(7)
------------------------------------------------------------------
CREATE PROC USP_GetXMLFromRecord @EmployeeID INT AS
BEGIN
DECLARE @I INT
DECLARE @DOC NVARCHAR(4000)
SELECT @DOC=dbo.GetXMLFROMRecord(@EmployeeID)
EXEC SP_XML_PREPAREDOCUMENT @I OUTPUT,@DOC
SELECT *
FROM OPENXML(@I,'/ROOT/employees',1)
WITH(
	employeeid INT,
	lastname VARCHAR(50)
)
EXEC SP_XML_REMOVEDOCUMENT @I
END

EXEC USP_GetXMLFromRecord 9
----------------------------------------------
CREATE PROC USP_GetXMLFROMTABLE @CONDITION NVARCHAR(4000)AS
BEGIN
	DECLARE @RESULT NVARCHAR(4000)
	SELECT @RESULT='<ROOT>'
	EXECUTE('DECLARE C CURSOR FOR SELECT employeeid,lastname	FROM employees WHERE '+@CONDITION)
	OPEN C
	DECLARE @ID INT
	DECLARE @LN VARCHAR(50)	
	FETCH NEXT FROM C INTO @ID,@LN
	SELECT @RESULT=@RESULT+'<employees employeeid="'+CAST(@ID AS VARCHAR(20))+
	'" lastname="'+@LN+'"/>'
	WHILE @@FETCH_STATUS=0
	BEGIN
		FETCH NEXT FROM C INTO @ID,@LN
		SELECT @RESULT=@RESULT+'<employees employeeid="'+CAST(@ID AS VARCHAR(20))+
		'" lastname="'+@LN+'"/>'
	END
	SELECT @RESULT=@RESULT+'</ROOT>'
CLOSE C
DEALLOCATE C
SELECT @RESULT
END

EXECUTE('SELECT * FROM employees')

EXEC USP_GetXMLFROMTABLE 'employeeid>5'




DECLARE C CURSOR FOR SELECT employeeid FROM employees
OPEN C
DECLARE @ID INT
FETCH NEXT FROM C INTO @ID
SELECT @ID,@@FETCH_STATUS
WHILE @@FETCH_STATUS=0
BEGIN
FETCH NEXT FROM C INTO @ID
SELECT @ID,@@FETCH_STATUS
END
CLOSE C
DEALLOCATE C


SELECT * FROM employees
FOR XML AUTO