using System.ComponentModel.Design.Serialization;

namespace project01
{
    internal class Program
    {

        //overloading

        //static int sum(int x, int y)
        //{
        //    return x + y;   
        //}
        //static int sum(int x, int y, int z)
        //{
        //    return x + y+z;
        //}
        //static int sum(int x, int y, int z,int w)
        //{
        //    return x + y+z+w;
        //}
        //static double sum(double x, double y)
        //{
        //    return x + y;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(sum(10,20));
        //    Console.WriteLine(sum(10,20,30));
        //    Console.WriteLine(sum(10,20,30,40));
        //    Console.WriteLine(sum(10.2,20.3));


        //}

        //-----------------------------------------------------------------------------------------

        //Refrence and out


        static void increase1(ref int x)
        {
            x = x + 1;

        }
        static void Main(string[] args)
        {
            int num = 5;
            increase1(ref num);
            Console.WriteLine(num);
        }



        static void increase2(out int x)
        {
            x = 1;

        }
        static void Main(string[] args)
        {
            int num;
            increase2(out num);
            Console.WriteLine(num);
        }

    }
}