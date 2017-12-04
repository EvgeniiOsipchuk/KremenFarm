/****** Объект:  StoredProcedure [dbo].[SP_GetOstatok]    Дата сценария: 06/22/2016 23:50:46 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetOstatok]
-- проверка остатков денег
(
	@klient_id as bigint,
	@ostatok as real output 	--1- не хватает денег у клиента 2 -не хватает денег у Кремня
)
AS
declare @limit as real
declare @sublimit as real
declare @god_strax as integer
declare @sum_by_vidach as real
declare @sum_by_food as real
declare @sum_by_viplat as real
declare @sum_all as real
declare @sum_strax as real
set @sum_by_vidach = 0
--set  @sum_viplat = 0
set @sum_by_vidach =(select isnull(sum(total_price),0) from vidacha where klient_id=@klient_id)
set  @sum_by_viplat =(select isnull(sum(total_price),0) from InsurCase where klient_id=@klient_id)
set  @sum_by_food =(select isnull(sum(food_price),0) from InsurCase where klient_id=@klient_id)

--set @sum_by_vidach =(select top 1 0 total_price from vidacha where klient_id=@klient_id)
--set  @sum_viplat =(select top 1 0 total_price from InsurCase where klient_id=@klient_id)


set @sum_all = @sum_by_vidach+@sum_by_viplat+@sum_by_food
set @god_strax = (select god_strax from dbo.klients where id=@klient_id)
 
if (@god_strax<=2006) 
    set  @sum_strax = 2000
  else
  set @sum_strax = 3000

set @ostatok = @sum_strax - @sum_all 
if @ostatok is null 
set @ostatok = @klient_id
return
GO
