/****** Объект:  StoredProcedure [dbo].[SP_delit]    Дата сценария: 06/22/2016 23:47:03 ******/
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
