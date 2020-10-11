using System.Collections.Generic;
using System.Linq;

namespace DynamicDispatchBenchmark.Visitor
{
    public class VisitorDispatch
    {
        public List<string> TestDispatch()
        {
            var classifier = new Classifier();
            List<Animal> animals = new List<Animal> { new Dog(), new Snail(), new Lizard() };
            return animals.Select(a => a.Accept(classifier)).ToList();
        }
    }

    abstract class Animal { public abstract string Accept(IClassifierVisitor visitor); }
    interface IClassifierVisitor
    {
        string Visit(Dog dog);
        string Visit(Lizard lizard);
        string Visit(Snail snail);
    }

    class Dog : Animal
    {
        public override string Accept(IClassifierVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    class Lizard : Animal
    {
        public override string Accept(IClassifierVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    class Snail : Animal
    {
        public override string Accept(IClassifierVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    class Classifier : IClassifierVisitor
    {
        public void Visit(Animal animal)
        {
            animal.Accept(this);
        }

        public string Visit(Snail snail)
        {
            return"Gastropoda";
        }

        public string Visit(Dog dog)
        {
            return"Mammalia";
        }

        public string Visit(Lizard lizard)
        {
            return"Reptilia";
        }
    }
}