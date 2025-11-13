@echo off
title - trabalho1
mode 60, 30
color 0a


:menu
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
echo ---menu principal---
echo [P] PACOTE OFFICE
echo [S] ERVICOS DE REDE
echo [A] PLICATIVOS WINDOWS
echo [E] NCERRAR SESSAO
echo [F]FINALIZAR PROGRAMA
echo --------------------

echo.

set/p var=Digite sua opcao:

if /i %var% == A (call windows.bat)
if /i %var% == S (call serv_rede.bat)
if /i %var% == P (call office.bat)
if /i %var% == E (call login.bat)
if /i %var% == F (goto:sair) else (
echo.
echo ---------------
echo opcao invalida!
echo ---------------
pause
goto:menu)




:sair
echo.
set /p resp=deseja sair? [S/N]
if /i %resp% == s (exist) else (goto::menu)