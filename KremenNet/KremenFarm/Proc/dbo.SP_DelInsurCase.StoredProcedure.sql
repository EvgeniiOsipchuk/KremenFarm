/****** Объект:  StoredProcedure [dbo].[SP_DelInsurCase]    Дата сценария: 06/22/2016 23:47:03 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DelInsurCase]
(
	@id as bigint
	
)
AS
declare @count as int
declare @lechenie_id as bigint
declare @limit as real
declare @food_price as real
declare @klient_id as bigint
declare @method as int
declare @vidach_id as bigint

--set @count=(select count(*) from vidacha where insurcase_id=@id)
--if @count<>0
--begin
--	set @status=1
--	return
--end
--set @count=(select bol_close from insurcase where id=@id)
--if @count<>0
--begin
--	set @status=2
--	return
--end
begin tran
set @lechenie_id=(select lechenie_id from insurcase where id=@id)
set @limit=(select limit from lechenie where id=@lechenie_id)
set @food_price =(select food_price  from insurcase where id=@id)
set @klient_id=(select klient_id from insurcase where id=@id)
set @method=(select method from insurcase where id=@id)

if @method=1
begin
	update klients set amb=amb-1 where id=@klient_id
end
if @method=2
begin
	update klients set stc=stc-1 where id=@klient_id
end
if @method=3
begin
	update klients set lpu=lpu-1 where id=@klient_id
end

declare vidach_cursor Cursor for
  select id from vidacha where insurcase_id=@id
open vidach_cursor

Fetch next from vidach_cursor into @vidach_id
while @@fetch_status=0
begin
  exec dbo.SP_DelVidacha @vidach_id
  Fetch next from vidach_cursor into @vidach_id
end
Close vidach_cursor
deallocate vidach_cursor

update klients set vidano=vidano-@limit-@food_price, limit=limit+@limit+@food_price where id=@klient_id
insert into DelInsurCase(old_id, klient_id, diag_id, lechenie_id, doctors_id, bol_num, bol_start, bol_end, lpu_id, otdel_id, method, bol_close, total_price) 
	select id, klient_id, diag_id, lechenie_id, doctors_id, bol_num, bol_start, bol_end, lpu_id, otdel_id, method, bol_close, total_price from insurcase where id=@id
delete from insurcase where id=@id
commit tran
GO
