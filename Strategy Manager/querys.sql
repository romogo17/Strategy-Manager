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


--Ejemplo de data link
create database link testlink_db2
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

 --Funcion para conseguir las estrategias
 create or replace function get_strategy(strategy in varchar2)
    return SYS_REFCURSOR IS
    cr SYS_REFCURSOR;
   BEGIN
    OPEN cr FOR SELECT * FROM STRATEGY WHERE connection = strategy;
    RETURN cr;
   END;
   /