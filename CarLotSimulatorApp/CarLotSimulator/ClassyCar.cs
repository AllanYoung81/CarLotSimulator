﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class ClassyCar
    {
        //DONE--Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //DONE--Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public ClassyCar()
        {
            CarLot.numberOfCars++;
            //ClassName.StaricMember(increment by each new car added)
        }

            public ClassyCar(int year, 
                            string make, 
                            string model,
                            string engineNoise,
                            string honkNoise, 
                            bool isDriveable) 
                    {
                            Year = year;
                            Make = make;
                            Model = model;
                            EngineNoise = engineNoise;
                            HonkNoise = honkNoise;
                            IsDriveable = isDriveable;      
                    }

        public int Year { get; set; }
        public string Make { get; set; }  
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

    }   
}
