@echo off  
rem oculta as linha de codigo
title Gerenciamento de arquivo
mode 60,30
color 0f
:inicio
cls
echo.
echo ---------------
echo Gerenciamento de Arquivos
echo ---------------
echo [1] Gerar Arquivos Diversos
echo [2] organizar Arquivos em pastas
echo [3] ocultar pastas/arquivos
echo [4] exibir pastas/ arquivos
echo [e] emcerrar script
echo ---------------
echo.
set /p op=digite a opcao desejada:
if %op% equ 1 (goto:gerar)
if %op% equ 2 (goto:organizar)
if %op% equ 3 (goto:ocultar)
if %op% equ 4 (goto:exibir)
if /i %op% equ e (goto:sair) else (
echo.
echo ----------
echo Opcao invalida!
echo ----------
echo.
pause
goto:incio)

:gerar
set /p arq=digite o nome do arquivo :
set /p qtd=digite a quantidade:
set /p ext=digite a extensão do arquivo:
for /L %%n in (1,1,%qtd%) do echo Fatec > %arq%%%n.%ext%
echo.
echo -----------------
echo Arquivos Gerados com sucesso!
echo -----------------
echo.
pause
goto:inicio


:organizar
set /p pasta=Digite o nome da pasta a ser criada:
set /p ext=digite a extensão do arquivo:
md %pasta%
move *.%ext% C:\Users\lab5\Desktop\%pasta%\
echo.
echo ------------------------
echo finalizado
echo --------------------- 
echo.
pause
goto:inicio

:ocultar
c:
cd\Users\lab5\Desktop
set /p pasta=Digite a pasta a ser ocultada:
attrib %pasta% +r +h
echo.
echo ------------------------
echo finalizado
echo --------------------- 
echo.
pause
goto:inicio

:exibir
c:
cd\Users\lab5\Desktop
set /pasta=Digite a pasta a ser exibida:
attrib %pasta% -r -h
echo.
echo ------------------------
echo finalizado
echo --------------------- 
echo.
pause
goto:inicio