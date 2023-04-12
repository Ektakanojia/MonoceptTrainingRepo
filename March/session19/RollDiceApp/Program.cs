namespace RollDiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rolldice(10);
        }

        public static void Rolldice(int roll)
        {
           
            int num;
            Random rnd = new Random();
            Dictionary<int, int> rolldice = new Dictionary<int, int>();
            for (int i = 0; i < roll; i++)
            {

                num = rnd.Next(1, 6);
                //Console.WriteLine("The number :" + num + " ith index" + i);

                if (rolldice.ContainsKey(num))
                 {
                    
                    rolldice[num]++;
                 
                }
                else
                {
                    rolldice.Add(num, 1);
                }

            }
           
            PrintRollDice(rolldice);

        }

        private static void PrintRollDice(Dictionary<int, int> rolldice)
        {
            foreach (var row in rolldice)
            {
                Console.WriteLine("rolled side is {0} -Occurenece is{1}", row.Key, row.Value);
            }
        }
    }
}