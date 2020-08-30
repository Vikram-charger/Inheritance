using System;

namespace Inheritance
{
    class MyDarling
    {
        static void Main(string[] args)
        {
            Darling myDarling = new Darling("Charlzie Theron", 120, 45, 57);
            Console.WriteLine("Darling Name :"+myDarling.heroineName+"\nDarling Age :"+myDarling.heroineAge+"\nDarling Height :"+myDarling.heroineHeight+"\nDarling Movies :"+myDarling.heroineMoviesCount);
            Console.WriteLine("Darling's Latest Movie");
            myDarling.latestMovie();
        }
    }
}
