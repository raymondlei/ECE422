
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

// FBS
#pragma config BWRP = OFF
#pragma config BSS = OFF

// FGS
#pragma config GWRP = OFF
#pragma config GCP = OFF

// FOSCSEL
#pragma config FNOSC = FRC
#pragma config IESO = ON

// FOSC
#pragma config POSCMOD = NONE
#pragma config OSCIOFNC = ON
#pragma config POSCFREQ = HS
#pragma config SOSCSEL = SOSCHP
#pragma config FCKSM = CSDCMD

// FWDT
#pragma config WDTPS = PS32768
#pragma config FWPSA = PR128
#pragma config WINDIS = OFF
#pragma config FWDTEN = OFF

// FPOR
#pragma config BOREN = BOR3
#pragma config PWRTEN = ON
#pragma config I2C1SEL = PRI
#pragma config BORV = V18
#pragma config MCLRE = ON

// FICD
#pragma config ICS = PGx1
#pragma config BKBUG = OFF

// FDS
#pragma config DSWDTPS = DSWDTPSF
#pragma config DSWDTOSC = LPRC
#pragma config RTCOSC = SOSC
#pragma config DSBOREN = ON
#pragma config DSWDTEN = ON


void delay(void);

unsigned int ctr = 0;
unsigned int delayVal = 2048;

int main(void)
{
    LATB = 0;
    TRISB = 0x7FFF;

    while(1)
    {
        LATB = 0x8000;
        delay();

        LATB = 0x0000;
        delay();

        ctr++;
    }
}

void delay(void)
{
    unsigned int i,j;

    for (i = 0; i < delayVal; i++)
    {
        for (j = 0; j < 20; j++);
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
