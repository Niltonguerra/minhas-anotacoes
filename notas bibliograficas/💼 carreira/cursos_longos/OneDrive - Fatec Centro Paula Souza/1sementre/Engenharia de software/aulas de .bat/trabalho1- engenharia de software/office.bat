@echo off
title - trabalho1
mode 60, 30
color 0a


:office
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
echo [W] ORD
echo [E] XCEL
echo [A] CCESS
echo [P] OWER POINT
echo [R] ETORNAR AO MENU
echo --------------------

echo.

set/p var=Digite sua opcao:

if /i %var% == W (goto:texto)
if /i %var% == E (goto:planilha)
if /i %var% == A (goto:access)
if /i %var% == P (goto:power_point)
if /i %var% == R (call menu_principal.bat) else (
echo.
echo ---------------
echo opcao invalida!
echo ---------------
pause
goto:office)



:texto
start winword.exe
goto:office

:planilha
start excel.exe
goto:office

:access
start msaccess.exe
goto:office

:power_point
start powerpnt.exe
goto:office