CREATE PROCEDURE [dbo].[LekarzePoSpecjalizacji]
	@parametr varchar(20)
	
AS
BEGIN
SET NOCOUNT ON;
	SELECT ID_lekarz, imie, nazwisko, stanowisko FROM Personel1
	WHERE specjalizacja = @parametr
END
