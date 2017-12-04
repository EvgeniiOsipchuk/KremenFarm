/****** Объект:  StoredProcedure [dbo].[SP_VidachaDetailInsert]    Дата сценария: 06/22/2016 23:47:07 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VidachaDetailInsert]
(
	@vidacha_id as bigint,
	@medikament_id as bigint,
	@kolvo as int,
	@price as real,
	@status as int output
)
AS
begin tran
insert into vidachadetail(vidacha_id, medikament_id,kolvo, price) values(@vidacha_id,@medikament_id, @kolvo, @price)
-- уменьшение в аптеке!!!!!
update medikament set kolvo=kolvo-@kolvo where id=@medikament_id
set @status=0
commit tran
GO
