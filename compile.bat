@echo off

REM Script Para copiar archvos dll al output de las aplicaciones.
REM Detecta si se esta buildeando el proyecto en x86 o x64 y
REM Copia los archivos necesarios.

set  Plataforma=%1
set  Directorio=%2


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
	echo Plataforma Invalida. La ejecucion del binario dara una excepcion como resultado. Elija x64 o x86 para solucionar este problema.
	EXIT 3
)