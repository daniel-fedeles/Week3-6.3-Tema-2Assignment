using System;

namespace week3.course2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            LeapYearOrNot(2300);
            //            AtmMenu();
            //            AddTwoNumbersInAFile();

        }

        static void LeapYearOrNot(int year)
        {
            if (year % 400 == 0 || year % 100 == 0 || year % 4 == 0)
            {
                Console.WriteLine($"The year {year} is Leap Year");
            }
            else
            {
                Console.WriteLine($"The year {year} is not Leap Year");
            }
        }

        static void AtmMenu()
        {
            Console.WriteLine("ATM");
            Console.WriteLine("Choose transaction");
            Console.WriteLine("1) Balance checking");
            Console.WriteLine("2) Cash withdrawal");
            Console.WriteLine("3) Cash deposition");
            Console.WriteLine("4) Abort");


            try
            {
                int nr = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                switch (nr)
                {
                    case 1:
                        BalanceChecking();
                        AtmMenu();
                        break;
                    case 2:
                        CashWithdrawal();
                        AtmMenu();
                        break;
                    case 3:
                        CashDeposition();
                        AtmMenu();
                        break;
                    case 4:
                        Console.WriteLine("Remove card");
                        break;
                }
            }
            catch (Exception e)
            {
                AtmMenu();
            }

        }

        static void BalanceChecking()
        {
            Console.WriteLine("Current account");
        }

        static void CashWithdrawal()
        {
            Console.WriteLine("All your money");
        }

        static void CashDeposition()
        {
            Console.WriteLine("Deposit");
        }

        static void AddTwoNumbersInAFile()
        {
            string[] lines =
                System.IO.File.ReadAllLines(
                    @"C:\Users\DanielFe\source\repos\Week3\week3.course2\week3.course2\TextFile.txt");
            int sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                sum += Int32.Parse(lines[i]);
            }

            Console.WriteLine(sum);
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\DanielFe\source\repos\Week3\week3.course2\week3.course2\TextFile.txt", true))
            {
                file.WriteLine(sum + Environment.NewLine);
            }

        }
    }
}
