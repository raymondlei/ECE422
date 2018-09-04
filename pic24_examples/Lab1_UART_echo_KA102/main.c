
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
 * Filename: main.c
 * 
 * Description: Demonstrate UART peripherals. Echo incoming characters
 * 
 * Author: Peng Lei
 * 
 * Date: 2018-09-04
 * 
 * Revision Log:
 * 2018-09-04    Initial project is built on LED blinky example.
 * 
 */

#include <stdint.h>

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


#define UART1_DataReady  (U1STAbits.URXDA == 1)

void delay(void);

unsigned int ctr = 0;
unsigned int delayVal = 2048;

static void UART1_init(void);
static uint8_t UART1_Read(void);
static void UART1_Write(uint8_t txData);

int main(void)
{
    uint8_t rx_char = 'U';
    
    /****************************************************************************
     * Setting the Output Latch SFR(s)
     ***************************************************************************/
    LATB = 0x8000;

    /****************************************************************************
     * Setting the GPIO Direction SFR(s)
     ***************************************************************************/
    TRISB = 0x7F7F;

    /****************************************************************************
     * Setting the Analog/Digital Configuration SFR(s)
     ***************************************************************************/
    AD1PCFG = 0x0010;

    UART1_init();
    UART1_Write(rx_char);
    
    while(1)
    {
        LATB = 0x8000;
        delay();

        LATB = 0x0000;
        delay();
        
        if(UART1_DataReady)
        {
            rx_char = UART1_Read();
            UART1_Write(rx_char);
        }

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

static void UART1_init(void)
{
    /**    
     Set the UART1 module to the options selected in the user interface.
     Make sure to set LAT bit corresponding to TxPin as high before UART initialization
     */
    
    // STSEL 1; IREN disabled; PDSEL 8N; UARTEN enabled; RTSMD disabled; USIDL disabled; WAKE disabled; ABAUD disabled; LPBACK disabled; BRGH enabled; RXINV disabled; UEN TX_RX; 
    // Data Bits = 8; Parity = None; Stop Bits = 1;
    U1MODE = (0x8008 & ~(1<<15));  // disabling UARTEN bit
    // UTXISEL0 TX_ONE_CHAR; UTXINV disabled; OERR NO_ERROR_cleared; URXISEL RX_ONE_CHAR; UTXBRK COMPLETED; UTXEN disabled; ADDEN disabled; 
    U1STA = 0x00;
    // BaudRate = 19200; Frequency = 16000000 Hz; BRG 207; 
    U1BRG = 25;    //(FCY / (16 * BAUD_RATE_UART1)) - 1;
    
    U1MODEbits.UARTEN = 1;  // enabling UARTEN bit
    U1STAbits.UTXEN = 1; 
}

static uint8_t UART1_Read(void)
{
    while(!(U1STAbits.URXDA == 1))
    {
        
    }

    if ((U1STAbits.OERR == 1))
    {
        U1STAbits.OERR = 0;
    }
    
    return U1RXREG;
}

static void UART1_Write(uint8_t txData)
{
    while(U1STAbits.UTXBF == 1)
    {
        
    }

    U1TXREG = txData;    // Write the data byte to the USART.
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
