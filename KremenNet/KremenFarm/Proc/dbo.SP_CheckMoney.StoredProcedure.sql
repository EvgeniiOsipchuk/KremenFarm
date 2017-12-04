/****** Объект:  StoredProcedure [dbo].[SP_CheckMoney]    Дата сценария: 06/22/2016 23:47:03 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CheckMoney] 
-- проверка остатков денег
(
	@lechenie_id as bigint,
	@klient_id as bigint,
	@status as int output 	--1- не хватает денег у клиента 2 -не хватает денег у Кремня
)
AS
declare @limit as real
declare @sublimit as real
set @sublimit=(select limit from lechenie where id=@lechenie_id)

set @limit =(select limit from klients where id=@klient_id)

 
if @sublimit>@limit	-- нет денег у клиента
begin
	set @status=1
	return
end
--set @limit =(select kremen_limit from kremen)
--if @sublimit>@limit	-- нет денег у Кремня
--begin
--	set @status=2
	--return
--end

set @status=0
GO
