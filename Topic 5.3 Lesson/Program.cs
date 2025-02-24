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
            //End of Task 1 with && and start of Task 2 with &&

            String password;
            int guesses;

            Console.Write("How many guesses did you take? ");
            guesses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("What is the password? ");
            password = Console.ReadLine();
            Console.WriteLine();
            if (guesses <= 5 && password == "Santa")
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            //End of && tasks and start of || Example and tasks

            string topping;

            Console.Write("What is the pizza topping? ");
            topping = Console.ReadLine();
            Console.WriteLine();
            if (topping == "pepperoni" || topping == "bacon")
            {
                Console.WriteLine("I would eat this");
            }
            else
            {
                Console.WriteLine("No thanks i'll pass");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            //Below is task 1 of ||
            string animal;

            Console.Write("What is your favourite animal? ");
            animal = Console.ReadLine();
            Console.WriteLine();
            if (animal == "Cat" || animal == "dog")
            {
                Console.WriteLine("Cat's are my personal favourite");
            }
            else
            {
                Console.WriteLine("Too each their own favourite");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            //Below is task 2 of || 

            string weather;
            int temperature;

            Console.Write("What is the temperature outside? ");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("What is the weather like (Sunny/Cloudy)? ");
            weather = Console.ReadLine();
            if (weather == "sunny" || temperature > 25)
            {
                Console.WriteLine("Go outside and enjoy the nice weather!");
            }
            else
            {
                Console.WriteLine("Stay inside, it's better than going outside unless you like going outside during bad weather");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\tThank you so much for to getting to the end:)\t");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
