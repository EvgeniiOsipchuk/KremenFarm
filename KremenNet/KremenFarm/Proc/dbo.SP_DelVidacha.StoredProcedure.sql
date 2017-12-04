/****** Объект:  StoredProcedure [dbo].[SP_DelVidacha]    Дата сценария: 06/22/2016 23:47:03 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DelVidacha]
(
	@vidacha_id as bigint
)
AS
declare @medikament_id as bigint
declare @kolvo as int

begin tran
insert into DelVidachaDetail(vidacha_id, medikament_id, kolvo,price) select vidacha_id,medikament_id,kolvo,price from vidachaDetail where vidacha_id=@vidacha_id
declare medikament_cursor Cursor for
	select medikament_id, kolvo from vidachaDetail where vidacha_id=@vidacha_id
open medikament_cursor
Fetch next from medikament_cursor into @medikament_id, @kolvo
while @@fetch_status=0
begin
	update medikament set kolvo=kolvo+@kolvo where id=@medikament_id
	Fetch next from medikament_cursor into @medikament_id, @kolvo
end
Close medikament_cursor
deallocate medikament_cursor
delete from vidachaDetail where vidacha_id=@vidacha_id

insert into DelVidacha(old_id,insurcase_id, date_enter, total_price, klient_id) select id,insurcase_id, date_enter, total_price, klient_id from vidacha where id=@vidacha_id
delete from vidacha where id=@vidacha_id
commit tran
GO
