﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    class Box
    {
        // define properties
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        // constructor
        // handles situation if user enters nothing, and passes to main constructor
        public Box()
        : this(1, 1, 1) { }

        // main constructor, gets passed user input 
        // or from the default, above
        public Box(double l,
            double w,
            double b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }

        // Through operator overloading you can
        // allow users to interact with your
        // custom objects in interesting ways
        // You can overload +, -, *, /, %, !,
        // ==, !=, >, <, >=, <=, ++ and --

        // define what happens if two boxes are added together
        // overload(overeide) the + operator, receives two boxes
        public static Box operator +(Box box1, Box box2)
        {
            //create new box
            Box newBox = new Box()
            {
                // define what happens
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return newBox;
        }

        // overload(overeide) the - operator, receives two boxes
        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return newBox;
        }

        // overload(overeide) the == operator, receives two boxes
        // compare two boxes to see if the dimmensions are the same
        // returns a bool, not a Box
        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }

        // habe to create a overload(overeide) the != operator, 
        // because == requires that we do so
        // receives two boxes
        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }

        // You define how your object is converted
        // into a string by overridding ToString()
        public override string ToString()
        {
            return String.Format("Box with : Height : {0} Width : {1} and Breadth : {2}\n",
                Length, Width, Breadth);
        }

        // You can convert from a Box into an
        // int like this even though this
        // wouldn't make sense
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        // Convert from an int to a Box
        public static implicit operator Box(int i)
        {
            // create new box object
            // Return a box with the lengths all
            // set to the int passed
            return new Box(i, i, i);
        }

    }
}