/*
 * File:   main.c
 * Author: josewrpereira
 *
 * Created on 24 de Junho de 2021, 12:35
 */

#include "config.h"
#include <xc.h>
#include "delay.h"
#include "ihm.h"
#include "timers.h"
#include "sensor.h"
#include "lcd.h"
#include "keyboard.h"
void main(void)
{   
    
   char tecla; 
    keyboard_init();
    IHM.init();
    while (1)
    { 
        tecla = keyboard();
        dispLCD_num(1,1,tecla);
    }
    
}
