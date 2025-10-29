@echo off  
rem oculta as linha de codigo
title numero randomicos
mode 60,30
color 0f
set /a cont=5
set /a numero=(%random% %%50)+1
:sorteio
cls
echo numero sorteado:%numero%
echo numero de tentativas:%cont%
if %numsort% equ %numero% (goto:acertou)
if %numsort% lss %numero% (goto:menor)
if %numsort% gtr %numero% (goto:maior)
if %numsort% gtr 50 (goto:erro) else (
set /p resp=novo sorteio?[S/N]
if i/ %resp% equ s (goto:sorteio) else (exit) 


:acertou
echo parabens voce acertou
echo.
pause
goto:sorteio)

:menor
echo chute um numero menor
echo.
set /a cont=%cont% -1
pause
goto:sorteio)
:maior
echo chute um numero maior
echo.
set /a cont=%cont% -1
pause
goto:sorteio)
:erro
echo você deve escrever um numero entre 1 e 50
echo.
set /a cont=%cont% -1
pause
goto:sorteio)