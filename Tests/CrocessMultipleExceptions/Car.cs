﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Car
    {
        //define constant for Max car speed
        public const int MaxSpeed = 100;

        //common car's properties
        public int CurrSpeed { get; set; }
        public string PetName { get; set; }
        // field that defined car's state
        public bool CarIsDead;

        // Agregation of Radio in car class (car has a radio)
        public Radio MusicBox = new Radio();

        // constructors
        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrSpeed = speed;
        }
        // method to delegate radio properties
        public void RadioTune(bool state)
        {
            MusicBox.TurnRadioOn(state);
        }
        // method to check that car's temperature is ok
        public void Accelerate (int delta)
        {
            if (CarIsDead)
                Console.WriteLine($"{PetName}is out of order");//car is broken
            else
            {
                if (delta < 0)
                {
                    throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero");
                }
                CurrSpeed += delta;
                if (CurrSpeed > MaxSpeed)
                {
                    Console.WriteLine($"{PetName} is overheated");
                    CurrSpeed = 0;
                    CarIsDead = true;
                    Exception ex = new Exception(String.Format($"the car was overheated!"));
                    ex.HelpLink = "www.mail.ru";
                    ex.Data.Add("TimeStamp", string.Format($"Date is:{DateTime.Now}"));
                    throw ex;
                    // this is a simple way of throwing exception
                    //throw new Exception(String.Format($"the car was overheated!"));
                }
                else
                    Console.WriteLine($"{PetName} speed is : {CurrSpeed}");
            }
        }
    }
}
