/****** Объект:  StoredProcedure [dbo].[SP_Klients]    Дата сценария: 06/22/2016 23:47:04 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Klients]
(
	@type as int,
	@like as nvarchar(50)
)
 AS
if @type=0
select rtrim(inn) inn, rtrim(fio) fio, vidano, id, limit, amb, stc,lpu,summa_za+summa_tr nachislen,
paspser,paspnom,paspdat,ceh,rtrim(tabnum) tabnum,kemvidan, date_birth, address, telefon, nazvan, schet,schet1, nasled, nasladr, naslrogd, god_strax, rtrim(comment) comment, 
rtrim(rab) rab, dogovor, predpr, date_dog_begin   
from Klients 
where fio like @like
if @type=1
select rtrim(inn) inn, rtrim(fio) fio, vidano, id, limit, amb, stc,lpu,summa_za+summa_tr nachislen,
paspser,paspnom,paspdat,ceh,rtrim(tabnum) tabnum,kemvidan, date_birth, address, telefon, nazvan, schet,schet1, nasled, nasladr, naslrogd, god_strax, rtrim(comment) comment, 
rtrim(rab) rab, dogovor, predpr, date_dog_begin       
from Klients 
where tabnum like @like
GO
