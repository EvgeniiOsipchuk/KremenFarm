/****** Îáúåêò:  StoredProcedure [dbo].[SP_InsurCaseUpdate]    Äàòà ñöåíàğèÿ: 06/22/2016 23:47:04 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_InsurCaseUpdate]
(
	@insurcase_id as bigint,
	@diag_id as bigint,
	@doctors_id as bigint,
	@bol_num as nvarchar(20),
	@bol_start as datetime,
	@close as int,
	@bol_end as datetime,
	@otdel_id as bigint,
	@method as int,  -- 1 - ğü¦ºûğªş¨ışõ, 2- ôıõòışù ¸ªğ¡øşığ¨, 3- ú¨ºóûş¸ºªş¢ıvù ¸ªğ¡øşığ¨
	@lechenie_id as bigint,
	@lpu_id as bigint,
	@klient_id as bigint,
	@old_method as int,	-- ôû  ø÷üõıõıø  ÿ¨õôvôº•õóş üõªşôğ ûõ¢õıø 
	@total_price as real,
	@old_limit as real,
    @old_food_price as real,
    @new_food_price as real
)
 AS
declare @limit as real
declare @food_p as real
declare @god_strax as integer
declare @sum_strax as integer
declare @klient_limit as real

begin tran
Set @limit=(select limit from lechenie where id=@lechenie_id)
Set @food_p=(select food_price from InsurCase where id=@insurcase_id)
set @god_strax = (select god_strax from dbo.klients where id=@klient_id)
Set @klient_limit=(select limit from dbo.klients where id=@klient_id)

if (@god_strax<=2006) 
  set @sum_strax=2000 
else
   set @sum_strax=3000 

if @klient_limit<@limit
begin
  update klients set vidano=@sum_strax, limit=0 where id=@klient_id
end
else
begin
  update klients set vidano=vidano-@old_limit-@food_p, limit=limit+@old_limit+@food_p where id=@klient_id
  update klients set vidano=vidano+@limit+@new_food_price, limit=limit-@limit-@new_food_price where id=@klient_id
end

if @old_method=1
begin
	update klients set amb=amb-1 where id=@klient_id
end
if @old_method=2
begin
	update klients set stc=stc-1 where id=@klient_id
end
if @old_method=3
begin
	update klients set lpu=lpu-1 where id=@klient_id
end

if @method=1
begin
	update klients set amb=amb+1 where id=@klient_id
end
if @method=2
begin
	update klients set stc=stc+1 where id=@klient_id
end
if @method=3
begin
	update klients set lpu=lpu+1 where id=@klient_id
end
if @method=5
begin
  update klients set comment='ÑÌÅĞÒÜ', limit=0, vidano=@sum_strax where id=@klient_id
end
if @close=0
	set @bol_end=Null
update InsurCase set diag_id=@diag_id, doctors_id=@doctors_id, bol_num=@bol_num, bol_start=@bol_start, bol_end=@bol_end, otdel_id=@otdel_id, bol_close=@close, 
                                  lechenie_id=@lechenie_id, lpu_id=@lpu_id, method=@method, total_price=@total_price, food_price=@new_food_price 
where id = @insurcase_id
commit tran
GO
