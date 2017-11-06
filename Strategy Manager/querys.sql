CREATE OR REPLACE FUNCTION get_database
  RETURN SYS_REFCURSOR IS
	cr SYS_REFCURSOR;
  BEGIN
    OPEN cr FOR SELECT * FROM CONEXIONES;
    RETURN cr;
  END;
/

create table CONEXIONES(
	baseDatos varchar2(20),
	servidor varchar2(20),
	ip varchar2(20),
	puerto varchar2(20),
	alive char,
	CONSTRAINT pk_baseDatos PRIMARY KEY (baseDatos,servidor)
);
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