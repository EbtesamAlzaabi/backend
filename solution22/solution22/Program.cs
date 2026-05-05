using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Name = "Sonata";
            myCar.Color = "white";
            myCar.Model_year = 2018;

            Console.WriteLine("Enter speed value:");
            int speed = Convert.ToInt32(Console.ReadLine());

            myCar.speed = speed;

            Console.WriteLine("Name: " + myCar.Name);
            Console.WriteLine("Color: " + myCar.Color);
            Console.WriteLine("Model-Year: " + myCar.Model_year);
            Console.WriteLine("Final Speed: " + myCar.speed);
        }
    }

    class Car
    {
        public string Name;
        public string Color;
        public int Model_year;

        private int temp;

        public int speed
        {
            get { return temp; }
            set
            {
                if (value > 0)
                    temp = value;
                else
                {
                    Console.WriteLine("Speed must be greater than zero");
                    temp = 0;
                }
            }
        }
    }
}