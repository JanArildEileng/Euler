﻿using jae.euler.lib;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var sut = new E060PrimePairSets(1000000);
            sut.GetLowestSum(pairsetSize: 5);



        }

       
    }


   
}
