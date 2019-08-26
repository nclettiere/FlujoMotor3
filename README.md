Conexion a INFROMIX:

1. Abrir la VM y poner el comando hostname -I, el cual dara la IP para conectarse con ODBC.
2. Colocar el siguiente string en la clase ODBC del proyecto.
2.a Usando computadoras de la UTU:
        Driver={IBM INFORMIX ODBC DRIVER};
        Database=big;
        Host=[comando hostname];
        Server=ol_esi;
        Service=9088;
        Protocol=onsoctcp;
        UID=root;PWD=root;"
2.b Usando coputadoras con el driver de la pag de la esi:
        Driver={IBM INFORMIX ODBC DRIVER 64/32Bits};
        Database=big;
        Host=[comando hostname];
        Server=ol_esi;
        Service=9088;
        Protocol=onsoctcp;
        UID=root;PWD=root;"
