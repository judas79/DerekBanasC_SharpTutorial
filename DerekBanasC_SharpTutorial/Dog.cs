﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    // When you inherit from another class you
    // receive all of its fields and methods
    // You cannot inherit from multiple classes
    class Dog : Animal
    {
        // You can add additional properties
        // or fields, Grrr is the default if nothing is passed in
        public string Sound2 { get; set; } = "Grrrrr";

        // You can overwrite methods by adding 'new' in a method
        // the original MakeSound method must be a virtual method(see Animal.cs)
        /*
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        */

        // Add override so that the correct method
        // is called when a Dog is created as an
        // Animal type
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }


        // Create a constructor that has the base 
        // constructor initialize everything except 
        // Sound2
        public Dog(string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound 2")
            // initialize sound and name in the superclass(class that they where inherited from)
            // uses ': base' to call the superclass  Anumal constructor to handle values for name and sound
            : base(name, sound)
        {
            // assign sound2 to Sound2, in this class
            Sound2 = sound2;
        }
    }
}
