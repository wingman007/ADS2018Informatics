using System;

namespace SearchinString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Intel Corporation (commonly known as Intel and stylized as intel)" +
                " is an American multinational corporation and technology company headquartered " +
                "in Santa Clara, California, in the Silicon Valley and on 6 Campus Drive, Parsippany-Troy Hills," +
                " New Jersey. It is the world's second largest and second highest valued semiconductor chip maker " +
                "based on revenue after being overtaken by Samsung.";
            string seatchString = "Intel";

            bool isFind = str.Contains(seatchString);

            Console.WriteLine(isFind);
        }
    }
}
