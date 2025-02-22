﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.assignment_6
{
    public class ZooUtility
    {
        public static void DescribeAnimal(string name) 
        {
            Console.WriteLine($"Animal Name: {name}"); 
        }

        public static void DescribeAnimal(string name, string species) 
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}");
        }

        public static void DescribeAnimal(string name, string species, int age)
        {
            Console.WriteLine($"Animal Name: {name}, Species: {species}, Age: {age} years old"); 
        }
    }
}
