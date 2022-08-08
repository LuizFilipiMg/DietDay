CREATE TABLE tblUsuarios (
 Id SMALLINT,
 Nome VARCHAR(40) NOT NULL,
 Email VARCHAR(60)NOT NULL,
 Telefone VARCHAR(60),
 Ddd varchar(10),
 Senha varchar(20)NOT NULL,
 Documento VARCHAR(20),
 TipoDocumento SMALLINT,
 DataHora Smalldatetime,
 Ativo bit
 CONSTRAINT pk_Id  PRIMARY KEY (Id)
 );