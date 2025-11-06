namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();

            string command;
            while ((command = Console.ReadLine()) != null && command.ToLower() != "finish")
            {
                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmd = parts[0].ToLower();

                switch (cmd)
                {
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "ins":
                        {
                            int index = int.Parse(parts[1]);
                            int element = int.Parse(parts[2]);
                            if (index >= 0 && index <= nums.Count)
                                nums.Insert(index, element);
                            else
                                Console.WriteLine("Invalid index");
                        }
                        break;

                    case "del":
                        {
                            int element = int.Parse(parts[1]);
                            if (nums.Contains(element))
                                nums.Remove(element);
                            else
                                Console.WriteLine("Element not found");
                        }
                        break;

                    case "contains":
                        {
                            int element = int.Parse(parts[1]);
                            Console.WriteLine(nums.Contains(element) ? "Yes" : "No");
                        }
                        break;

                    case "remove":
                        {
                            int index = int.Parse(parts[1]);
                            if (index >= 0 && index < nums.Count)
                                nums.RemoveAt(index);
                            else
                                Console.WriteLine("Invalid index");
                        }
                        break;

                    case "add":
                        {
                            int num1 = int.Parse(parts[1]);
                            int num2 = int.Parse(parts[2]);
                            nums.Add(num1 + num2);
                        }
                        break;

                    case "countl":
                        {
                            int limit = int.Parse(parts[1]);
                            int count = nums.Count(x => x > limit);
                            Console.WriteLine($"CountL={count}");
                        }
                        break;
                        //
                    case "countodds":
                        {
                            int count = nums.Count(x => x % 2 != 0);
                            Console.WriteLine($"CountOdds={count}");
                        }
                        break;

                    case "countevens":
                        {
                            int count = nums.Count(x => x % 2 == 0);
                            Console.WriteLine($"CountEvens={count}");
                        }
                        break;
                        //
                    case "sumall":
                        {
                            int sum = nums.Sum();
                            Console.WriteLine($"SumAll={sum}");
                        }
                        break;
                        //
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}
