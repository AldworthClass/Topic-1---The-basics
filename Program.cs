namespace Topic_1___The_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Console.Clear();
            Console.Title = "MY FANTASTIC PROGRAM";
            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Next year you will be " + (age + 1));


        }
    }
}