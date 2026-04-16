namespace Hard_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////Task 7 – Simple Calculator/////////////
            ///

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /) or 'exit' to quit: ");
            string op = Console.ReadLine();

            if (op == "exit")
                break;

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case "/":
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.WriteLine(); // سطر فاضي للتنظيم

            ////////////////////Task 8 – Prime Number Checker in a Range//
            ///

            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = start; i <= end; i++)
            {
                if (i > 1)
                {
                    bool isPrime = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(i);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No prime numbers found");
            }
            ////////////////////Task 9 – Student Grade Report///////
            ///

            Console.Write("Enter number of students: ");
            int N = int.Parse(Console.ReadLine());

            int[] scores = new int[N];

            int excellent = 0, veryGood = 0, good = 0, pass = 0, fail = 0;

            int max = int.MinValue;
            int min = int.MaxValue;

            // إدخال الدرجات + طباعة التقدير
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter score for student " + (i + 1) + ": ");
                int score = int.Parse(Console.ReadLine());
                scores[i] = score;

                // تحديث أعلى وأقل
                if (score > max) max = score;
                if (score < min) min = score;

                int key = score / 10;

                switch (key)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("Excellent");
                        break;

                    case 8:
                        Console.WriteLine("Very Good");
                        break;

                    case 7:
                    case 6:
                        Console.WriteLine("Good");
                        break;

                    case 5:
                        Console.WriteLine("Pass");
                        break;

                    default:
                        Console.WriteLine("Fail");
                        break;
                }
            }

            // العدّ (loop ثاني)
            for (int i = 0; i < N; i++)
            {
                int key = scores[i] / 10;

                switch (key)
                {
                    case 10:
                    case 9:
                        excellent++;
                        break;

                    case 8:
                        veryGood++;
                        break;

                    case 7:
                    case 6:
                        good++;
                        break;

                    case 5:
                        pass++;
                        break;

                    default:
                        fail++;
                        break;
                }
            }

            // التقرير النهائي
            Console.WriteLine("\n--- Report ---");
            Console.WriteLine("Excellent: " + excellent);
            Console.WriteLine("Very Good: " + veryGood);
            Console.WriteLine("Good: " + good);
            Console.WriteLine("Pass: " + pass);
            Console.WriteLine("Fail: " + fail);

            Console.WriteLine("Highest score: " + max);
            Console.WriteLine("Lowest score: " + min);
        }


        ////////////Task 10 – Mini Banking System//////
        ///

        static void Main()
        {
            string correctPin = "9999";
            int attempts = 0;
            bool loggedIn = false;

            // Step 1: Login
            while (attempts < 3)
            {
                Console.Write("Enter PIN: ");
                string pin = Console.ReadLine();

                if (pin == correctPin)
                {
                    loggedIn = true;
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Wrong PIN");
                }
            }

            if (!loggedIn)
            {
                Console.WriteLine("Card Blocked");
                return;
            }

            // Step 2: Menu
            double balance = 5000;

            string[] logType = new string[100];
            double[] logAmount = new double[100];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\n1 = Check Balance");
                Console.WriteLine("2 = Deposit");
                Console.WriteLine("3 = Withdraw");
                Console.WriteLine("4 = Exit");

                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Balance: " + balance);
                        break;

                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double dep = double.Parse(Console.ReadLine());

                        if (dep > 0 && dep <= 10000)
                        {
                            balance += dep;

                            logType[count] = "Deposit";
                            logAmount[count] = dep;
                            count++;

                            Console.WriteLine("Deposit successful");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount");
                        }
                        break;

                    case 3:
                        Console.Write("Enter withdraw amount: ");
                        double wit = double.Parse(Console.ReadLine());

                        if (wit > 0 && wit <= balance)
                        {
                            balance -= wit;

                            logType[count] = "Withdraw";
                            logAmount[count] = wit;
                            count++;

                            Console.WriteLine("Withdraw successful");
                        }
                        else if (wit > balance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount");
                        }
                        break;

                    case 4:
                        // Step 4: Transaction Log
                        Console.WriteLine("\n--- Transactions ---");

                        if (count == 0)
                        {
                            Console.WriteLine("No transactions");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(logType[i] + ": " + logAmount[i]);
                            }
                        }

                        return;

                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;
                }
            }
        }
    