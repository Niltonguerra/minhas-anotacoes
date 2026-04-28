@echo off  
rem oculta as linha de codigo
title Estrutura de repetição
mode 60,30
color 0f
:inicio
cls
set /p ni = Digite o numero inicial:
set /p inc = Digite o incremento:
set /p nf = Digite o numero final:
for /L %%n in (%ni%, %inc%, %nf%) do echo numero: %%n
echo.
echo -------------
echo Fim do programa!
echo ------------
echo.
pause