namespace DictonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }

        private static void CaseStudy1()
        {
           Dictionary<string ,string> stateCodes = new Dictionary<string ,string>();
            stateCodes.Add("MP", "Madhya Pardesh");
            stateCodes.Add("UP", "Uttar Pardesh");
            stateCodes.Add("KL", "Kerela");
            stateCodes.Add("KA", "Karnatak");
            if (stateCodes.ContainsKey("KL"))
            {
                stateCodes.Remove("KL");
                stateCodes.Add("KL", "NEW KERELA");

            }

            Console.WriteLine(stateCodes.Count);

            foreach(var row in stateCodes) 
            { 
                Console.WriteLine("key is {0} -value is{1}",row.Key,row.Value);
            }
            stateCodes["UP"] = "New Uttar Pardesh";
            Console.WriteLine(stateCodes["UP"]);
        }
    }
}