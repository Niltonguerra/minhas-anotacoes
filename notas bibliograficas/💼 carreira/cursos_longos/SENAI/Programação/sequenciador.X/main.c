#include "config.h"
#include <xc.h>
#include "delay.h"
#include "ihm.h"
#include "timers.h"
#include "sensor.h"
#include "lcd.h"
#include "keyboard.h"
#include "comunicacao_serial.h"
void main(void)
{   
 comunicacao_saida ();
 IHM.init();
 
              
            
    while ( 1 )
         {
        IHM.print( funcao());

         
     
         }
 
    
}
