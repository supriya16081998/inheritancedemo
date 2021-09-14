using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancedemo
{
    class animal
    {
        //Implimentation of virtual method
        public virtual void FoodHabbits()
        {
            Console.WriteLine("Animals with different food habbits");
        }
    }

    class carnivours:animal
    {
        public override void FoodHabbits()
        {
            Console.WriteLine("Animals eat meat");
        }
    }

    class herbivours : animal
    {
        public override void FoodHabbits()
        {
            Console.WriteLine("Animals eat grass");
        }
    }

    class implement
    {
        public static void callfun(animal obj)
        {
            obj.FoodHabbits();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            animal a = new animal();
            herbivours h = new herbivours();
            carnivours c = new carnivours();
            //static binding/early binding
            a.FoodHabbits();
            h.FoodHabbits();
            c.FoodHabbits();
            //dynamic binding/late binding
            implement.callfun(h);
            Console.ReadLine();
        }
    }
}
