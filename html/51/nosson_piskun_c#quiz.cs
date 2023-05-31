using System.Collections;

namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "green", "blue" };
            string[] patterns = { "striped", "checked", "polka_dot" };
            ArrayList shirtList = new ArrayList();

            for (int i = 0; i < colors.Length; i++) 
            {
                for (int j = 0; j < patterns.Length; j++)
                {
                    Shirt shirt = new Shirt();
                    shirt.color = colors[i];
                    shirt.pattern = patterns[j];
                    shirtList.Add(shirt);
                }
            }

            foreach (var shirt in shirtList)
                Console.WriteLine(shirt.ToString());
        }

        class Shirt 
        {
            public string color;
            public string pattern;

            public override string ToString()
            {
                return color + ":" + pattern;
            }
        }


    }
}