﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    // If this class was sealed you couldn't inherit 
    // from it:
    // sealed class Animal
    class Animal
    {
        //custom collection
        // properties
        public string Name { get; set; }

        // constructor
        public Animal(string name = "No Name")
        {
            //set name
            Name = name;
        }
    }
}
