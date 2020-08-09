using System;
using System.Collections.Generic;

namespace BeeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            Bee bee1 = new Bee("John" , 3.2);
            Bee bee2 = new Bee("Paul" , 2.7);
            Bee bee3 = new Bee("George" , 1.1);
            Bee bee4 = new Bee("Ringo" , 2.0);
            

            Beehive beehive1 = new Beehive();

            beehive1.AddBee(bee1);
            beehive1.AddBee(bee2);
            beehive1.AddBee(bee3);
            beehive1.AddBee(bee4);
            System.Console.WriteLine("Number Of Bees " + beehive1.MaxAmountOfBees());
            double totalHoneyCollected = beehive1.CollectHoney(5);
            Console.WriteLine("Amount Of Honey Collected " + totalHoneyCollected);

            Beehive beehive2 = new Beehive();

            Bee bee5 = new Bee("Kurt" , 2.3);
            Bee bee6 = new Bee("Dave" , 7.4);
            Bee bee7= new Bee("Krist" , 1.5);

            beehive2.AddBee(bee5);
            beehive2.AddBee(bee6);
            beehive2.AddBee(bee7);
            System.Console.WriteLine("Number Of Bees " + beehive2.MaxAmountOfBees());
            double totalHoneyCollected2 = beehive2.CollectHoney(6);
            Console.WriteLine("Amount Of Honey Collected " + totalHoneyCollected2);
        }
    }

    class Beehive 
    {
        
        // attributes
        
        //int NumberOfBees;

        List<Bee> myBeeCollection = new List<Bee>();

        //constructors

    
        public Beehive() 
        {
            
        }

        public List<Bee> Bees 
        {
            get
            {
                return myBeeCollection;
            }
        }

        public void AddBee(Bee newBee)
        {
            myBeeCollection.Add(newBee);
        }
        
        public int MaxAmountOfBees()
        {
            return myBeeCollection.Count;    
        }
        
        public double CollectHoney(int days)
        {
            double totalSize = 0;
            foreach(Bee currentBee in myBeeCollection)
            {
                totalSize += currentBee.Size;
            } 
            return days * totalSize * 0.2; 

        }

        //operations
        
    }

    class Bee
    {
        public string Name;
        public double Size;

        public Bee(string name, double size)
        {
            Name = name;
            Size = size;
        }
            
    }



}

