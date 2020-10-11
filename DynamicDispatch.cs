using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DynamicDispatchBenchmark.Dynamic
{
    public class DynamicDispatch
    {
        public List<string> TestDispatch()
        {
            var classifier = new Classifier();            
            List<Animal> animals = new List<Animal> { new Dog(), new Snail(), new Lizard() };
            return animals.Select(a => classifier.Classify(a)).ToList();
        }
    }

    abstract class Animal { };
    class Dog : Animal { };
    class Lizard : Animal { };
    class Snail : Animal { }
    class Classifier
    {
        public string Classify(Animal animal) { return GetAnimalClass(animal as dynamic); }
        public string GetAnimalClass(Animal animal) { return "FALLBACK"; }
        public string GetAnimalClass(Dog dog) { return "Mammalia"; }
        public string GetAnimalClass(Lizard lizard) { return"Reptilia"; }
        public string GetAnimalClass(Snail snail) { return"Gastropoda"; }
    }
}
