SET TERM ^ ;
CREATE PROCEDURE USPMANTERUNIDMEDIDA (
    ACAO integer,
    IDDAUNIDMEDIDA integer,
    DESCRICAOUNIDMEDIDA varchar(255),
    LEGENDAUNIDMEDIDA varchar(4) )
RETURNS (
    IDUNIDMEDIDA integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT DESCRICAO FROM TBLUNIDMEDIDAS WHERE upper(DESCRICAO) like upper(:DescricaoUnidMedida))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLUNIDMEDIDAS
            (DESCRICAO, LEGENDA)
            values 
            (:DescricaoUnidMedida, :LegendaUnidMedida)
            returning ID_UNIDMEDIDA into :IdUnidMedida;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF (exists(SELECT ID_UNIDMEDIDA FROM TBLUNIDMEDIDAS WHERE ID_UNIDMEDIDA like :IdDaUnidMedida)) then
             IF(Exists(SELECT DESCRICAO FROM TBLUNIDMEDIDAS WHERE upper(DESCRICAO) = upper(:DescricaoUnidMedida) AND ID_UNIDMEDIDA <> :IdDaUnidMedida)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLUNIDMEDIDAS
                set DESCRICAO = :DescricaoUnidMedida,
                    LEGENDA   = :LegendaUnidMedida
                where (ID_UNIDMEDIDA like :IdDaUnidMedida)
                returning ID_UNIDMEDIDA into :IdUnidMedida;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT DESCRICAO FROM TBLUNIDMEDIDAS WHERE ID_UNIDMEDIDA like :IdDaUnidMedida)) then
         delete from TBLUNIDMEDIDAS
         where (ID_UNIDMEDIDA like :IdDaUnidMedida)
        returning ID_UNIDMEDIDA into :IdUnidMedida;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^