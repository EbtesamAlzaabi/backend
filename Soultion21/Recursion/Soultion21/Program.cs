// Recursion function
static void Hello()
{
    Console.WriteLine("please enter your age");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age > 18)
    {
        Hello();
    }
    else
        return;
}
static void Main(string[] args)
{
    Hello();
}