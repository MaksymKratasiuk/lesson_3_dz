namespace lesson_3_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the task number (1-6): ");
            int taskNumber = int.Parse(Console.ReadLine());
            do
            {
                switch (taskNumber)
                {
                    case 1:
                        Task1.square();
                        break;
                    case 2:
                        Task2.palindrom();
                        break;
                    case 3:
                        Task3.filter();
                        break;
                    case 4:
                        Task4 website = new Task4();
                        website.InputData();
                        website.DisplayData();
                        break;
                    case 5:
                        Task5 journal = new Task5();
                        journal.SetName("Example Journal");
                        journal.SetFoundedYear(2020);
                        journal.SetDescription("This is an example journal.");
                        journal.SetPhone("+1-555-555-5555");
                        journal.SetEmail("example@journal.com");
                        journal.PrintJournalInfo();
                        break;
                    case 6:
                        Task6 shop = new Task6();
                        shop.InputData();
                        shop.PrintData();
                        break;
                    default:
                        Console.WriteLine("Invalid task number.");
                        break;
                }
            } while (taskNumber != 0);
            Console.ReadLine();
        }
    }
}