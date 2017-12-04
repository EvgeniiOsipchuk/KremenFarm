USE [KremenReal]
GO
/****** Объект:  StoredProcedure [dbo].[SP_AnalizKlient]    Дата сценария: 06/22/2016 23:47:03 ******/
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
