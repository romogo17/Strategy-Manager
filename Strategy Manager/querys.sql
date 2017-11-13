create tablespace
	backup_metadata
datafile
 	'C:\ORACLEXE\APP\ORACLE\ORADATA\XE\backup_metadata.dbf'
size
 	50m
AUTOEXTEND ON NEXT 10M MAXSIZE 200M;

create table connection (
	conn_id varchar2(25) not null,
	conn_name varchar2(70) not null,
	database_instance varchar2(70) not null,
	ip varchar2(70) not null,
	port varchar2(6) default '1521' not null,
	alive number(1) default 1 not null,
	CONSTRAINT connection_pk PRIMARY KEY (conn_id)
) tablespace backup_metadata;

create table strategy (
	strategy_id varchar2(25) not null, -- puede corresponder al tiempo UNIX, asi se garantiza que no se repita
	connection varchar2(70) not null,
	priority varchar2(6) null, -- high, medium, low
	alive number(1) default 1 not null,
	CONSTRAINT strategy_pk PRIMARY KEY (strategy_id),
	CONSTRAINT strategy_fk FOREIGN KEY (connection) REFERENCES connection(conn_id)
) tablespace backup_metadata;

create table strategy_line (
	strategy_id varchar2(25) not null, -- puede corresponder al tiempo UNIX, asi se garantiza que no se repita
	numline int,
	line varchar2(255) null,
	CONSTRAINT strategy_line_fk FOREIGN KEY (strategy_id) REFERENCES strategy(strategy_id)
) tablespace backup_metadata;

create table frequency (
	strategy_id varchar2(25) not null, -- puede corresponder al tiempo UNIX, asi se garantiza que no se repita
	day int not null, -- day of the week, 0 if it's everyday
	hour int not null,
	minutes int not null,
	CONSTRAINT frequency_fk FOREIGN KEY (strategy_id) REFERENCES strategy(strategy_id)
) tablespace backup_metadata;

create table log (
	strategy_id varchar2(25) not null, -- puede corresponder al tiempo UNIX, asi se garantiza que no se repita
	moment TIMESTAMP default CURRENT_TIMESTAMP not null,
	log CLOB,
	CONSTRAINT log_fk FOREIGN KEY (strategy_id) REFERENCES strategy(strategy_id)
) tablespace backup_metadata;

create table error (
	strategy_id varchar2(25) not null, -- puede corresponder al tiempo UNIX, asi se garantiza que no se repita
	moment TIMESTAMP default CURRENT_TIMESTAMP not null,
	message varchar2(255),
	CONSTRAINT error_fk FOREIGN KEY (strategy_id) REFERENCES strategy(strategy_id)
) tablespace backup_metadata;
---------------------------------------------INSERTS PRUEBA----------------------------------------------------

insert into connection(conn_id, conn_name, database_instance, ip)
values ('C_1509986176','local','XE','127.0.0.1');

insert into strategy(strategy_id, connection, priority)
values ('EST_1509986176','C_1509986176','MEDIUM');

insert into strategy(strategy_id, connection, priority)
values ('EST_1509986176','C_MexicoDB1','MEDIUM');
insert into strategy(strategy_id, connection, priority)
values ('EST_1509986180','C_1509986176','MEDIUM');

insert into strategy_line(strategy_id, line) values 
('EST_1509986176','crosscheck archivelog all;');
insert into strategy_line(strategy_id, line) values 
('EST_1509986176','run{');
insert into strategy_line(strategy_id, line) values 
('EST_1509986176','SQL "alter system switch logfile";');
insert into strategy_line(strategy_id, line) values 
('EST_1509986176','backup tablespace users;');
insert into strategy_line(strategy_id, line) values 
('EST_1509986176','}');

insert into frequency(strategy_id, day, hour, minutes)
values ('EST_1509986176', 1, 12, 35);
insert into frequency(strategy_id, day, hour, minutes)
values ('EST_1509986180', 1, 12, 35);

 --Funcion para conseguir las bases de datos
 CREATE OR REPLACE FUNCTION get_database
  RETURN SYS_REFCURSOR IS
	cr SYS_REFCURSOR;
  BEGIN
    OPEN cr FOR SELECT * FROM connection;
    RETURN cr;
  END;
/ 
--Procedimiento para insertar una conexion
CREATE OR REPLACE PROCEDURE insert_connection(id in varchar2, nombreServidor in varchar2,baseDatos in varchar2,ipBase in varchar2,puertoBase in varchar2,alive in number)
  IS
  BEGIN
    insert into connection values (id,nombreServidor,baseDatos,ipBase,puertoBase,alive);
    COMMIT;

   EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
  END;
/

--Procedimiento para actualizar una conexion
CREATE OR REPLACE PROCEDURE update_connection(ipBase in varchar2, puertoBase in varchar2,aliveBase in number,id in varchar2)
  IS
  BEGIN
    update connection set IP = ipBase ,PORT = puertoBase, ALIVE = aliveBase where conn_id = id;
    COMMIT;

   EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
  END;
/

--Procedimiento para insertar una estrategia
CREATE OR REPLACE PROCEDURE insert_strategy(name in varchar2, connection in varchar2, priori in varchar2)
   IS
   BEGIN
      insert into strategy(strategy_id, connection, priority) values (name, connection, priori);
      COMMIT;
      EXCEPTION
       WHEN OTHERS THEN ROLLBACK;
END;
/
--Procedimiento para actualizar una estrategia
CREATE OR REPLACE PROCEDURE update_strategy(name in varchar2, connection1 in varchar2, priori in varchar2,alive1 in number)
   IS
   BEGIN
      update strategy set connection=connection1, priority=priori ,alive=alive1 where strategy_id=name;
      COMMIT;
      EXCEPTION
       WHEN OTHERS THEN ROLLBACK;
END;
/
 --Funcion para conseguir las estrategias
create or replace function get_strategy(strategy in varchar2)
   return SYS_REFCURSOR IS
   cr SYS_REFCURSOR;
    BEGIN
     OPEN cr FOR SELECT * FROM STRATEGY WHERE connection = strategy;
     RETURN cr;
   END;
/

 --Funcion para conseguir los logs de las estrategias
create or replace function get_log(strategy in varchar2)
   return SYS_REFCURSOR IS
   cr SYS_REFCURSOR;
    BEGIN
     OPEN cr FOR SELECT * from log STRATEGY WHERE strategy_id =strategy ;
     RETURN cr;
   END;
/
 --Funcion para conseguir cantidad de logs de una estrategia
create or replace function get_logCount(strategy in varchar2)
   return number IS
   countLogs number;
    BEGIN
      SELECT count(*) into countLogs from log STRATEGY WHERE strategy_id =strategy ;
     RETURN countLogs;
   END;
/
--Function para conseguir los errores de las estrategias
create or replace function get_Error(strategy in varchar2)
   return SYS_REFCURSOR IS
   cr SYS_REFCURSOR;
    BEGIN
     OPEN cr FOR SELECT * from error STRATEGY WHERE strategy_id =strategy ;
     RETURN cr;
   END;
/

--Procedimiento para insertar las lines de la estrategia
CREATE OR REPLACE PROCEDURE insert_strategyline(strategy_id in varchar2, nline in int, line in varchar2)
  IS
  BEGIN
    insert into strategy_line(strategy_id,numline,line) values (strategy_id, nline, line);
    COMMIT;

    EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
  END;
/
--Procedimiento para insertar una lineaEstrategiaRemota (No sirve)
CREATE OR REPLACE PROCEDURE insert_strategyline(strategy_id in varchar2, nline in int, line in varchar2)
  IS
  varchar2 D:='insert into strategy_line@' ||  values (strategy_id, nline, line);
  BEGIN
    insert into strategy_line(strategy_id,numline,line) values (strategy_id, nline, line);
    COMMIT;

    EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
  END;
/
--Procedimiento para insertar una estrategiaRemota (No sirve)
CREATE OR REPLACE PROCEDURE insert_strategyRemote(name in varchar2, connection in varchar2, priori in varchar2)
   IS
   BEGIN
      Execute inmedita 'insert into strategy@' || connection || ' values(''' || name || ''',''' || connection || ''',''' || priori || ''')';
	  COMMIT;
      EXCEPTION
       WHEN OTHERS THEN ROLLBACK;
END;
/
--Procedimiento para actualizar una estrategiaRemota 
CREATE OR REPLACE PROCEDURE update_strategyRemote(name in varchar2, connection in varchar2, priori in varchar2,alive1 in number)
IS   
   BEGIN
   EXECUTE IMMEDIATE 'update strategy@'||connection|| ' set alive=' || alive1 ||' where strategy_id=''' || name ||'''';
   COMMIT;
      EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
     
END;
/
--Ejemplo de data link
create database link TEST
connect to system identified by manager
using
'(DESCRIPTION=
(ADDRESS=
(PROTOCOL=TCP)
(HOST=10.2.10.18)
(PORT=1525))
(CONNECT_DATA=
(SERVER = DEDICATED)
(SERVICE_NAME = XE)))'
 /

--Procedimiento para insertar las frecuencias
CREATE OR REPLACE PROCEDURE insert_frequency(strategy_id in varchar2, d in int, h in int, m in int)
  IS
  BEGIN
    insert into frequency(strategy_id,day,hour,minutes) values (strategy_id, d, h, m);
    COMMIT;

    EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
  END;
/

--Estructura Scripts
--BACKUP CURRENT CONTROLFILE              Control
--BACKUP SPFILE                           spfile
--BACKUP ARCHIVELOG ALL           		  LOGS
--BACKUP TABLESPACE NOMBRE_TABLESPACE     TABLESPACE

--BACKUP DATABASE                         TODOS LOS DATAFILES //incluye control y pfile

--BACKUP INCREMENTAL LEVEL 1 DATABASE;    INCREMENTAL         //incluye control y pfile
--BACKUP INCREMENTAL LEVEL 0 DATABASE;	  INCREMENTAL		  //incluye control y pfile

--Procedimiento insert coneccion remotas
CREATE OR REPLACE PROCEDURE insert_connectionRemote(id in varchar2, nombreServidor in varchar2,baseDatos in varchar2,ipBase in varchar2,puertoBase in varchar2,alive in number)
  IS
  BEGIN	
      EXECUTE IMMEDIATE 'insert into connection@' || id || ' values(''' || id || ''',''' || nombreServidor || ''',''' || baseDatos || ''',''' || ipBase || ''',''' || puertoBase || ''',' || alive || ')';
	  COMMIT; --Necesito que esto me tira la EXCEPTION si falla para poder comprobar la conexion
  END;
/
--Procedimiento para bajar un datalink
CREATE OR REPLACE PROCEDURE dropDL(name in varchar2)
   IS   
   BEGIN
   --EXECUTE IMMEDIATE 'ALTER SESSION CLOSE DATABASE LINK ' || name;
   EXECUTE IMMEDIATE 'drop database link ' || name;
   COMMIT;   
END;
/
--Procedimiento para eliminar una conexion remotam
CREATE OR REPLACE PROCEDURE delete_connectionRemote(id in varchar2)
IS   
   BEGIN
   EXECUTE IMMEDIATE 'delete from connection@' || id || ' where CONN_ID=''' || id ||'''';
   COMMIT;
      EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
END;
/
--Procedimientos para borrar estrategias que no se hayan ejecutado

CREATE OR REPLACE PROCEDURE delete_frequencyRemote(strategy_id in varchar2,connection1 in varchar2)
IS   
   BEGIN
   EXECUTE IMMEDIATE 'delete from frequency@' || connection1 || ' where STRATEGY_ID=''' || strategy_id ||'''';
   COMMIT;
      EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
END;
/
CREATE OR REPLACE PROCEDURE delete_strategyLineRemote(strategy_id in varchar2,connection1 in varchar2)
IS   
   BEGIN
   EXECUTE IMMEDIATE 'delete from strategy_line@' || connection1 || ' where STRATEGY_ID=''' || strategy_id ||'''';
   COMMIT;
      EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
END;
/
CREATE OR REPLACE PROCEDURE delete_strategyRemote(strategy_id in varchar2,connection1  in varchar2)
IS   
   BEGIN
   EXECUTE IMMEDIATE 'delete from strategy@' || connection1 || ' where STRATEGY_ID=''' || strategy_id ||'''';
   COMMIT;
      EXCEPTION
     WHEN OTHERS THEN ROLLBACK;
END;
/