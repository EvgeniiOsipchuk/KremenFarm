/****** Îáúåêò:  StoredProcedure [dbo].[SP_InsurCaseInsert]    Äàòà ñöåíàğèÿ: 06/22/2016 23:47:04 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsurCaseInsert]
(
	@klient_id as bigint,
	@diag_id as bigint,
	@lechenie_id as bigint,
	@doctors_id as bigint,
	@bol_num as nvarchar(20),
	@bol_start as datetime,
	@close as int,
	@bol_end as datetime,
	@lpu_id as bigint,
	@otdel_id as bigint,
	@method as int,  -- 1 - ğü¦ºûğªş¨ışõ, 2- ôıõòışù ¸ªğ¡øşığ¨, 3- ú¨ºóûş¸ºªş¢ıvù ¸ªğ¡øşığ¨
	@total_price as real,
             @food_price as real,
	@insurcase_id as bigint output
)
 AS
declare @ins_count as int
declare @limit as real
declare @sum_strax as integer
declare @klient_limit as real
declare @new_vidano as real
declare @new_klient_limit as real
declare @new_comment as nvarchar(10)
declare @god_strax as integer

begin tran

set @god_strax = (select god_strax from dbo.klients where id=@klient_id)
set @limit=(select limit from lechenie where id=@lechenie_id)
Set @klient_limit=(select limit from dbo.klients where id=@klient_id)
set @new_comment = ''

if (@god_strax<=2006) 
  set @sum_strax=2000 
else
   set @sum_strax=3000 

if @method=1
begin
	set @ins_count=(select amb from klients where id=@klient_id)
	set @ins_count=@ins_count+1
	update klients set amb=@ins_count where id=@klient_id
end
if @method=2
begin
	set @ins_count=(select stc from klients where id=@klient_id)
	set @ins_count=@ins_count+1
	update klients set stc=@ins_count where id=@klient_id
end
if @method=3
begin
	set @ins_count=(select lpu from klients where id=@klient_id)
	set @ins_count=@ins_count+1
	update klients set lpu=@ins_count where id=@klient_id
end
if @method=5
begin
  set @new_comment = 'ÑÌÅĞÒÜ'
end

if @close=0
	set @bol_end=Null

if (@klient_limit<@limit) or (@method=5)
begin
  update klients set vidano=@sum_strax, limit=0, comment = @new_comment where id=@klient_id
end
else
begin
  update klients set vidano=vidano+@limit+@food_price, limit=limit-@limit-@food_price where id=@klient_id
end

--update klients set vidano=vidano+@limit+@food_price, limit=limit-@limit-@food_price where id=@klient_id
INSERT INTO InsurCase(klient_id, diag_id, lechenie_id, doctors_id, bol_num, bol_start, bol_end, lpu_id, otdel_id, method, bol_close, total_price, food_price)
VALUES(@klient_id, @diag_id, @lechenie_id, @doctors_id, @bol_num, @bol_start, @bol_end, @lpu_id, @otdel_id, @method,@close, @total_price, @food_price)
set @insurcase_id=(select @@identity)
commit tran
GO
