/****** Объект:  StoredProcedure [dbo].[SP_KlientsInsert]    Дата сценария: 06/22/2016 23:47:05 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KlientsInsert]
(
	@inn as nvarchar(50),
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
	@dogovor as bigint,
	@rab as nvarchar(10),
	@schet as nvarchar(50),
	@nasled as nvarchar(60),
	@nasladr as nvarchar(50),
	@naslrogd as datetime,
	@comment as nvarchar(256),
	@vidano as real,
	@amb as int, 
	@stc as int,
	@lpu as int,
	@date_dog_begin as datetime,
	@date_dog_end as datetime,
	@predpr as bigint,
	@username as nvarchar(50),
	@status as int output,
    @god_strax as int 
)
AS
declare @count as int
declare @nrab as nvarchar(10)
declare @limit as real
declare @summa_za as real
declare	@summa_tr as real

set @nrab = (select short_name from predpr where id=@predpr)
set @limit = 3000
set @summa_za = 20
set @summa_tr = 10 

begin tran
set @status=0
INSERT INTO Klients(inn, fio, ceh, nazvan, tabnum, date_birth, paspser, paspnom, paspdat, kemvidan, address, telefon, summa_za, summa_tr, dogovor, rab, schet, nasled, nasladr, naslrogd,
 comment, limit, vidano, amb, stc, lpu, date_enter, user_enter, date_dog_begin, date_dog_end, predpr, god_strax)
VALUES(@inn, @fio, @ceh, @nazvan, @tabnum, @date_birth, @paspser, @paspnom, @paspdat, @kemvidan, @address, @telefon, @summa_za, @summa_tr, @dogovor, @nrab, 
@schet, @nasled, @nasladr, @naslrogd, @comment, @limit, @vidano, @amb, @stc, @lpu, getdate(), @username, @date_dog_begin, @date_dog_end, @predpr, @god_strax)
commit tran
GO
