/****** Объект:  StoredProcedure [dbo].[SP_GetPredpr]    Дата сценария: 06/22/2016 23:50:46 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetPredpr]
(
    @type_search as smallint, --0 Strax Only, 1 - All people
	@id_predpr as bigint,
    @god_strax as int 
)
AS

if @type_search=0 
SELECT  id, inn, fio, ceh, nazvan, tabnum, date_birth, paspser, paspnom, paspdat, kemvidan, address, telefon, summa_za, summa_tr, dogovor, rab, schet, schet1, nasled, 
         nasladr, naslrogd, comment, limit, vidano, amb, stc, lpu, date_enter, user_enter, date_dog_begin, date_dog_end, predpr, god_strax
FROM  Klients
WHERE  (god_strax = @god_strax) AND (predpr = @id_predpr) AND RTRIM(UPPER(comment)) = '' 
order by fio

if @type_search=1
SELECT  id, inn, fio, ceh, nazvan, tabnum, date_birth, paspser, paspnom, paspdat, kemvidan, address, telefon, summa_za, summa_tr, dogovor, rab, schet, schet1, nasled, 
        nasladr, naslrogd, comment, limit, vidano, amb, stc, lpu, date_enter, user_enter, date_dog_begin, date_dog_end, predpr, god_strax
FROM    Klients
WHERE   (god_strax = @god_strax) AND (predpr = @id_predpr) 
order by fio
GO
