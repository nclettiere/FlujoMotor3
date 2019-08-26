Conexion a INFROMIX:

<p>Abrir la VM y poner el comando hostname -I, el cual dara la IP para conectarse con ODBC.</p>
<p>Poner el siguiente string en la clase ODBC del paquete DB:</p>
<p>Usando computadoras de la UTU:</p>
<p>Driver={IBM INFORMIX ODBC DRIVER};
Database=big;
Host=[comando hostname];
Server=ol_esi;
Service=9088;
Protocol=onsoctcp;
UID=root;PWD=root;</p>

<p>Usando computadoras con el driver ODBC de la pag de la utu xd:</p>
<p>Driver={IBM INFORMIX ODBC DRIVER 32/64Bits};
Database=big;
Host=[comando hostname];
Server=ol_esi;
Service=9088;
Protocol=onsoctcp;
UID=root;PWD=root;</p>
