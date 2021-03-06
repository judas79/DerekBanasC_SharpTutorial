﻿// using directives, Libraries containing functions and objects
using System;
// use dictionaries
using System.Collections.Generic;
// use list arrays
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
// for big numbers
using System.Numerics;
// for culture specific formatting
using System.Globalization;
using System.Threading;
// Used for file and directory manipulation
using System.IO;
// for string builder
using System.Text;
// Used to serialize an object to binary format
using System.Runtime.Serialization.Formatters.Binary;
// Used to serialize into XML
using System.Xml.Serialization;

// Namespace to define globaly unique objects
namespace DerekBanasC_SharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // create animal object
            Animal bowser = new Animal("Bowser", 45, 25);

            //----------- Serialize Object to file -------------

            // Serialize the object data to a file, open it,
            // create it if it doesn't exist
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            // store data in binary format
            BinaryFormatter bf = new BinaryFormatter();

            // Send the object data to the opened file, "AnimalData.dat"
            // using stream and animal object, "bowser", then close Stream
            bf.Serialize(stream, bowser);
            stream.Close();

            // Delete the data form object, bowser
            // to show the data has been saved to AnimalData.dat
            bowser = null;

            // Read object data from the file, AnimalData.dat
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();

            // to get the data for bowser,
            // bf.Deserialize(stream), cast as Animal
            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine(bowser.ToString());

            //---------- XMLSerializer -----------

            // Change bowser to show changes were made
            bowser.Weight = 50;

            // XmlSerializer writes object data as XML
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\judas\C#Data\bowser.xml"))
            {
                // serialize using textwriter to write to bowser.xml
                serializer.Serialize(tw, bowser);
            }

            // Delete bowser data
            bowser = null;

            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\judas\C#Data\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();

            Console.WriteLine(bowser.ToString());

            //-------- Save a collection of Animals ----------

            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60, 30),
                new Animal("Luigi", 55, 24),
                new Animal("Peach", 40, 20)
            };

            using (Stream fs = new FileStream(@"C:\Users\judas\C#Data\animals.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // use filestream to serializ theAnimals list
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            // Delete list data
            theAnimals = null;

            // Read data from XML
            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\judas\C#Data\animals.xml"))
            {
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }


            foreach (Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }

            Console.ReadLine();

        }
    }
}