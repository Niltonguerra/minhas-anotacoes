@echo off
title - trabalho1
mode 60, 30
color 0a

:inicio
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
echo ---login---

set/p user=Usuario:
if /i %user% == fatec (goto:pass) else (
echo.
echo ---------------
echo opcao invalida!
echo ---------------
pause
goto:inicio)
:pass
set/p pwd=Senha:
if %pwd% == 123 (call menu_principal.bat) else (
echo.
echo ---------------
echo opcao invalida!
echo ---------------
pause
goto:inicio)