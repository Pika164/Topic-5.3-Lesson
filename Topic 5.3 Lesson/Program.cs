namespace Topic_5._3_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String working;
            int age;
            double money;

            //Example to get used to using && in if statements
            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
                {
                Console.WriteLine("You aren't a teenager");
                }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            //End of example and Beginning of Task 1 with &&

            Console.Write("How much money do you have? ");
            money = Convert.ToDouble(Console.ReadLine());
            Console.Write("Are you working? (yes/no) ");
            working = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (working == "no" && money >= 20)
            {
                Console.WriteLine("You can go to the movies!");
            }
            else
            {
                Console.WriteLine("Sorry but you can't go to the movies.");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            //End of Task 1 with && and start of Task 2 with && thingy
        }
    }
}
