@echo off
title - trabalho1
mode 60, 30
color 0a


:windows
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
echo ---windows---
echo [C] CALCULADORA
echo [T] ECLADO VIRTUAL
echo [W] INDOWS EXPLORER
echo [P] AINT
echo [B] LOCO DE NOTAS
echo [R] ETORNAR AO MENU
echo --------------------

echo.

set/p var=Digite sua opcao:

if /i %var% == C (goto:calculadora)
if /i %var% == T (goto:teclado)
if /i %var% == W (goto:microsoft_explorer)
if /i %var% == P (goto:paint)
if /i %var% == B (goto:bloco_notas)
if /i %var% == R (call menu_principal.bat) else (
echo.
echo ---------------
echo opcao invalida!
echo ---------------
pause
goto:windows)



:microsoft_explorer
start explorer.exe
goto:windows

:calculadora
start calc.exe
goto:windows

:teclado
start osk.exe
goto:windows

:paint
start mspaint.exe
goto:windows

:bloco_notas
start notepad.exe
goto:windows