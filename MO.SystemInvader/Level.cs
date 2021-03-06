﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MO.SystemInvader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MO.SystemInvader




{
    public class Level
    {
        int[,] map = new int[,]
        {
                   //00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//0
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//1
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//2
                    {00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,01,01,01,01,00,00,00,00,01,01,01,01,01,01,01,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//3
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,00,01,01,00,01,01,01,01,00,00,00,01,01,01,01,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//4
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,00,00,01,01,01,01,01,01,01,01,00,00,00,00,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//5
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//6
                    {00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//7
                    {01,01,01,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//8
                    {01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,01,00,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//9
                    {01,01,01,00,01,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,00,00,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//10
                    {01,01,01,00,01,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,00,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//11
                    {01,01,01,00,01,01,00,00,00,00,00,00,00,00,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,00,00,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,01,01,00,00,00,00,00,00,00},//12
                    {01,01,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,00,00,00,00,00,00,00},//13
                    {01,01,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//14
                    {01,01,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//15
                    {01,01,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,01,01,01,01,01,00,01,01,01,01,01,01,01,01,01,01,01,00,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,00,00,00,00},//16
                    {01,01,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,01,01,01,01,01,00,01,01,01,01,01,01,01,01,01,01,01,00,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,00,00,00,00},//17
                    {01,01,01,00,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,01,01,01,01,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,01,01,00,00,00,00,00,00,00,00,00,00,00,00},//18
                    {01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,00,00,00,00,00,01,01,00,00,00,00,00,00,00,00,00,00,00,00},//19
                    {01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,01,01,00,00,00,01,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//20
                    {01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,01,01,00,00,00,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//21
                    {01,01,01,01,01,01,01,01,01,01,00,01,01,01,01,01,01,00,00,00,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,00,00,01,01,00,00,00,00,00,01,01,00,00,00,00,00,00},//22
                    {01,01,01,01,01,01,01,01,01,01,00,00,01,01,01,01,01,00,00,00,01,00,01,01,01,01,01,01,01,01,01,01,01,01,01,01,00,01,01,01,00,00,00,00,00,01,01,00,00,00,00,00,01,01,00,00,00,00,00,00},//23
                    {00,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//24
                    {00,00,01,01,01,01,00,00,00,01,01,01,01,00,00,00,00,00,00,00,00,01,01,01,01,01,00,00,00,00,01,01,00,00,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//25
                    {00,00,00,01,01,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,01,01,01,01,01,00,00,00,00,01,01,00,00,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//26
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,01,01,00,00,00,00,00,00,00,00,01,01,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//27
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,01,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//28
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//29
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//30
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//31
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//32
                    {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//33
        };

        int[,] mapSnow = new int[,]
        {
           //00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//0
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//1
            {00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//2
            {00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//3
            {00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//4
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//5
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//6
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//7
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//8
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//9
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00},//10
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00},//11
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00},//12
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//13
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00},//14
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00},//15
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00},//16
            {00,00,00,00,00,00,00,01,01,01,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//17
            {00,00,00,00,00,00,00,01,01,01,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00},//18
            {00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00},//19
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00},//20
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//21
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00},//22
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00},//23
            {00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00},//24
            {00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//25
            {00,00,00,00,00,01,01,01,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//26
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//27
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//28
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//29
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//30
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//31
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//32
            {00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00,00},//33
        };

        public int mapWidth => map.GetLength(1);
        public int mapHeight => map.GetLength(0);
        public int snowWidth => mapSnow.GetLength(1);
        public int snowHeight => mapSnow.GetLength(0);

        public Texture2D _texture;
        public Texture2D _map;
        public Texture2D _mapSnow;

        public Texture2D _textureWaterFall1;
        public Texture2D _textureWaterFall2;

        private float _timeChangeSprite;

        Point _spritesEnemy = new Point(0, 0);
        Point _limitSprites = new Point(3, 4);
        
        public Vector2 AtTheEnd => new Vector2(53, 5) * 32;
        public Vector2 AtTheEndSnow => new Vector2(54, 0) * 32;
        List<Texture2D> _listTexture;

        //SnowFall
        private List<Snow> _snow = new List<Snow>();
        private Random _random = new Random();

        private List<Texture2D> _listeTextureSnow = new List<Texture2D>();
        string _folderPath = "Sprites/Snow/";
        public void AddTextureSnow(ContentManager content)
        {
            for (int i = 1; i <= 12; i++)
            {
                string nameImage = "Snow" + i.ToString();
                Texture2D newTexture = content.Load<Texture2D>(_folderPath + nameImage);
                _listeTextureSnow.Add(newTexture);
            }
        }

        public void AddSnowFall(Random random)
        {
            _random = random;
            for (int i = 0; i < 100; i++)
            {
                int j = _random.Next(0, 1920);
                _snow.Add(
                    new Snow(
                        _listeTextureSnow[_random.Next(0, 11)],
                        new Vector2(j, random.Next(0, 200)),
                        new Vector2(j, 1080),
                        _random.Next(1, 5))
                        );
            }
        }

        public int WindowWidth => 1920;
        public int WindowHeight => 1080;

        public Level()
        {
            _listTexture = new List<Texture2D>();
        }

        public bool IsInPaths(Vector2 vectorPos, Texture2D texture, Player player)
        {
            int Width = 0;
            int Height = 0;
            int[,] theMap = null;

            if (player.Map == 1)
            {
                Width = mapWidth;
                Height = mapHeight;
                theMap = map;
            }
            else if (player.Map == 2)
            {
                Width = snowWidth;
                Height = snowHeight;
                theMap = mapSnow;
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < Width; i++)
            {
                y = 0;
                for (int j = 0; j < Height; j++)
                {
                    if (theMap[j, i] == 0)
                    {

                        float mapX1 = x + 4;
                        float mapX2 = x + 28;
                        float mapY1 = y + 4;
                        float mapY2 = y + 28;
                        float towerX1 = vectorPos.X + 4;
                        float towerX2 = vectorPos.X + texture.Width - 4;
                        float towerY1 = vectorPos.Y + 4;
                        float towerY2 = vectorPos.Y + texture.Height - 4;

                        if ((mapX1 > towerX1 && mapX1 < towerX2) || (mapX2 > towerX1 && mapX2 < towerX2) || (towerX1 > mapX1 && towerX1 < mapX2) || (towerX2 > mapX1 && towerX2 < mapX2))
                        {
                            if ((mapY1 > towerY1 && mapY1 < towerY2) || (mapY2 > towerY1 && mapY2 < towerY2) || (towerY1 > mapY1 && towerY1 < mapY2) || (towerY2 > mapY1 && towerY2 < mapY2))
                            {
                                return true;
                            }
                        }
                    }
                    y += 32;
                }
                x += 32;
            }
            return false;
        }

        public void AddMap(Texture2D map, Texture2D mapSnow)
        {
            _map = map;
            _mapSnow = mapSnow;
        }

        public void AddWaterFall(Texture2D water1, Texture2D water2)
        {
            _textureWaterFall1 = water1;
            _textureWaterFall2 = water2;
        }

        public void AddTexture(List<Texture2D> listTexture)
        {
            _listTexture = listTexture;
        }

        public void SpritesUpdate()
        {
            if (_spritesEnemy.X < _limitSprites.X - 1)
                _spritesEnemy.X += 1;
            else
                _spritesEnemy.X = 0;
            _timeChangeSprite = 0;
        }

        public void Update(GameTime gameTime)
        {
            //Animation
            _timeChangeSprite += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_timeChangeSprite > 0.2)
            {
                SpritesUpdate();
            }
            foreach (Snow snowPoint in _snow)
            {
                snowPoint.Update(_random);
            }
        }

        public void DrawSnow(SpriteBatch batch)
        {
            foreach (Snow snowPoint in _snow)
            {
                snowPoint.Draw(batch);
            }
        }

        //Draw/////////////////////////////////////////////////////////////////////////////////
        public void Draw(SpriteBatch batch, Player player)
        {
            if(player.Map == 1)
            {
                batch.Draw(_map, new Rectangle(0, 0, _map.Width, _map.Height), Color.White);
                batch.Draw(_textureWaterFall1,
                        new Rectangle(30 * 32 + 9, 7 * 32 - 3, 96, 128),
                        new Rectangle(_spritesEnemy.X * 96, 0, 96, 128),
                        Color.White);
                batch.Draw(_textureWaterFall2,
                        new Rectangle(16 * 32 - 16, 27 * 32, 161, 103),
                        new Rectangle(_spritesEnemy.X * 161, 0, 161, 103),
                        Color.White);
                batch.Draw(_textureWaterFall2,
                        new Rectangle(40 * 32 - 13, 29 * 32, 161, 103),
                        new Rectangle(_spritesEnemy.X * 161, 0, 161, 103),
                        Color.White);
            }
            else if(player.Map == 2)
            {
                batch.Draw(_mapSnow, new Rectangle(0, 0, _mapSnow.Width, _mapSnow.Height), Color.White);
                DrawSnow(batch);
            }

        }
    }
}
