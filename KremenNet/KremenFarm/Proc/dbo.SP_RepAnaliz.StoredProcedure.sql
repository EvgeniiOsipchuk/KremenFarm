/****** Îáúåêò:  StoredProcedure [dbo].[SP_RepAnaliz]    Äàòà ñöåíàğèÿ: 06/22/2016 23:47:06 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RepAnaliz]
(
	@date_start as datetime,
	@date_end as datetime,
	@bol_id as int,  
    @id_report as int		-- Ïğåäïğèÿòèå

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
