# FlujoMotor
Repositorio Oficial de FlujoMotor por ESPI Solutions.

<img src="https://i.imgur.com/wf31bpF.png" alt="ESPI Solutions" width="150" height="150">

- [Link librerias CefSharp - https://drive.google.com/open?id=1r2qRPtG7ev_etdiRNykYxoITVAVf4SX5](https://drive.google.com/open?id=1r2qRPtG7ev_etdiRNykYxoITVAVf4SX5)

### :heavy_exclamation_mark: Para el primer uso
1. Modificar el archivo '_conexioninformix.yaml_' a las configuraciones de su maquina virtual y su ODBC.
2. <p>Cambiar la arquitectura del programa. Ya sea x86 como x64 (depende del driver de ODBC/PuTTy).</p> <p>*Si cambia a x64 o x86 y no compila, intente cambiar la arquitectura en cada proyecto, Click derecho sobre el proyecto -> Propiedades -> Tab Compilado -> Arquitectura</p>
3. Si ya habia compilado el programa y modifica el archivo  '_conexioninformix.yaml_', entonces debe hacer un *clean* a la solucion y hacer un rebuild entero para que se actualice el archivo.
4. Las contrasenas para todos los operarios/transportistas/administradores es: USR=> root PASWD=> root.

### :pushpin: Tareas | TODO

<ul>
  <li>Idiomas</li>
  <li>Arreglar UI de verdanios</li>
  <li>Actualizar en op patio no funca</li>
  <li>Modificar V. cuando es lanzado en verV no funca</li>
  <li>Fix size of login in FlujoRuedas</li>
  <li>Agregar mod user in admin</li>
  <li>Fix error al aparcar vehiculo en op patio</li>
  <li>Fix cef instance en App Operarios</li>
  <li><b>Meh</b></li>
</ul>



### :large_blue_diamond: Caracteristicas

- [x] Soporta tanto x64 como x86.
- [x] Tres proyectos separados uno de otro, con una relacion al proyecto _Logica_ y _DB_.

### :recycle: Librerias ThirdParty (vease los dll's)
- [Serilog - By Contributors of The Project](https://serilog.net/)
- [QRCoder - codebude](https://github.com/codebude/QRCoder)
