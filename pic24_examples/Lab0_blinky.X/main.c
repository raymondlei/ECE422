
/*
 * Training - Fundamentals of C Programming - by Microchip Developer Help
 * http://microchipdeveloper.com/tls2101:start
 * 
 * Tour of MPLAB X User Interface
 * http://microchipdeveloper.com/tls0101:parts-of-the-ide
 * 
 * Microchip Tutorial on creating a project
 * http://microchipdeveloper.com/tls0101:lab1
 * 
 */

#include <xc.h>

#pragma config FNOSC = FRC
#pragma config OSCIOFCN = OFF
#pragma config SOSCSEL = OFF
#pragma config PLLSS = PLL_FRC
#pragma config IESO = OFF
#pragma config ICS = PGD2
#pragma config JTAGEN = OFF
#pragma config BOREN = OFF
#pragma config FWDTEN = OFF


void delay(void);

unsigned int ctr = 0;
unsigned int delayVal = 2048;

int main(void)
{
    LATA = 0;
    TRISA = (0xFFFF & (~0x0300));

    while(1)
    {
        LATA = 0x0300;
        delay();

        LATA = 0x0000;
        delay();

        ctr++;
    }
}

void delay(void)
{
    unsigned int i,j;

    for (i = 0; i < delayVal; i++)
    {
        for (j = 0; j < 100; j++);
    }
}

/**********************************************************************
* © 2013 Microchip Technology Inc.
* SOFTWARE LICENSE AGREEMENT:
* Microchip Technology Inc. (Microchip) licenses this software to you
* solely for use with Microchip dsPIC digital signal controller
* products. The software is owned by Microchip and is protected under
* applicable copyright laws.  All rights reserved.
*
* SOFTWARE IS PROVIDED AS IS.  MICROCHIP EXPRESSLY DISCLAIMS ANY
* WARRANTY OF ANY KIND, WHETHER EXPRESS OR IMPLIED, INCLUDING BUT NOT
* LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
* PARTICULAR PURPOSE, OR NON-INFRINGEMENT. IN NO EVENT SHALL MICROCHIP
* BE LIABLE FOR ANY INCIDENTAL, SPECIAL, INDIRECT OR CONSEQUENTIAL
* DAMAGES, LOST PROFITS OR LOST DATA, HARM TO YOUR EQUIPMENT, COST OF
* PROCUREMENT OF SUBSTITUTE GOODS, TECHNOLOGY OR SERVICES, ANY CLAIMS
* BY THIRD PARTIES (INCLUDING BUT NOT LIMITED TO ANY DEFENSE THEREOF),
* ANY CLAIMS FOR INDEMNITY OR CONTRIBUTION, OR OTHER SIMILAR COSTS.
**********************************************************************/
