class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Select choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    goals.Add(new SimpleGoal(name, desc, points));

                else if (type == "2")
                    goals.Add(new EternalGoal(name, desc, points));

                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
                }
            }

            else if (choice == "3")
            {
                Console.Write("Which goal? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                int earned = goals[index].RecordEvent();
                score += earned;

                Console.WriteLine($"You earned {earned} points!");
            }

            else if (choice == "6")
                break;
        }
    }
}
