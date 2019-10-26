@echo off

REM Script Para copiar archvos dll al output de las aplicaciones.
REM Detecta si se esta buildeando el proyecto en x86 o x64 y
REM Copia los archivos necesarios.

set  Plataforma=%1
set  Directorio=%2

if not exist "CefSharp\" (
	echo No se detecto la carpeta CefSharp. Descargue y coloquela en la raiz del proyecto.
	cmd /c start "" "https://drive.google.com/uc?export=download&confirm=KtxW&id=1r2qRPtG7ev_etdiRNykYxoITVAVf4SX5"
)

IF %Plataforma% == "x86" (
	echo La Plataforma es de 32bits
	pushd %~dp0
	xcopy "CefSharp\x86" %Directorio% /Y /I
	EXIT 0
)

IF %Plataforma% == "x64" (
	echo La Plataforma es de 64bits
	pushd %~dp0
	xcopy "CefSharp\x64" %Directorio% /Y /I
	EXIT 0
)

IF %Plataforma% == "AnyCPU" (
	cls
	echo.
	echo.
	echo.
	echo.
	echo.
	echo :::[ERROR]^=^> Plataforma Invalida. La ejecucion del binario dara una excepcion como resultado. Elija x64 o x86 para solucionar este problema.
	echo.
	echo.
	echo.
	echo.
	echo.
	EXIT 3
)