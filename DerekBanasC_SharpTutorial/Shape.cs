﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    // a shape is not an  object with defined properties
    // create abstract class, 
    // a class you don't want to instantiate,
    // not create an object for this class type
    abstract class Shape
    {
        // property field
        public string Name { get; set; }
        
        // You can define non-abstract
        // methods in an abstract class
        // the same way as any other method
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        // We want subclasses to override
        // this method so mark it as abstract
        // You can only make abstract methods 
        // in abstract classes. 
        // No curly brackets, created to be overwritten
        public abstract double Area();
    }
}
