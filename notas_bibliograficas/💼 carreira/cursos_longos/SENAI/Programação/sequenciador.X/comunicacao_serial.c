
#include "config.h"
#include <xc.h>
#include "delay.h"

#define     clk              PORTBbits.RB0
#define     shLd             PORTBbits.RB1
#define     D0               PORTDbits.RD0
#define     mask             0000 0001


void comun__init ()
{
TRISDbits.TRISD0 = 0;
TRISDbits.TRISD1 = 0;
TRISDbits.TRISD2 = 0;

PORTDbits.RD0 = 0;
PORTDbits.RD1 = 0;
PORTDbits.RD2 = 0;
}
 
//void Comun__serial(char num)      
//  {
//    if (num == 1)
//    {
//    sd = 1;
//    sh = 1;
//    delay(300);
//    sh = 0;
//    delay(300);
//    st = 1;
//    delay (300);
//    st = 0;
//    }
//    else if (num == 0)
//    {
//    sd = 1;
//    sh = 0;
//    delay(300);
//    sh = 0;
//    delay(300);
//    st = 1;
//    delay (300);
//    st = 0;   
//  }
// }


void comunicacao_saida ()
{
    ANSELH = 0;
    TRISDbits.TRISD0 = 1;
    TRISBbits.TRISB0 = 0;
    TRISBbits.TRISB1 = 0;
}

 char bits [8];

void funcao ()
{
    shLd = 1;
    char i = 0;
    for ( i = 0 ; i <= 7; i++ )
    {
        
        clk = 1; delay(10); clk = 0; delay(10);     //ativação e desativação do CLK
        D0 = bits[8] & (mask<<i);
    
    }
    
}



