int inp = int.Parse(Console.ReadLine());
            bool prime = true;
            Console.WriteLine("---------------------");
            if (inp <= 1)
            {
                prime = false;
            }
            for (int i = 2; i < inp; i++)
            {
                if (inp % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine($"prime {prime}");
            Console.ReadKey();
