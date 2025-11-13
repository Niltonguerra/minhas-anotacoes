@echo off
title - trabalho1
mode 60, 30
color 0a


:serv_rede
cls

echo.

echo #######    ##     ######   #######    ####
echo  ##   #   ####    # ## #    ##   #   ##  ##
echo  ## #    ##  ##     ##      ## #    ##
echo  ####    ##  ##     ##      ####    ##
echo  ## #    ######     ##      ## #    ##
echo  ##      ##  ##     ##      ##   #   ##  ##
echo ####     ##  ##    ####    #######    ####
echo.
echo.
echo ---OFFICE---
echo [N] AVERGAR INTERNET
echo [T] ESTAR INTERNET
echo [O] BTER IP DA MAQUINA
echo [R] ETORNAR AO MENU
echo --------------------

echo.

set/p var=Digite sua opcao:

if /i %var% == N (goto:navegador)
if /i %var% == T (goto:teste)
if /i %var% == O (goto:ip_maquina)
if /i %var% == R (call menu_principal.bat) else (
echo.
echo ---------------
echo opcao invalida!
echo ---------------
pause
goto:serv_rede)



:navegador
echo.
set/p site= digite uma endereço web:
start %site%
goto:serv_rede


:teste
echo.
set /p conexao= digite o ip da maquina ou endereço web:
ping %conexao% -t 
pause
goto:serv_rede

:ip_maquina
echo.
Ipconfig/all 
pause
goto:serv_rede