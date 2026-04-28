@echo off  
rem oculta as linha de codigo
title numero randomicos
mode 60,30
color 0f
set /a cont=0
:sorteio
cls
set /a numero=(%random% %%100)+1
set /a cont=%cont% +1
echo.
echo ---------------
echo Numero sorteado: %numero%
echo Quantidade de sorteios:%cont%
echo --------------
echo.
sey /p resp=novo sorteio?[S/N]
if i/ %resp% equ s (goto:sorteio) else (exit) 