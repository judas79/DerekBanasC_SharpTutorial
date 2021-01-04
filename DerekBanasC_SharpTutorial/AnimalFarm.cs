using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    // IEnumerable provides for iteration 
    // over a collection
    class AnimalFarm : IEnumerable
    {
        // set up custom list
        // Holds list of Animals
        // Animal class and constructor in Animal.cs
        private List<Animal> animalList = new List<Animal>();

        // constructor, receives a list of Animal
        public AnimalFarm(List<Animal> animalList)
        {
            // this animlList equals the passed in animalList
            this.animalList = animalList;
        }

        // constructor that doesn't receive anything
        public AnimalFarm()
        {
        }

        // Indexer for AnimalFarm created with this[] uses integers for the indexes
        public Animal this[int index]
        {
            // define whats gpoing to happen when the user calls 
            // for individual pieces of this collection
            // get returns an animal from animalList, at the givin index
            get { return (Animal)animalList[index]; }
            // define setting a value into animalList, 
            // at a chosen index, and the value to be set
            set { animalList.Insert(index, value); }
        }

        // set up count 
        // Returns the number of values 
        //in the collection, no set
        public int Count
        {
            get
            {
                return animalList.Count;
            }
        }

        // Returns an enumerator that is used to 
        // iterate through the collection
        // also fills requirement of inheriting from IEnumerable at the top
        IEnumerator IEnumerable.GetEnumerator()
        {
            // define how return is set up
            return animalList.GetEnumerator();
        }
    }
}
