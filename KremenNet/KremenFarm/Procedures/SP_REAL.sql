USE [KremenReal]
GO
/****** Объект:  StoredProcedure [dbo].[SP_UpdateKlient]    Дата сценария: 06/22/2016 23:30:34 ******/
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
	@naslrogd as datetime
)
AS
begin tran
UPDATE Klients
SET  fio=@fio, ceh=@ceh, nazvan=@nazvan, tabnum=@tabnum, date_birth=@date_birth, paspser=@paspser, paspnom=@paspnom, paspdat=@paspdat, 
kemvidan=@kemvidan, address=@address, telefon=@telefon, schet=@schet, nasled=@nasled, nasladr=@nasladr, naslrogd=@naslrogd
WHERE id = @klient_id
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_DelVidacha]    Дата сценария: 06/22/2016 23:30:31 ******/
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
/****** Объект:  StoredProcedure [dbo].[SP_delit]    Дата сценария: 06/22/2016 23:30:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_delit] 
(
	@medikament_id as bigint,
	@price as real,
	@kolvo as int
)
 AS
declare @id as bigint
begin tran
update medikament set kolvo=kolvo-1 where id=@medikament_id
insert into medikament (kod, name,kolvo,price,proizvod,md_term, series, gds_nds_u, gds_pr_u, nakl) 
	(select kod, name,kolvo,price,proizvod,md_term, series, gds_nds_u, gds_pr_u, nakl from medikament where id=@medikament_id)
set @id=(select @@identity)
update medikament set kolvo=@kolvo, price=@price, upak='Шт.' where id=@id
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_RepAnaliz]    Дата сценария: 06/22/2016 23:30:33 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RepAnaliz]
(
	@date_start as datetime,
	@date_end as datetime,
	@bol_id as int,  
    @id_report as int		-- Предприятие

)
 AS 
   select k.id, k.date_napr, s.fio, a.analiz, a.price, k.nom_napr
   from analiz_klient k, klients s, analiz_klient_detail d, analiz a
   where k.date_napr>= @date_start and 
         k.date_napr<=@date_end and 
         k.klient_id=s.id and
         d.analiz_klient_id=k.id and 
         d.analiz_id=a.id and 
         a.analiz_bol_id=@bol_id  and 
         s.predpr in (select p.id from predpr p where p.id_report=@id_report)
GO
/****** Объект:  StoredProcedure [dbo].[SP_AnalizKlient]    Дата сценария: 06/22/2016 23:30:30 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AnalizKlient]
(
	@date_napr as datetime,
	@nom_napr as nvarchar(10),
	@date_akt as datetime,
	@nom_akt as nvarchar(10),
	@total_price as real,
	@klient_id as bigint,
	@analiz_klient_id as bigint output
)
 AS
begin tran
insert into analiz_klient(date_napr, nom_napr, date_akt, nom_akt, total_price, klient_id)
values(@date_napr, @nom_napr, @date_akt, @nom_akt, @total_price, @klient_id)
set @analiz_klient_id=(select @@identity)
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_RepVidacha]    Дата сценария: 06/22/2016 23:30:34 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RepVidacha]
(
	@date_start as datetime,
	@date_end as datetime,
	@bol_type as int,  	-- 0 - все, 1- только открытые, 2- только закрытые
	@lechenie as int	,	-- 0 - все, 1 - только амбулаторное, 2 - 9 больница
	@vidacha as int,             -- 0 с выдачей медикаментов 1 - без выдачи
    @id_report as int		-- Предприятие

)
 AS

  
if @lechenie=-1		-- все типы лечения
	begin
		if @bol_type=0
			if @vidacha=0
				select k.fio, k.ceh, k.tabnum, v.total_price, i.bol_num, i.bol_start, d.num
				from klients k, vidacha v, insurcase i, dogovor d
				where v.klient_id=k.id and v.insurcase_id=i.id and k.dogovor=d.id  and v.date_enter>=@date_start and v.date_enter<=@date_end and i.total_price=0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)   
				order by i.bol_num
			if @vidacha=1
				select k.fio, k.ceh, k.tabnum, i.total_price, i.bol_num, i.bol_start, d.num
				from klients k, insurcase i, dogovor d
				where i.klient_id=k.id and k.dogovor=d.id  and i.bol_start>=@date_start and i.bol_start<=@date_end and i.total_price<>0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
		if @bol_type=1
			if @vidacha=0
				select k.fio, k.ceh, k.tabnum, v.total_price, i.bol_num, i.bol_start, d.num
				from klients k, vidacha v, insurcase i, dogovor d
				where v.klient_id=k.id and v.insurcase_id=i.id and k.dogovor=d.id  and v.date_enter>=@date_start and v.date_enter<=@date_end and i.bol_close=0 and i.total_price=0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
			if @vidacha=1
				select k.fio, k.ceh, k.tabnum, i.total_price, i.bol_num, i.bol_start, d.num
				from klients k, insurcase i, dogovor d
				where i.klient_id=k.id and k.dogovor=d.id  and i.bol_start>=@date_start and i.bol_start<=@date_end   and i.bol_close=0 and i.total_price<>0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num 
		if @bol_type=2
			if @vidacha=0
				select k.fio, k.ceh, k.tabnum, v.total_price, i.bol_num, i.bol_start, d.num
				from klients k, vidacha v, insurcase i, dogovor d
				where v.klient_id=k.id and v.insurcase_id=i.id and k.dogovor=d.id  and v.date_enter>=@date_start and v.date_enter<=@date_end and i.bol_close=1 and i.total_price=0 and
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
			if @vidacha=1
				select k.fio, k.ceh, k.tabnum, i.total_price, i.bol_num, i.bol_start, d.num
				from klients k, insurcase i, dogovor d
				where i.klient_id=k.id and  k.dogovor=d.id  and i.bol_end>=@date_start and i.bol_end<=@date_end and i.bol_close=1 and i.total_price<>0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
	end
if @lechenie=0		-- амбулаторное
	begin
		if @bol_type=0
			if @vidacha=0
				select k.fio, k.ceh, k.tabnum, v.total_price, i.bol_num, i.bol_start, d.num
				from klients k, vidacha v, insurcase i, dogovor d, lechenie l
				where v.klient_id=k.id and v.insurcase_id=i.id and k.dogovor=d.id  and v.date_enter>=@date_start and v.date_enter<=@date_end and i.lechenie_id=l.id and l.type_lech=1 and i.total_price=0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
			if @vidacha=1
				select k.fio, k.ceh, k.tabnum, i.total_price, i.bol_num, i.bol_start, d.num
				from klients k, insurcase i, dogovor d, lechenie l
				where i.klient_id=k.id  and k.dogovor=d.id  and i.bol_start>=@date_start and i.bol_start<=@date_end and i.lechenie_id=l.id and l.type_lech=1 and i.total_price<>0 and
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
		if @bol_type=1
			if @vidacha=0
				select k.fio, k.ceh, k.tabnum, v.total_price, i.bol_num, i.bol_start, d.num
				from klients k, vidacha v, insurcase i, dogovor d, lechenie l
				where v.klient_id=k.id and v.insurcase_id=i.id and k.dogovor=d.id  and v.date_enter>=@date_start and v.date_enter<=@date_end and i.bol_close=0 and i.lechenie_id=l.id and l.type_lech=1 and i.total_price=0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
			if @vidacha=1
				select k.fio, k.ceh, k.tabnum, i.total_price, i.bol_num, i.bol_start, d.num
				from klients k, insurcase i, dogovor d, lechenie l
				where i.klient_id=k.id  and k.dogovor=d.id  and i.bol_start>=@date_start and i.bol_start<=@date_end and i.bol_close=0 and i.lechenie_id=l.id and l.type_lech=1 and i.total_price<>0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
		if @bol_type=2
			if @vidacha=0
				select k.fio, k.ceh, k.tabnum, v.total_price, i.bol_num, i.bol_start, d.num
				from klients k, vidacha v, insurcase i, dogovor d, lechenie l
				where v.klient_id=k.id and v.insurcase_id=i.id and k.dogovor=d.id  and v.date_enter>=@date_start and v.date_enter<=@date_end and i.bol_close=1 and i.lechenie_id=l.id and l.type_lech=1 and i.total_price=0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
			if @vidacha=1
				select k.fio, k.ceh, k.tabnum, i.total_price, i.bol_num, i.bol_start, d.num
				from klients k, insurcase i, dogovor d, lechenie l
				where i.klient_id=k.id and  k.dogovor=d.id  and i.bol_end>=@date_start and i.bol_end<=@date_end and i.bol_close=1 and i.lechenie_id=l.id and l.type_lech=1 and i.total_price<>0 and 
                      k.predpr in (select id from predpr where id_report=@id_report)
				order by i.bol_num
	end
GO
/****** Объект:  StoredProcedure [dbo].[SP_Klients]    Дата сценария: 06/22/2016 23:30:32 ******/
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
select inn, fio, vidano, id, limit, amb, stc,lpu,summa_za+summa_tr nachislen,
paspser,paspnom,paspdat,ceh,tabnum,kemvidan, date_birth, address, telefon, nazvan, schet,schet1, nasled, nasladr, naslrogd, god_strax, comment, rab 
from Klients 
where fio like @like
if @type=1
select inn, fio, vidano, id, limit, amb, stc,lpu,summa_za+summa_tr nachislen,
paspser,paspnom,paspdat,ceh,tabnum,kemvidan, date_birth, address, telefon, nazvan, schet,schet1, nasled, nasladr, naslrogd, god_strax, comment, rab
from Klients 
where tabnum like @like
GO
/****** Объект:  StoredProcedure [dbo].[SP_KlientsInsert]    Дата сценария: 06/22/2016 23:30:33 ******/
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
	@summa_za as real,
	@summa_tr as real,
	@dogovor as bigint,
	@rab as nvarchar(10),
	@schet as nvarchar(50),
	@nasled as nvarchar(60),
	@nasladr as nvarchar(50),
	@naslrogd as datetime,
	@comment as nvarchar(256),
	@limit as real, 
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

set @nrab = (select short_name from predpr where id=@predpr) 

--if @predpr=1 set @nrab = 'ДМКД'
--if @predpr=2 set @nrab = 'ФК. СТАЛЬ'
--if @predpr=3 set @nrab = 'ПРОФИК'
--if @predpr=4 set @nrab = 'ПРОФ. КСК'
--if @predpr=5 set @nrab = 'ПРОФКОМ'
--if @predpr=6 set @nrab = 'КСК ДЗЕРЖ.'
--if @predpr=7 set @nrab = 'ФИЗ ЛИЦО'
--if @predpr=8 set @nrab = 'РАКС'
--if @predpr=9 set @nrab = 'КЕРАМЕТ'
--if @predpr=10 set @nrab = 'ОМС'
--if @predpr=11 set @nrab = 'ГОЛМЕТРЕС'
--if @predpr=12 set @nrab = 'РОСУКРТР'

begin tran
set @status=0
INSERT INTO Klients(inn, fio, ceh, nazvan, tabnum, date_birth, paspser, paspnom, paspdat, kemvidan, address, telefon, summa_za, summa_tr, dogovor, rab, schet, nasled, nasladr, naslrogd,
 comment, limit, vidano, amb, stc, lpu, date_enter, user_enter, date_dog_begin, date_dog_end, predpr, god_strax)
VALUES(@inn, @fio, @ceh, @nazvan, @tabnum, @date_birth, @paspser, @paspnom, @paspdat, @kemvidan, @address, @telefon, @summa_za, @summa_tr, @dogovor, @nrab, 
@schet, @nasled, @nasladr, @naslrogd, @comment, @limit, @vidano, @amb, @stc, @lpu, getdate(), @username, @date_dog_begin, @date_dog_end, @predpr, @god_strax)
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_InsurCaseInsert]    Дата сценария: 06/22/2016 23:30:31 ******/
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
	@method as int,  -- 1 - рь¦єырЄюЁэюх, 2- фэхтэющ ёЄрЎшюэрЁ, 3- ъЁєуыюёєЄюўэvщ ёЄрЎшюэрЁ
	@total_price as real,
             @food_price as real,
	@insurcase_id as bigint output
)
 AS
declare @ins_count as int
declare @limit as real
begin tran
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
	update klients set comment='СМЕРТЬ', limit=0, vidano=3000 where id=@klient_id
end

if @close=0
	set @bol_end=Null

set @limit=(select limit from lechenie where id=@lechenie_id)
update klients set vidano=vidano+@limit+@food_price, limit=limit-@limit-@food_price where id=@klient_id
INSERT INTO InsurCase(klient_id, diag_id, lechenie_id, doctors_id, bol_num, bol_start, bol_end, lpu_id, otdel_id, method, bol_close, total_price, food_price)
VALUES(@klient_id, @diag_id, @lechenie_id, @doctors_id, @bol_num, @bol_start, @bol_end, @lpu_id, @otdel_id, @method,@close, @total_price, @food_price)
set @insurcase_id=(select @@identity)
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_InsurCaseUpdate]    Дата сценария: 06/22/2016 23:30:32 ******/
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
	@method as int,  -- 1 - рь¦єырЄюЁэюх, 2- фэхтэющ ёЄрЎшюэрЁ, 3- ъЁєуыюёєЄюўэvщ ёЄрЎшюэрЁ
	@lechenie_id as bigint,
	@lpu_id as bigint,
	@klient_id as bigint,
	@old_method as int,	-- фы  шчьхэхэш  яЁхфvфє•хую ьхЄюфр ыхўхэш 
	@total_price as real,
	@old_limit as real,
             @old_food_price as real,
             @new_food_price as real
)
 AS
declare @limit as real,
             @food_p as real
begin tran
Set @limit=(select limit from lechenie where id=@lechenie_id)
Set @food_p=(select food_price from InsurCase where id=@insurcase_id)

update klients set vidano=vidano-@old_limit-@food_p, limit=limit+@old_limit+@food_p where id=@klient_id

update klients set vidano=vidano+@limit+@new_food_price, limit=limit-@limit-@new_food_price where id=@klient_id


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
	update klients set comment='СМЕРТЬ', limit=0, vidano=3000 where id=@klient_id
end
if @close=0
	set @bol_end=Null
update InsurCase set diag_id=@diag_id, doctors_id=@doctors_id, bol_num=@bol_num, bol_start=@bol_start, bol_end=@bol_end, otdel_id=@otdel_id, bol_close=@close, 
                                  lechenie_id=@lechenie_id, lpu_id=@lpu_id, method=@method, total_price=@total_price, food_price=@new_food_price 
where id = @insurcase_id
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_DelInsurCase]    Дата сценария: 06/22/2016 23:30:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DelInsurCase]
(
	@id as bigint,
	@status as int output  -- 1- хёЄ№ тvфрўш 2 - сюы№эшўэvщ чръЁvЄ
)
AS
declare @count as int
declare @lechenie_id as bigint
declare @limit as real
declare @food_price as real
declare @klient_id as bigint
declare @method as int

set @count=(select count(*) from vidacha where insurcase_id=@id)
if @count<>0
begin
	set @status=1
	return
end
set @count=(select bol_close from insurcase where id=@id)
if @count<>0
begin
	set @status=2
	return
end
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


update klients set vidano=vidano-@limit-@food_price, limit=limit+@limit+@food_price where id=@klient_id
insert into DelInsurCase(old_id, klient_id, diag_id, lechenie_id, doctors_id, bol_num, bol_start, bol_end, lpu_id, otdel_id, method, bol_close, total_price) 
	select id, klient_id, diag_id, lechenie_id, doctors_id, bol_num, bol_start, bol_end, lpu_id, otdel_id, method, bol_close, total_price from insurcase where id=@id
delete from insurcase where id=@id
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_CheckMoney]    Дата сценария: 06/22/2016 23:30:31 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CheckMoney] 
-- проверка остатков денег
(
	@lechenie_id as bigint,
	@klient_id as bigint,
	@status as int output 	--1- не хватает денег у клиента 2 -не хватает денег у Кремня
)
AS
declare @limit as real
declare @sublimit as real
set @sublimit=(select limit from lechenie where id=@lechenie_id)

set @limit =(select limit from klients where id=@klient_id)

 
if @sublimit>@limit	-- нет денег у клиента
begin
	set @status=1
	return
end
--set @limit =(select kremen_limit from kremen)
--if @sublimit>@limit	-- нет денег у Кремня
--begin
--	set @status=2
	--return
--end

set @status=0
GO
/****** Объект:  StoredProcedure [dbo].[SP_VidachaDetailInsert]    Дата сценария: 06/22/2016 23:30:34 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SP_VidachaDetailInsert]
(
	@vidacha_id as bigint,
	@medikament_id as bigint,
	@kolvo as int,
	@price as real,
	@status as int output
)
AS
begin tran
insert into vidachadetail(vidacha_id, medikament_id,kolvo, price) values(@vidacha_id,@medikament_id, @kolvo, @price)
-- уменьшение в аптеке!!!!!
update medikament set kolvo=kolvo-@kolvo where id=@medikament_id
set @status=0
commit tran
GO
/****** Объект:  StoredProcedure [dbo].[SP_VidachaInsert]    Дата сценария: 06/22/2016 23:30:34 ******/
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
