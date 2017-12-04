/****** Объект:  StoredProcedure [dbo].[SP_UpdateKlient]    Дата сценария: 06/22/2016 23:47:06 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_UpdateKlient]
(
	@klient_id as bigint,
	@fio as nvarchar(256),
	@ceh as nvarchar(10),
	@nazvan as nvarchar(30),
	@tabnum as nvarchar(50),
	@date_birth as datetime,
	@paspser as nvarchar(6),
	@paspnom as int,
	@paspdat as datetime,
	@kemvidan as nvarchar(50),
	@address as nvarchar(256),
	@telefon as nvarchar(10),
	@schet as nvarchar(50),
	@nasled as nvarchar(60),
	@nasladr as nvarchar(50),
	@naslrogd as datetime,
    @predpr as bigint,
    @dogovor as bigint,
    @god_strax as int,
    @date_dog_begin as datetime, 
    @date_dog_end as datetime 
)
AS
declare @nrab as nvarchar(10)
set @nrab = (select short_name from predpr where id=@predpr)

begin tran
UPDATE Klients
SET  fio=@fio, ceh=@ceh, nazvan=@nazvan, tabnum=@tabnum, date_birth=@date_birth, paspser=@paspser, paspnom=@paspnom, paspdat=@paspdat, 
kemvidan=@kemvidan, address=@address, telefon=@telefon, schet=@schet, nasled=@nasled, nasladr=@nasladr, naslrogd=@naslrogd, dogovor=@dogovor, rab=@nrab, god_strax=@god_strax,
predpr=@predpr, date_dog_begin=@date_dog_begin, date_dog_end=@date_dog_end
WHERE id = @klient_id
commit tran
GO
