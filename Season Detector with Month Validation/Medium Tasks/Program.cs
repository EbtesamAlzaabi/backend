namespace Medium_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////Task 4 – Season Detector with Month Validation
            ///

            Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    break;
         
            }



            //////////////////////Task 5 – Sum of Even and Odd Numbers
            ///

            Console.Write("Enter a positive number: ");
            int N = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }

            Console.WriteLine("Sum of even numbers: " + evenSum);
            Console.WriteLine("Sum of odd numbers: " + oddSum);
        }

        ////////////////////////////////////Task 6 – Password Retry System
        ///


        //string correctPassword = "1234";
        //int attempts = 0;
        //int maxAttempts = 3;

        //while (attempts < maxAttempts)
        //{
        //    Console.WriteLine("Enter your password: ");
        //    string? input = Console.ReadLine();
        //    attempts++; 

        //    if (input == correctPassword)
        //    {
        //        Console.WriteLine("Access Granted");
        //        break; 
        //    }
        //    else
        //    {
        //        if (attempts == maxAttempts)
        //        {
        //            Console.WriteLine("Account Locked");
        //        }
        //        else
        //        {

        //            int remaining = maxAttempts - attempts;
        //            Console.WriteLine($"Wrong password, try again. Attempts remain: {remaining}");
        //        }
        //    }
        //}

    }
}
    

