/****** Объект:  StoredProcedure [dbo].[SP_RepVidacha]    Дата сценария: 06/22/2016 23:47:06 ******/
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
