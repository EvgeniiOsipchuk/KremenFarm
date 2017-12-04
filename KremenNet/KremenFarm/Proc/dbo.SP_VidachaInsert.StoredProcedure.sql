/****** Объект:  StoredProcedure [dbo].[SP_VidachaInsert]    Дата сценария: 06/22/2016 23:47:07 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VidachaInsert]
(
	@klient_id as bigint,
	@insurcase_id as bigint,
	@total_price as real,
	@vid_id as int output
)
AS
begin tran
insert into vidacha(insurcase_id, date_enter, total_price, klient_id) values(@insurcase_id, getdate(), @total_price, @klient_id)
set @vid_id=(select @@identity)
commit tran
GO
