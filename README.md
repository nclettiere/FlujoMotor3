# FlujoMotor


### Explicacion CSV

Operario

| Operario ID | Nombre | Apellido | usuario | password | Fecha | Tipo(puerto,operario) | Operario ID |
| ----------- | ------ | -------- | ------- | -------- | ----- | --------------------- | ----------- |
| 0           | 1      | 2        | 3       | 4        | 5     | 6                     | 7           |

Vehiculo

| VIN | Marca | Modelo | Tipo | Color | Fecha | Cant. Inspecciones | OperarioID | UbicacionID | Cliente |
| --- | ----- | -------| ---- | ----- | ----- | ------------------ | ---------- | ----------- | ------- |
| 0   | 1     | 2      | 3    | 4     | 5     | 6                  | 7          | 8           | 9       |

Patio

| Patio ID | Nombre | Latitud | Longitud |
| -------- | ------ | ------- | -------- |
| 0        | 1      | 2       | 3        |


Ubucacion

| UbicacionID | Latitud | Longitud | Status | PatioID |
| ----------- | ------- | -------- | ------ | ------- |
| 0           | 1       | 2        | 3      | 4       |

Inspeccion

| InspeccionID | VINRef  | Descripcion | OperarioID | Fecha |
| ------------ | ------- | ----------- | ---------- | ----- |
| 0            | 1       | 2           | 3          | 4     |
 
Cliente

| ClienteID | Nombre  | Apellido |
| --------- | ------- | -------- |
| 0         | 1       | 2        |
 
