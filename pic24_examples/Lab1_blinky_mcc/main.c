/**
  Generated Main Source File

  Company:
    Microchip Technology Inc.

  File Name:
    main.c

  Summary:
    This is the main file generated using PIC24 / dsPIC33 / PIC32MM MCUs

  Description:
    This header file provides implementations for driver APIs for all modules selected in the GUI.
    Generation Information :
        Product Revision  :  PIC24 / dsPIC33 / PIC32MM MCUs - pic24-dspic-pic32mm : 1.65
        Device            :  PIC24F16KA102
    The generated drivers are tested against the following:
        Compiler          :  XC16 v1.35
        MPLAB             :  MPLAB X v4.20
*/

/*
    (c) 2016 Microchip Technology Inc. and its subsidiaries. You may use this
    software and any derivatives exclusively with Microchip products.

    THIS SOFTWARE IS SUPPLIED BY MICROCHIP "AS IS". NO WARRANTIES, WHETHER
    EXPRESS, IMPLIED OR STATUTORY, APPLY TO THIS SOFTWARE, INCLUDING ANY IMPLIED
    WARRANTIES OF NON-INFRINGEMENT, MERCHANTABILITY, AND FITNESS FOR A
    PARTICULAR PURPOSE, OR ITS INTERACTION WITH MICROCHIP PRODUCTS, COMBINATION
    WITH ANY OTHER PRODUCTS, OR USE IN ANY APPLICATION.

    IN NO EVENT WILL MICROCHIP BE LIABLE FOR ANY INDIRECT, SPECIAL, PUNITIVE,
    INCIDENTAL OR CONSEQUENTIAL LOSS, DAMAGE, COST OR EXPENSE OF ANY KIND
    WHATSOEVER RELATED TO THE SOFTWARE, HOWEVER CAUSED, EVEN IF MICROCHIP HAS
    BEEN ADVISED OF THE POSSIBILITY OR THE DAMAGES ARE FORESEEABLE. TO THE
    FULLEST EXTENT ALLOWED BY LAW, MICROCHIP'S TOTAL LIABILITY ON ALL CLAIMS IN
    ANY WAY RELATED TO THIS SOFTWARE WILL NOT EXCEED THE AMOUNT OF FEES, IF ANY,
    THAT YOU HAVE PAID DIRECTLY TO MICROCHIP FOR THIS SOFTWARE.

    MICROCHIP PROVIDES THIS SOFTWARE CONDITIONALLY UPON YOUR ACCEPTANCE OF THESE
    TERMS.
*/

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
#include <stdint.h>
#include "mcc_generated_files/mcc.h"

static inline void delay_s(void)
{
    uint16_t delay_val = 2048;
    uint16_t i, j = 0;
    
    for(i = 0; i < delay_val; i++)
    {
        j = 100;
        while(j-- >= 1) {}
    }
}
/*
                         Main application
 */
int main(void)
{
    // initialize the device
    SYSTEM_Initialize();

    IO_RB15_SetLow();
    while (1)
    {
        // Add your application code
        IO_RB15_SetHigh();
        delay_s();
        
        IO_RB15_SetLow();
        delay_s();
    }

    return -1;
}
/**
 End of File
*/